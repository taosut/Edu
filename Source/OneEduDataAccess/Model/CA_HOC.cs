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
    
    public partial class CA_HOC
    {
        public long ID { get; set; }
        public Nullable<short> TIET { get; set; }
        public Nullable<long> ID_LOP { get; set; }
        public Nullable<short> ID_HOC_KY { get; set; }
        public Nullable<long> ID_MON_2 { get; set; }
        public Nullable<long> ID_MON_3 { get; set; }
        public Nullable<long> ID_MON_4 { get; set; }
        public Nullable<long> ID_MON_5 { get; set; }
        public Nullable<long> ID_MON_6 { get; set; }
        public Nullable<long> ID_MON_7 { get; set; }
        public Nullable<long> ID_MON_8 { get; set; }
        public string THOI_GIAN { get; set; }
        public Nullable<long> ID_CAU_HINH_CA_HOC { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
        public short MA_NAM_HOC { get; set; }
        public long ID_TRUONG { get; set; }
    
        public virtual CAU_HINH_CA_HOC CAU_HINH_CA_HOC { get; set; }
        public virtual LOP LOP { get; set; }
    }
}