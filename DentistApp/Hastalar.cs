using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        static string conString = "Server=LAPTOP-RPPH3THU\\SQLEXPRESS;Database=DentixtDb;UID=sa;PWD=123";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.
        private void Hastalar_Load(object sender, EventArgs e)
        {

            //*********** YAPILACAKLAR ***********//
            //Altta yer alan işlemler global bir alanda metoda alınacak

            baglanti.Open();
            string kayit = "SELECT * from Patients";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.


            //*********** YAPILACAKLAR ***********//
            // Select kaydı düzenlenicek. Sadece çekmek istediğim hasta bilgilerini getireceğim. Gelen tablolaların isim bilgilerini düzelteceğim. Örnek Hasta Adı şeklinde tablo ismi olacak.


            
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            hastalarGrid.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

        void GetList()
        {
            hastalarGrid.DataSource = null;

        }

        private void txtHastaAra_TextChanged(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
