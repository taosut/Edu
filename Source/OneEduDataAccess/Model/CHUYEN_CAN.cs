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
    
    public partial class CHUYEN_CAN
    {
        public long ID { get; set; }
        public long ID_HOC_SINH { get; set; }
        public long ID_LOP { get; set; }
        public short ID_NAM_HOC { get; set; }
        public short THANG { get; set; }
        public string NGAY1 { get; set; }
        public string NGAY2 { get; set; }
        public string NGAY3 { get; set; }
        public string NGAY4 { get; set; }
        public string NGAY5 { get; set; }
        public string NGAY6 { get; set; }
        public string NGAY7 { get; set; }
        public string NGAY8 { get; set; }
        public string NGAY9 { get; set; }
        public string NGAY10 { get; set; }
        public string NGAY11 { get; set; }
        public string NGAY12 { get; set; }
        public string NGAY13 { get; set; }
        public string NGAY14 { get; set; }
        public string NGAY15 { get; set; }
        public string NGAY16 { get; set; }
        public string NGAY17 { get; set; }
        public string NGAY18 { get; set; }
        public string NGAY19 { get; set; }
        public string NGAY20 { get; set; }
        public string NGAY21 { get; set; }
        public string NGAY22 { get; set; }
        public string NGAY23 { get; set; }
        public string NGAY24 { get; set; }
        public string NGAY25 { get; set; }
        public string NGAY26 { get; set; }
        public string NGAY27 { get; set; }
        public string NGAY28 { get; set; }
        public string NGAY29 { get; set; }
        public string NGAY30 { get; set; }
        public string NGAY31 { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public long ID_TRUONG { get; set; }
        public short MA_KHOI { get; set; }
        public Nullable<short> TONG_PHEP { get; set; }
        public Nullable<short> TONG_KHONG_PHEP { get; set; }
    
        public virtual HOC_SINH HOC_SINH { get; set; }
        public virtual KHOI KHOI { get; set; }
        public virtual LOP LOP { get; set; }
        public virtual NAM_HOC NAM_HOC { get; set; }
        public virtual TRUONG TRUONG { get; set; }
    }
}
