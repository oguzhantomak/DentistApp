using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderType { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}
