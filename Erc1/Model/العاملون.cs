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
    
    public partial class العاملون
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public العاملون()
        {
            this.الفريق = new HashSet<الفريق>();
            this.المهمات_المنفذة = new HashSet<المهمات_المنفذة>();
            this.المهمات_المنفذة1 = new HashSet<المهمات_المنفذة>();
            this.المهمات_المنفذة2 = new HashSet<المهمات_المنفذة>();
        }
    
        public int الرمز { get; set; }
        public string الاسم { get; set; }
        public string الجنسية { get; set; }
        public string مكان_السجل { get; set; }
        public Nullable<int> رقم_السجل { get; set; }
        public string اسم_الأم { get; set; }
        public Nullable<System.DateTime> تاريخ_الولادة { get; set; }
        public string العنوان { get; set; }
        public string الهاتف { get; set; }
        public string البريد { get; set; }
        public string التحصيل_العلمي { get; set; }
        public Nullable<int> الوظيفة { get; set; }
        public string الدوام { get; set; }
        public Nullable<int> فئة_الدم { get; set; }
        public Nullable<bool> مسعف_أو_مساعد { get; set; }
        public Nullable<bool> سائق_أو_لا { get; set; }
        public Nullable<bool> مسؤول_مهمة_أو_لا { get; set; }
        public int المركز { get; set; }
        public string اللقب { get; set; }
        public Nullable<System.DateTime> تاريخ_الانتساب { get; set; }
        public Nullable<int> رمز_المنطقة { get; set; }
    
        public virtual المراكز المراكز { get; set; }
        public virtual المناطق المناطق { get; set; }
        public virtual الوظيفة الوظيفة1 { get; set; }
        public virtual فئة_الدم فئة_الدم1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<الفريق> الفريق { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_المنفذة> المهمات_المنفذة { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_المنفذة> المهمات_المنفذة1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_المنفذة> المهمات_المنفذة2 { get; set; }
    }
}
