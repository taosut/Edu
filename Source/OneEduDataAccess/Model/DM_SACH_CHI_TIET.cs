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
    
    public partial class DM_SACH_CHI_TIET
    {
        public long ID { get; set; }
        public short ID_KHOI { get; set; }
        public short ID_MON { get; set; }
        public long ID_SACH { get; set; }
        public Nullable<long> ID_TEN_BAI_HOC { get; set; }
        public Nullable<short> BAI_SO { get; set; }
        public Nullable<short> TRANG_SO { get; set; }
        public string ICON { get; set; }
        public string NOI_DUNG { get; set; }
        public string GHI_CHU { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
    
        public virtual DM_SACH DM_SACH { get; set; }
        public virtual DM_SACH_NOI_DUNG DM_SACH_NOI_DUNG { get; set; }
    }
}