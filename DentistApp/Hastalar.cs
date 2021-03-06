﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Hastalar : MetroForm
    {
        public Hastalar()
        {
            InitializeComponent();
        }

        #region İptal Edilen Yöntem
        //static string conString = "Server=LAPTOP-RPPH3THU\\SQLEXPRESS;Database=DentixtDb;UID=sa;PWD=123";
        ////Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        ////Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        //SqlConnection baglanti = new SqlConnection(conString);
        ////bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz. 
        #endregion
        private void Hastalar_Load(object sender, EventArgs e)
        {
            #region İptal Edilen Yöntem
            ////*********** YAPILACAKLAR ***********//
            ////Altta yer alan işlemler global bir alanda metoda alınacak

            //baglanti.Open();
            //string kayit = "SELECT Ad,Soyad,PatientMobilePhone from Patients";
            ////musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.


            ////*********** YAPILACAKLAR ***********//
            //// Select kaydı düzenlenicek. Sadece çekmek istediğim hasta bilgilerini getireceğim. Gelen tablolaların isim bilgilerini düzelteceğim. Örnek Hasta Adı şeklinde tablo ismi olacak.



            //SqlCommand komut = new SqlCommand(kayit, baglanti);
            ////Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            ////SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            ////Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            //hastalarGrid.DataSource = dt;
            ////Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            //baglanti.Close(); 
            #endregion

            MyContext mc = new MyContext();
            var result = from p in mc.Patients
                         select new
                         {
                             ID = p.PatientId,
                             Ad = p.Ad,
                             Soyad = p.Soyad,
                             Cinsiyet = p.Gender,
                             Telefon = p.PatientMobilePhone,
                             Mail = p.PatientEmail,
                             TC = p.TcNo,
                             Tedaviler = p.Treatments,
                             KanGrubu = p.BloodType,
                             Adres = p.PatientAddress
                         };
            var a = result.ToList();

            hastalarGrid.DataSource = result.ToList();
            int hastasayisi = 0;
            hastalarGrid.Columns["ID"].Visible = false;
            for (int i = 0; i <= a.Count; i++)
            {
                hastasayisi = i;
                mlblToplamHasta.Text = hastasayisi.ToString();
            }

            // Load metodunu getlist metoduna uyarlayacağım.
        }

        MyContext mc = new MyContext();
        void GetList(string param)
        {
            MyContext mc = new MyContext();
            var result = from p in mc.Patients
                         .Where(x => x.Ad.Contains(param))
                         select new
                         {
                             ID=p.PatientId,
                             Ad = p.Ad,
                             Soyad = p.Soyad,
                             Cinsiyet = p.Gender,
                             Telefon = p.PatientMobilePhone,
                             Mail = p.PatientEmail,
                             TC = p.TcNo,
                             Tedaviler = p.Treatments,
                             KanGrubu = p.BloodType,
                             Adres = p.PatientAddress,

                         };
            
            var a = result.ToList();
            hastalarGrid.DataSource = result.ToList();
            int hastasayisi = 0;
            for (int i = 0; i <= a.Count; i++)
            {
                hastasayisi = i;
                mlblToplamHasta.Text = hastasayisi.ToString();
            }
        }

        private void txtHastaAra_TextChanged(object sender, EventArgs e)
        {
            GetList(txtHastaAra.Text);
        }

        
        private void ctxDuzenle_Click(object sender, EventArgs e)
        {
            HastaDuzenle hastaDuzenle = new HastaDuzenle();
            hastaDuzenle.PatID = Convert.ToInt32(hastalarGrid.SelectedRows[0].Cells["ID"].Value);

            hastaDuzenle.ShowDialog();
            // Buraya listeyi yenilemek için bir getlist metodu getirelecek.

        }

        private void ctxSil_Click(object sender, EventArgs e)
        {
            int idx = (int)hastalarGrid.SelectedRows[0].Cells["ID"].Value;

            MyContext mc = new MyContext();
            var person = mc.Patients.SingleOrDefault(x=>x.PatientId==idx);

            mc.Patients.Remove(person);
            mc.SaveChanges();
            // Buraya listeyi yenilemek için bir getlist metodu getirelecek.


        }
    }
}
