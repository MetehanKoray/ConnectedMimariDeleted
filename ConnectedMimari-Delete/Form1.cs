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
            SqlConnection con = new SqlConnection(@"Server=METEHANKORAY\SQLEXPRESS; Initial Catalog=BankaDB; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Delete From Hesaplar where Id='"+id+"'");
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
            Listele();

        }
        int id;
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            SqlConnection con = new SqlConnection(@"Server=METEHANKORAY\SQLEXPRESS; Initial Catalog=BankaDB; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("Select * From Hesaplar", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
        }
    }
}
