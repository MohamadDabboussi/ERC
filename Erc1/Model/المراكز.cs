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
    
    public partial class المراكز
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public المراكز()
        {
            this.الآليات = new HashSet<الآليات>();
            this.العاملون = new HashSet<العاملون>();
        }
    
        public string الرمز { get; set; }
        public Nullable<int> المنطقة { get; set; }
        public Nullable<System.DateTime> تاريخ_التاسيس { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<الآليات> الآليات { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<العاملون> العاملون { get; set; }
        public virtual المناطق المناطق { get; set; }
    }
}
