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
    
    public partial class Adres
    {
        public Adres()
        {
            this.Klienci = new HashSet<Klienci>();
        }
    
        public int IdAdresu { get; set; }
        public string Miejscowosc { get; set; }
        public string KodPocztowy { get; set; }
        public string Ulica { get; set; }
    
        public virtual ICollection<Klienci> Klienci { get; set; }
    }
}
