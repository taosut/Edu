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
    
    public partial class CUSTOMER_TO_CUSTOMER
    {
        public decimal ID { get; set; }
        public short ID_TO { get; set; }
        public long ID_CUSTOMER { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
        public long ID_TRUONG { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual CUSTOMER_TO CUSTOMER_TO { get; set; }
        public virtual TRUONG TRUONG { get; set; }
    }
}
