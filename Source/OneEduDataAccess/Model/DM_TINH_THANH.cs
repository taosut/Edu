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
    
    public partial class DM_TINH_THANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_TINH_THANH()
        {
            this.DM_QUAN_HUYEN = new HashSet<DM_QUAN_HUYEN>();
            this.DM_XA_PHUONG = new HashSet<DM_XA_PHUONG>();
            this.HOC_SINH = new HashSet<HOC_SINH>();
            this.TRUONGs = new HashSet<TRUONG>();
        }
    
        public short MA { get; set; }
        public string TEN { get; set; }
        public Nullable<short> THU_TU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_QUAN_HUYEN> DM_QUAN_HUYEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_XA_PHUONG> DM_XA_PHUONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOC_SINH> HOC_SINH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRUONG> TRUONGs { get; set; }
    }
}
