//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUAYENETAKIP.DBOBECT
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOKTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOKTOR()
        {
            this.RANDEVU = new HashSet<RANDEVU>();
        }
    
        public int DOKTORID { get; set; }
        public int ANABILIMDALIID { get; set; }
        public string TCKIMLIKNO { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public System.DateTime DOGUMTARIHI { get; set; }
        public string KANGRUBU { get; set; }
        public string CINSIYET { get; set; }
        public string TELEFON { get; set; }
        public string EPOSTA { get; set; }
        public string ADRES { get; set; }
        public string SIFRE { get; set; }
        public bool AKTIF { get; set; }
    
        public virtual ANABILIMDALI ANABILIMDALI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANDEVU> RANDEVU { get; set; }
    }
}
