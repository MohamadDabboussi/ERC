//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Erc1.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class الحالات
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public الحالات()
        {
            this.المهمات_الملغاة = new HashSet<المهمات_الملغاة>();
            this.المهماة_المؤجلة = new HashSet<المهماة_المؤجلة>();
        }
    
        public int رمز { get; set; }
        public Nullable<int> رمز_النوعية { get; set; }
        public string المرض { get; set; }
        public string المرض_بالانجليزي { get; set; }
    
        public virtual نوعيات_الحالات نوعيات_الحالات { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_الملغاة> المهمات_الملغاة { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهماة_المؤجلة> المهماة_المؤجلة { get; set; }
    }
}
