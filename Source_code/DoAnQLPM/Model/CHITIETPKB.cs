//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnQLPM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETPKB
    {
        public int MaCTPKB { get; set; }
        public int MaPKB { get; set; }
        public int MaThuoc { get; set; }
        public int SLThuoc { get; set; }
        public string CachDung { get; set; }
    
        public virtual PhieuKB PhieuKB { get; set; }
        public virtual Thuoc Thuoc { get; set; }
    }
}