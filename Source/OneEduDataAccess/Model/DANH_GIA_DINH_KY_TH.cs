//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneEduDataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DANH_GIA_DINH_KY_TH
    {
        public long ID { get; set; }
        public long ID_TRUONG { get; set; }
        public short MA_NAM_HOC { get; set; }
        public long ID_LOP { get; set; }
        public long ID_HOC_SINH { get; set; }
        public short MA_KY_DG { get; set; }
        public short MA_KHOI { get; set; }
        public string NL_TPVTQ { get; set; }
        public string NL_HT { get; set; }
        public string NL_TGQVD { get; set; }
        public string NL_MANX { get; set; }
        public string NL_NX { get; set; }
        public string PC_CHCL { get; set; }
        public string PC_TTTN { get; set; }
        public string PC_TTKL { get; set; }
        public string PC_DKYT { get; set; }
        public string PC_MANX { get; set; }
        public string PC_NX { get; set; }
        public string NX_GVCN { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
    
        public virtual TRUONG TRUONG { get; set; }
        public virtual NAM_HOC NAM_HOC { get; set; }
        public virtual LOP LOP { get; set; }
        public virtual HOC_SINH HOC_SINH { get; set; }
        public virtual KY_DG_TH KY_DG_TH { get; set; }
    }
}