using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
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

            //var xa = mc.AppoitmentDate.ToString("t");
            var result = from p in mc.Patients
                         join a in mc.Appoitments
                         on p.PatientId equals a.PatientId
                         orderby a.AppoitmentDate
                         select new

                         {
                             //RandevuSaati=a.AppoitmentDate.ToString("HH:mm"),  ##### ToString metodu hata veriyor. Burada kullanamıyoruz. Nasıl kullanılacağını araştır.
                             RandevuSaati = a.AppoitmentDate,
                             //RandevuSaati1 = a.AppoitmentDate.ToShortTimeString(),
                             HastaAdi = p.Ad,
                             HastaSoyadi = p.Soyad,
                             TelefonNumarası = p.PatientMobilePhone,
                             Detay = a.AppoitmentDetails // Details'i nvarchar(max) yerine text yapacağım
                         };
            metroGrid1.DataSource = result.ToList();


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            #region Takvimde seçili gün/ay/yıl de var olan randevuları gösterme
            MyContext mc = new MyContext();
            var list = mc.Appoitments.ToList();

            var axx = monthCalendar1.SelectionRange.Start.Year;

            var result = from p in mc.Patients
                         join a in mc.Appoitments
                         on p.PatientId equals a.PatientId
                         where a.AppoitmentDate.Year == monthCalendar1.SelectionRange.Start.Year && a.AppoitmentDate.Month == monthCalendar1.SelectionRange.Start.Month && a.AppoitmentDate.Day == monthCalendar1.SelectionRange.Start.Day
                         orderby a.AppoitmentDate
                         select new
                         {
                             RandevuSaati = a.AppoitmentDate,
                             HastaAdi = p.Ad,
                             HastaSoyadi = p.Soyad,
                             TelefonNumarası = p.PatientMobilePhone,
                             Detay = a.AppoitmentDetails
                         };
            metroGrid2.DataSource = result.ToList(); 

            /////////// Randevu Ver ekranı yüklendiğinde datagrid gelmiyor, randevu olmayan tarih seçildiğinde boş grid geliyor. Önce Load ekranında datagrid'i dolduracağım.
            #endregion
        }

        private void btnRandevuVer_Click(object sender, EventArgs e)
        {
            //*********** YAPILACAKLAR ***********//
            // 1- Randevu ver butonuna tıklandığında en altta o güne ait 09:00 - 20:00 arasında yarım saatlik aralıklarla toplamda 23 tane buton olacak. Bu butonların içlerinde saatler yazıcak. Eğer bu butonların gün/ay/yıl- saatinde randevu varsa o butonlar tıklanamaz ve kırmızı arka planlı olacak. Eğer boş ise boş yazıcak ve tıklanabilir olacak. Eğer boş ise ve butona tıklanırsa bi form açılacak ve o formda seçilen gün/ay/yıl ve saate ait bilgiler labelda gösterilip "belirtilen tarihe randevu oluşturmak için hasta seçiniz yazısı gelicek" altında bir textbox olacak, textboxta arama yapıldığı anda altındaki datagridde hastalar listelenecek. form load olduğunda ise full dolu olarak datagrid gelecek. textboxta arama yapılıp hasta bulunduğunda, tek tık ve çift tık eventları çalışacak ve mbox açılacak. mboxda soru soracak " seçilen .... isimli hastaya .... tarihinde randevu oluşturmak istediğinize emin misiniz diyecek. Eğer evet seçilirse belirtilen tarihte belirtilen kişiye randevu oluşturulabilecek. Burada bir hastanın birden fazla appoitment id'si olabiliyor mu onu kontrol edeceğim. Eğer olmuyorsa databaseden onu düzelteceğim. Sanıyorum ki olabilir.
        }
    }
}
