//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTYSProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producer
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Adress { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual District District { get; set; }
    }
}