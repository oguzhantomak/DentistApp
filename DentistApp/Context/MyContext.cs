using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DentistApp.Models;

namespace DentistApp.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("Connection") // ********** NOT **********   Neden contructor kullandığımı açıklayacağım !
        {

        }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<BloodType> BloodTypes { get; set; }
        //public virtual DbSet<Contact> Contacts { get; set; }
        //public virtual DbSet<TreatmentDate> TreatmentDates { get; set; }
        public virtual DbSet<Debt> Debts { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Appoitment> Appoitments { get; set; }
    }
}
