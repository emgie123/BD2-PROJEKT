using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using BestSales.Models.DB;

namespace BestSales.Models.DbInsert
{
    public class ImageGenerator
    {
        private Random rnd;
        private string _imgTopic;
        private int _iterator;

        public ImageGenerator()
        {
            rnd = new Random();
        }
        private readonly List<string> _topics = new List<string>
        {
            
        };

        private string GetHtmlCode()
        {
           

            string url = "https://www.google.com/search?q=" + _imgTopic + "&tbm=isch";
            string data = "";

            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return "";
                using (var sr = new StreamReader(dataStream))
                {
                    data = sr.ReadToEnd();
                }
            }
            return data;
        }

        private List<string> GetUrls(string html)
        {
            var urls = new List<string>();
         
            int ndx = html.IndexOf("<img", 0, StringComparison.Ordinal);

            while (ndx >= 0)
            {
                ndx = html.IndexOf("src=\"", ndx, StringComparison.Ordinal);
                ndx = ndx + 5;
                int ndx2 = html.IndexOf("\"", ndx, StringComparison.Ordinal);
                string url = html.Substring(ndx, ndx2 - ndx);
                urls.Add(url);
                ndx = html.IndexOf("<img", ndx, StringComparison.Ordinal);
            }
            return urls;
        }

        private byte[] GetImage(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000);

                    return bytes;
                }
            }

            return null;
        }

        public void GetRandomImage(string imgTopic)
        {
            this._imgTopic = imgTopic;
            using (DB2KomisDataBaseEntities dbAccess = new DB2KomisDataBaseEntities())
            {
                _iterator = dbAccess.DaneSamochodu.Select(x => x.IdSamochodu).Max() + 1;
            }

            string html = GetHtmlCode();
            List<string> urls = GetUrls(html);

            int randomUrl = rnd.Next(0, urls.Count - 1);

            string luckyUrl = urls[randomUrl];

            byte[] image = GetImage(luckyUrl);
            using (var ms = new MemoryStream(image))
            {
                Image newImage = Image.FromStream(ms);
                newImage.Save("d:\\obrazy\\obrazek"+_iterator+".jpg");
            }

        }

   


    }
}