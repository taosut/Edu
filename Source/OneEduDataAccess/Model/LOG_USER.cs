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
    
    public partial class LOG_USER
    {
        public long ID { get; set; }
        public Nullable<long> ID_TRUONG { get; set; }
        public string THAO_TAC { get; set; }
        public string MO_TA { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
    
        public virtual NGUOI_DUNG NGUOI_DUNG { get; set; }
        public virtual TRUONG TRUONG { get; set; }
    }
}