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
    
    public partial class HOC_PHI_PHIEU_THU_HOC_SINH
    {
        public long ID { get; set; }
        public long ID_DOT_THU { get; set; }
        public long ID_TRUONG { get; set; }
        public short ID_NAM_HOC { get; set; }
        public short ID_KHOI { get; set; }
        public long ID_LOP { get; set; }
        public long ID_HOC_SINH { get; set; }
        public Nullable<bool> IS_TIEN_AN { get; set; }
        public Nullable<long> SO_TIEN_AN { get; set; }
        public Nullable<long> TONG_TIEN { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual HOC_PHI_DOT_THU HOC_PHI_DOT_THU { get; set; }
        public virtual HOC_SINH HOC_SINH { get; set; }
        public virtual TRUONG TRUONG { get; set; }
        public virtual KHOI KHOI { get; set; }
        public virtual NAM_HOC NAM_HOC { get; set; }
        public virtual LOP LOP { get; set; }
    }
}