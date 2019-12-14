using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistApp.Context;
using DentistApp.Models;

namespace DentistApp
{
    public class DentistServices
    {
        private MyContext _context;

        public DentistServices()
        {
            _context = new MyContext();
        }

        public bool Add(Patient patient)
        {
            _context.Patients.Add(patient);
            return _context.SaveChanges() > 0;
        }

        public List<Patient> GetAll() { return _context.Patients.ToList(); }
        

    }
}
