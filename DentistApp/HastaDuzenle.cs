using DentistApp.Context;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistApp
{
    public partial class HastaDuzenle : MetroForm
    {
        public int PatID { get; set; } // PatId propertysi ile Hastalar formundaki seçilen id verisini buraya aktarıyoruz.
        public HastaDuzenle()
        {
            InitializeComponent();
        }

        private void HastaDuzenle_Load(object sender, EventArgs e)
        {
            metroLabel9.Text = PatID.ToString(); // seçilen datanın id'si burada gözüküyor

            #region Seçilen Hastanın Bilgilerini Gösterme
            MyContext mc = new MyContext();

            var sorgu = mc.Patients.SingleOrDefault(x => x.PatientId == PatID);
            if (sorgu != null)
            {
                txtAd.Text = sorgu.Ad;
                txtSoyad.Text = sorgu.Soyad;
                txtMail.Text = sorgu.PatientEmail;
                txtTC.Text = sorgu.TcNo;
                txtTelefon.Text = sorgu.PatientMobilePhone;
                txtAdres.Text = sorgu.PatientAddress;
                // gender gelecek
                // kan grubu gelecek
            } 
            #endregion





        }
    }
}
