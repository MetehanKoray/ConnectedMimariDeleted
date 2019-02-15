using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ConnectedMimari_Delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=Serverİsmi; Initial Catalog=VeritabanıAdı; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Delete From TabloAdı where KolonAdı=Koşul...");
            cmd.Connection = con;
            con.Open();
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc>0)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız");
            }
            con.Close();

            //Serverİsmi: VeriTabanımıza bağlandığımız ServerName kısmı yazılacak.
            //Database:Veritabanı İsmi(Hangi veritabanı ile çalışacaksak o veritabanı yazılacak.)
            //Integrated Security=SQL'e WindowsAuthentication ile bağlandıysak bağlantı güvenilir diye belirtmek için yazılacak.
            //Tabloİsmi: Veritabanında hangi tablo ile işlem yapmak istiyorsak o tabloyu Tabloİsmi diye belirttiğim yere yazılacak.
            //Koşul:Silmek İstediğimiz koşulu yazıyoruz.Genellikle ID'ye göre silme işlemi yapılır.
            //ExecuteNonQuery: Ekleme işleminin gerçekleşmesi için yazılacak.


        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
    }
}
