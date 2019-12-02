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

namespace DentistApp
{
    public partial class YeniHastaKaydi : MetroForm
    {
        public YeniHastaKaydi()
        {
            InitializeComponent();
        }

        private void btnYeniHastaKaydet_Click(object sender, EventArgs e)
        {
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

            else if (mskYeniHastaTcNo.Text.Length != 11)
                tcNoEksikFazlaHata.SetError(mskYeniHastaTcNo, "T.C. Kimlik 11 karakter olmalıdır.");

            else
                bosTcHata.Clear();
            tcNoEksikFazlaHata.Clear();

            #endregion
        }
    }
}
