//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Erc1.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class المستشفيات_مع_اقسام
    {
        public int رمز_المشفى { get; set; }
        public int رمز_القسم { get; set; }
        public string تحويلة_القسم { get; set; }
        public Nullable<bool> متاح_او_لا { get; set; }
        public string المبلغ_عن_الموضوع { get; set; }
        public Nullable<short> الطابق { get; set; }
    
        public virtual أقسام_المستشفيات أقسام_المستشفيات { get; set; }
        public virtual المستشفيات المستشفيات { get; set; }
    }
}
