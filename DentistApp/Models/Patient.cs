using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }
        public DateTime CreationDate { get; set; }

        public string PatientMobilePhone { get; set; }
        public string PatientEmail { get; set; }
        public string PatientAddress { get; set; }

        //public int GenderId { get; set; } // Enum olacak
        //public string Notes { get; set; }
        //public int DateId { get; set; }
        //public int TreatmentId { get; set; }
        //public int ContactId { get; set; }
        //public int DebtId { get; set; }

        // #######################          #######################          #######################          #######################          
        public int BloodTypeId { get; set; }
        public virtual BloodType BloodType { get; set; }

        // #######################          #######################          #######################          #######################          
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }

        // #######################          #######################          #######################          #######################          
        //public int NoteId { get; set; }
        //public virtual Note Note { get; set; } GÜNCELLENMİŞ HALİ ALTTAKİDİR. 1-N İLİŞKİ
        public virtual List<Note> Notes { get; set; }

        // #######################          #######################          #######################          #######################          
        public virtual List<Debt> Debts { get; set; }

        // #######################          #######################          #######################          #######################          
        public virtual List<Treatment> Treatments { get; set; }

        // #######################          #######################          #######################          #######################          
        public virtual List<Appoitment> Appoitments { get; set; }

    }
}
