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
    
    public partial class DM_LOAI_NX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_LOAI_NX()
        {
            this.MA_NX_DINH_KY = new HashSet<MA_NX_DINH_KY>();
        }
    
        public short MA { get; set; }
        public string TEN { get; set; }
        public Nullable<short> THU_TU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA_NX_DINH_KY> MA_NX_DINH_KY { get; set; }
    }
}