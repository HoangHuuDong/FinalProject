//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class XUATKHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XUATKHO()
        {
            this.XUATKHO_CT = new HashSet<XUATKHO_CT>();
        }
    
        public int SoPhieuX { get; set; }
        public Nullable<System.DateTime> NgayXuat { get; set; }
        public string MaKH { get; set; }
        public string LyDoXuat { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XUATKHO_CT> XUATKHO_CT { get; set; }
    }
}
