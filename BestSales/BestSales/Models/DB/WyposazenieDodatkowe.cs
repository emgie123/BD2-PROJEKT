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
    
    public partial class WyposazenieDodatkowe
    {
        public Nullable<int> IdSamochodu { get; set; }
        public bool Abs { get; set; }
        public bool Esp { get; set; }
        public bool Asr { get; set; }
        public bool AirBag { get; set; }
        public bool Wspomaganie { get; set; }
        public bool Klimatyzacja { get; set; }
        public bool ZapasoweOpony { get; set; }
    
        public virtual DaneSamochodu DaneSamochodu { get; set; }
    }
}
