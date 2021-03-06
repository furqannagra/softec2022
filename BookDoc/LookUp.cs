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
    
    public partial class LookUp
    {
        public long Id { get; set; }
        public Nullable<long> PatientId { get; set; }
        public Nullable<long> DoctorId { get; set; }
        public Nullable<long> AppiontNum { get; set; }
        public Nullable<long> WaitingId { get; set; }
        public Nullable<long> CalenderId { get; set; }
        public Nullable<long> SignIn { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual Calender Calender { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual WaitingList WaitingList { get; set; }
    }
}
