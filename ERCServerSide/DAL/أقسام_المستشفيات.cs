//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERCServerSide.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class أقسام_المستشفيات
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public أقسام_المستشفيات()
        {
            this.المستشفيات_مع_اقسام = new HashSet<المستشفيات_مع_اقسام>();
            this.المهمات_الملغاة = new HashSet<المهمات_الملغاة>();
            this.المهمات_الملغاة1 = new HashSet<المهمات_الملغاة>();
            this.المهمات_المنفذة = new HashSet<المهمات_المنفذة>();
            this.المهمات_المنفذة1 = new HashSet<المهمات_المنفذة>();
            this.المهماة_المؤجلة = new HashSet<المهماة_المؤجلة>();
            this.المهماة_المؤجلة1 = new HashSet<المهماة_المؤجلة>();
        }
    
        public int الرمز { get; set; }
        public string اسم_القسم { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المستشفيات_مع_اقسام> المستشفيات_مع_اقسام { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_الملغاة> المهمات_الملغاة { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_الملغاة> المهمات_الملغاة1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_المنفذة> المهمات_المنفذة { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهمات_المنفذة> المهمات_المنفذة1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهماة_المؤجلة> المهماة_المؤجلة { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المهماة_المؤجلة> المهماة_المؤجلة1 { get; set; }
    }
}
