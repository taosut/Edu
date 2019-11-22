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
    
    public partial class THUC_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUC_DON()
        {
            this.SUAT_AN = new HashSet<SUAT_AN>();
            this.THUC_DON_CHI_TIET = new HashSet<THUC_DON_CHI_TIET>();
        }
    
        public long ID { get; set; }
        public long ID_TRUONG { get; set; }
        public short ID_KHOI { get; set; }
        public long ID_BUA_AN { get; set; }
        public Nullable<long> SO_HOC_SINH_DK { get; set; }
        public Nullable<decimal> HAN_MUC_GIA { get; set; }
        public Nullable<decimal> TONG_NANG_LUONG_KCAL { get; set; }
        public Nullable<decimal> TONG_PROTID { get; set; }
        public Nullable<decimal> TONG_GLUCID { get; set; }
        public Nullable<decimal> TONG_LIPID { get; set; }
        public string GHI_CHU { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
        public Nullable<decimal> ID_NHOM_TUOI_MN { get; set; }
        public string TEN { get; set; }
    
        public virtual DM_BUA_AN DM_BUA_AN { get; set; }
        public virtual KHOI KHOI { get; set; }
        public virtual NHOM_TUOI_MN NHOM_TUOI_MN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUAT_AN> SUAT_AN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUC_DON_CHI_TIET> THUC_DON_CHI_TIET { get; set; }
        public virtual TRUONG TRUONG { get; set; }
    }
}
