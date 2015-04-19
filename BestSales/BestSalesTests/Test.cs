using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestSales.Models.DbInsert;
using BestSales;
using BestSales.Models.DB;

namespace BestSalesTests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
         RandomCarGenerator rcg = new RandomCarGenerator();

            
            var z = Factories.TranslateColour["CZARNY"];
           var c = rcg.ReturnRandomCar();
            ImageGenerator img = new ImageGenerator();
            for (int i = 0; i < 20; i++)
            {
                rcg.ReturnRandomCar();
                img.GetRandomImage(RandomCarGenerator.query);
                
            }

  


        }
    }
}
