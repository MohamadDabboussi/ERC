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
    
    public partial class الآليات
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public الآليات()
        {
            this.المهمات_المنفذة = new HashSet<المهمات_المنفذة>();
        }
    
        public int رمز_الآلية { get; set; }
        public int المركز { get; set; }
        public string نوعية_الاستخدام { get; set; }
        public string موديل_ { get; set; }
        public string نوعية_السيارة { get; set; }
        public Nullable<bool> مازوت_او_بنزين { get; set; }
        public Nullable<int> رقم_اللوحة { get; set; }
        public Nullable<bool> بالخدمة_او_لا { get; set; }
        public Nullable<bool> متاحة_او_لا { get; set; }
    
        public virtual المراكز المراكز { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_المنفذة> المهمات_المنفذة { get; set; }
    }
}
