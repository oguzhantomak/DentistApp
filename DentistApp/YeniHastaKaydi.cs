using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using DentistApp.Models;

namespace DentistApp
{
    public partial class YeniHastaKaydi : MetroForm
    {
        public YeniHastaKaydi()
        {
            InitializeComponent();
        }

        DentistServices ds = new DentistServices();
        private void btnYeniHastaKaydet_Click(object sender, EventArgs e)
        {
            /*   #region Hata Kontrolü
               bosTcHata.Clear();
               tcNoEksikFazlaHata.Clear();
               bosAdHata.Clear();
               bosSoyadHata.Clear();

               if (txtYeniHastaAd.Text == "")
               {
                   bosAdHata.SetError(txtYeniHastaAd, "Ad boş bırakılamaz !");
               }

               if (txtYeniHastaSoyad.Text == "")
               {
                   bosSoyadHata.SetError(txtYeniHastaSoyad, "Soyad boş bırakılamaz !");
               }

               #region T.C. Kimlik No Kontrolü

               if (mskYeniHastaTcNo.Text == "" || mskYeniHastaTcNo.Text == "___________")
                   bosTcHata.SetError(mskYeniHastaTcNo, "T.C. Kimlik No boş bırakılamaz.");

               else if (mskYeniHastaTcNo.Text.Contains("_") || mskYeniHastaTcNo.Text.Contains("0") || mskYeniHastaTcNo.Text.Contains("-") == true)
                   tcNoEksikFazlaHata.SetError(mskYeniHastaTcNo, "T.C. Kimlik No boş bırakılamaz.");

               //**********************************************                   DÜZELTİLECEK 1                   **********************************************                                                     T.C.'no eksik girildiğinde uyarı kalkabiliyor ve daha önce bir kez verilen hata düzeltilip başka bir hata alınmaya çalışıldığında o hatanın error iconu gösterilmiyor.

               //else if (mskYeniHastaTcNo.Text.Length != 11)
               //    tcNoEksikFazlaHata.SetError(mskYeniHastaTcNo, "T.C. Kimlik 11 karakter olmalıdır.");

               else
                   bosTcHata.Clear();
               tcNoEksikFazlaHata.Clear();

               #endregion 
               #endregion

       */
            //BloodType bt = new BloodType();
            //bt.BloodTypeId = 1;
            //bt.BloodTypeName = mcYeniHastaKanGrubu.Text;

            Patient patient = new Patient();
            patient.Ad = txtYeniHastaAd.Text;
            patient.Soyad = txtYeniHastaSoyad.Text;
            patient.DogumTarihi = dtYeniHastaDogumTarihi.Value;
            patient.PatientMobilePhone = mskYeniHastaTelefon.Text;
            patient.TcNo = mskYeniHastaTcNo.Text;
            patient.PatientEmail = txtYeniHastaEmail.Text;
            //Gender gelecek

            patient.GenderId = 1;
            patient.CreationDate = DateTime.Now;
            patient.BloodTypeId = 1;
            

            //patient.BloodTypeId = 1;
            

            //foreach (Control item in metroPanel1.Controls)
            //{
            //    if (item is RadioButton)
            //    {
            //        RadioButton rd = (RadioButton)item;
            //        if (rd.Checked)
            //        {
            //            patient.Gender.GenderType = rd.Text;
            //        }
            //    }
            //}

            //patient.BloodType.BloodTypeName = (string)mcYeniHastaKanGrubu.SelectedItem;


            // ###########################################################################################
            //patient.BloodType = (BloodType)mcYeniHastaKanGrubu.SelectedItem;
            //patient.Notes = txtYeniHastaKayitNotlar.Text;   // Düzeltilecek

            bool result = ds.Add(patient);
            MetroMessageBox.Show(this, result ? "Kayıt Başarıyla eklendi" : "Kayıt ekleme hatası", "Kayıet ekleme bildirimi", MessageBoxButtons.OK, result ? MessageBoxIcon.Hand : MessageBoxIcon.Error);



        }
    }
}
