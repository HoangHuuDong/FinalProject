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
    
    public partial class XUATKHO_CT
    {
        public int SoPhieuX { get; set; }
        public int STT { get; set; }
        public string MaHang { get; set; }
        public int SLXuat { get; set; }
        public int DGXuat { get; set; }
    
        public virtual HANGHOA HANGHOA { get; set; }
        public virtual XUATKHO XUATKHO { get; set; }
    }
}
