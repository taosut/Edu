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
    
    public partial class MON_HOC_TRUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MON_HOC_TRUONG()
        {
            this.DIEM_CHI_TIET = new HashSet<DIEM_CHI_TIET>();
            this.LOP_MON = new HashSet<LOP_MON>();
            this.DANH_GIA_DINH_KY_MON_TH = new HashSet<DANH_GIA_DINH_KY_MON_TH>();
        }
    
        public long ID { get; set; }
        public string TEN { get; set; }
        public Nullable<bool> IS_1 { get; set; }
        public Nullable<bool> IS_2 { get; set; }
        public Nullable<bool> IS_3 { get; set; }
        public Nullable<bool> IS_4 { get; set; }
        public Nullable<bool> IS_5 { get; set; }
        public Nullable<bool> IS_6 { get; set; }
        public Nullable<bool> IS_7 { get; set; }
        public Nullable<bool> IS_8 { get; set; }
        public Nullable<bool> IS_9 { get; set; }
        public Nullable<bool> IS_10 { get; set; }
        public Nullable<bool> IS_11 { get; set; }
        public Nullable<bool> IS_12 { get; set; }
        public Nullable<bool> KIEU_MON { get; set; }
        public Nullable<short> THU_TU { get; set; }
        public Nullable<System.DateTime> NGAY_SUA { get; set; }
        public Nullable<long> NGUOI_SUA { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public Nullable<long> NGUOI_TAO { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public string MA_CAP_HOC { get; set; }
        public Nullable<short> HE_SO { get; set; }
        public Nullable<short> ID_MON_HOC { get; set; }
        public Nullable<bool> IS_MON_CHUYEN { get; set; }
        public long ID_TRUONG { get; set; }
        public short ID_NAM_HOC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM_CHI_TIET> DIEM_CHI_TIET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_MON> LOP_MON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_GIA_DINH_KY_MON_TH> DANH_GIA_DINH_KY_MON_TH { get; set; }
    }
}
