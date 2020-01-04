using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentistApp.Context;
using MetroFramework;
using MetroFramework.Forms;

namespace DentistApp
{
    public partial class RandevuVer : MetroForm
    {
        public RandevuVer()
        {
            InitializeComponent();
        }

        void GetList(DateTime datetime)
        {

        }
        private void randevuVerTarihSecici_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void RandevuVer_Load(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            MyContext mc = new MyContext();
            var list = mc.Appoitments.ToList();
            ComboBox cmb = new ComboBox();
            foreach (var appoitment in list)
            {
                ListViewItem item = new ListViewItem(appoitment.AppoitmentDate.ToString("HH:mm"));
                //*********** YAPILACAKLAR ***********//
                //load ekranında o güne ait randevular saate göre sıralanacak. Daha sonra DateSelected metodunda seçilen güne ait randevu saatleri boş dolu farketmeksizin sıralanacak.


                item.SubItems.Add(appoitment.AppoitmentDate.ToLongTimeString());
                item.SubItems.Add(appoitment.IsAppoitmentActive.ToString());
                item.SubItems.Add(cmb.Text = appoitment.AppoitmentDate.Hour.ToString());
                metroListView1.Items.Add(item);

                //list.Sort();

            }

            ////////////////////////////////////
            ///

            var result = from p in mc.Patients
                         join a in mc.Appoitments
                         on p.PatientId equals a.PatientId
                         orderby a.AppoitmentDate
                         select new
                         {
                             //RandevuSaati=a.AppoitmentDate.ToString("HH:mm"),  ##### ToString metodu hata veriyor. Burada kullanamıyoruz. Nasıl kullanılacağını araştır.
                             RandevuSaati = a.AppoitmentDate,
                             HastaAdi = p.Ad,
                             HastaSoyadi = p.Soyad,
                             TelefonNumarası = p.PatientMobilePhone,
                             Detay = a.AppoitmentDetails // Details'i nvarchar(max) yerine text yapacağım
                         };
            metroGrid1.DataSource = result.ToList();


        }
    }
}
