//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BestSales.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModeleSamochodow
    {
        public ModeleSamochodow()
        {
            this.DaneSamochodu = new HashSet<DaneSamochodu>();
        }
    
        public int IdModelu { get; set; }
        public string Model { get; set; }
        public Nullable<int> IdMarki { get; set; }
        public string TypPojazdu { get; set; }
    
        public virtual ICollection<DaneSamochodu> DaneSamochodu { get; set; }
        public virtual MarkiSamochodow MarkiSamochodow { get; set; }
    }
}
