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
using System.Data.SqlClient;
using System.Configuration;
using DentistApp.Context;

namespace DentistApp
{
    public partial class MaliDurum : MetroForm
    {
        public MaliDurum()
        {
            InitializeComponent();
        }

        void GetList(string param)
        {
            #region İptal Edilen Yöntem
            //mlvHastalarMaliDurum.Items.Clear();

            //string mainconn = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //sqlconn.Open();
            //SqlCommand sqlcomm = new SqlCommand();
            //var people = "";


            //*********** YAPILACAKLAR ***********//
            // 1- Listviewda sadece isim çıkıyor, aradığım özelliklerin tamamı gözükmüyor o düzeltilecek.
            // 2- Sorgu daha düzgün bir şekilde yazılacak
            // 3- Contains metodu içeren sorgu yazılacak. Şu an sadece Ad sütunundaki değerin 1e1 eşleşmesi ile gösteriyor


            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-RPPH3THU\\SQLEXPRESS;Initial Catalog=DentixtDb;Integrated Security=True");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("Select Ad,Soyad,PatientMobilePhone from Patients where Ad=@name", con);
            //cmd.Parameters.AddWithValue("@name",mtxtHastaAdiAra.Text);

            //SqlDataReader da = cmd.ExecuteReader();
            //while(da.Read())
            //{
            //    ListViewItem lvi = new ListViewItem();

            //    lvi.Text = da.GetValue(0).ToString();
            //    lvi.SubItems.Add(da.GetValue(1).ToString());
            //    lvi.SubItems.Add(da.GetValue(2).ToString());

            //    mlvHastalarMaliDurum.Items.Add(lvi);
            //} 
            #endregion

            mlvHastalarMaliDurum.Items.Clear();
            MyContext mc = new MyContext();
            var people = mc.Patients.Where(x => x.Ad.Contains(param)).ToList();
            foreach (var patient in people)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = patient.Ad;
                lvi.SubItems.Add(patient.Soyad);
                lvi.SubItems.Add(patient.PatientMobilePhone);
                lvi.Tag = patient.PatientId;
                mlvHastalarMaliDurum.Items.Add(lvi);
            }
            var a = people.Count;

            int hastasayisi = 0;
            for (int i = 0; i <= a; i++)
            {
                hastasayisi = i;
                mlblToplamHasta.Text = hastasayisi.ToString();
            }


        }
        private void mtxtHastaAdiAra_TextChanged(object sender, EventArgs e)
        {
            GetList(mtxtHastaAdiAra.Text);
        }

        private void MaliDurum_Load(object sender, EventArgs e)
        {
            //*********** YAPILACAKLAR ***********//
            // 1- GetList metodunu burada da kullanacağım.

            MyContext mc = new MyContext();
            var list = mc.Patients.ToList();
            foreach (var patient in list)
            {
                ListViewItem item = new ListViewItem(patient.Ad);
                item.SubItems.Add(patient.Soyad);
                item.SubItems.Add(patient.PatientMobilePhone);
                mlvHastalarMaliDurum.Items.Add(item);

            }

            var a = list.Count;
            //mlblToplamHasta.Text = a.ToString();

            int hastasayisi = 0;
            for (int i = 0; i <= a; i++)
            {
                hastasayisi = i;
                mlblToplamHasta.Text = hastasayisi.ToString();
            }
        }
    }
}
