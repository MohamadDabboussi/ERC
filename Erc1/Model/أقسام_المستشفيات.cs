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
    
    public partial class أقسام_المستشفيات
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public أقسام_المستشفيات()
        {
            this.المستشفيات_مع_اقسام = new HashSet<المستشفيات_مع_اقسام>();
        }
    
        public int الرمز { get; set; }
        public string اسم_القسم { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<المستشفيات_مع_اقسام> المستشفيات_مع_اقسام { get; set; }
    }
}
