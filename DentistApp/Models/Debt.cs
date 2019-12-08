using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Models
{
    public class Debt
    {
        public int DebtId { get; set; }
        public double DebtAmount { get; set; }
        public double DebtPaid { get; set; }
        public double DebtRemaining { get; set; }
        public double DebtNote { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
