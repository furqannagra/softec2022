//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookDoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.LookUps = new HashSet<LookUp>();
        }
    
        public long id { get; set; }
        public string Name { get; set; }
        public Nullable<long> Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    
        public virtual ICollection<LookUp> LookUps { get; set; }
    }
}
