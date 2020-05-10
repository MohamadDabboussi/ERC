//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Erc1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class المرضى
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public المرضى()
        {
            this.المهمات_الملغاة = new HashSet<المهمات_الملغاة>();
            this.المهمات_المنفذة = new HashSet<المهمات_المنفذة>();
        }
    
        public int الرمز { get; set; }
        public string اسم { get; set; }
        public Nullable<System.DateTime> تاريخ_الولادة { get; set; }
        public Nullable<int> وزن { get; set; }
        public Nullable<int> الضمان { get; set; }
        public string الهاتف { get; set; }
        public string العنوان { get; set; }
        public Nullable<int> رمز_المدينة { get; set; }
        public Nullable<int> أمراض_معدية { get; set; }
        public Nullable<int> رمز_المنطقة { get; set; }
        public Nullable<int> الطبيب_المعالج { get; set; }
    
        public virtual الأطباء الأطباء { get; set; }
        public virtual الأمراض_المعدية الأمراض_المعدية { get; set; }
        public virtual الجهات_الضامنة الجهات_الضامنة { get; set; }
        public virtual المدن المدن { get; set; }
        public virtual المناطق المناطق { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_الملغاة> المهمات_الملغاة { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_المنفذة> المهمات_المنفذة { get; set; }
    }
}
