using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string NoteDetails { get; set; }


        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
