using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Models
{
    public class BloodType
    {
        public int BloodTypeId { get; set; }
        public string BloodTypeName { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}
