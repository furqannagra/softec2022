﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookDocEntities : DbContext
    {
        public BookDocEntities()
            : base("name=BookDocEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Calender> Calenders { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<SignIn> SignIns { get; set; }
        public DbSet<WaitingList> WaitingLists { get; set; }
    }
}
