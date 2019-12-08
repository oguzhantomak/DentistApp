using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Models
{
    public class Treatment
    {
        public int TreatmentId { get; set; }
        public string TreatmentName { get; set; }
        public string TreatmentNote { get; set; }
        public DateTime TreatmentStartDate { get; set; }
        public DateTime TreatmentUpdateDate { get; set; }
        public DateTime TreatmentFinishedDate { get; set; }

       
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }


    }
}
