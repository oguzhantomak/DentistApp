using DentistApp.Context;
using MetroFramework.Controls;
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
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MyContext mc = new MyContext();
            var sonuc = from patient in mc.Patients
                        where patient.PatientId==PatID
                        select patient;


            foreach (var item in sonuc)
            {
                item.Ad = txtAd.Text;
                item.Soyad=txtSoyad.Text;
                item.PatientEmail = txtMail.Text;
                item.TcNo = txtTC.Text;
                item.PatientMobilePhone = txtTelefon.Text;
                item.PatientAddress = txtAdres.Text;
            }

            mc.SaveChanges();
            Temizle();

        }

        public void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is MetroTextBox)
                {
                    MetroTextBox tbox = (MetroTextBox)item;
                    tbox.Clear();
                }
            }
        }
    }
}
