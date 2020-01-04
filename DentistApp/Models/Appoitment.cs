using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Models
{
    public class Appoitment
    {
        public int AppoitmentId { get; set; }
        public DateTime AppoitmentDate { get; set; }
        public DateTime AppoitmentCreationDate { get; set; }
        public bool IsAppoitmentActive { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public string AppoitmentDetails { get; set; } // Details'i nvarchar(max) yerine text yapacağım
    }
}
