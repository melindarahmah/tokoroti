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

namespace tugasAkhirPABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txpass.PasswordChar = '•';
           

        }
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string jabatan = "";   
            string constring = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            SqlConnection connection;
            SqlCommand com;
            string sql = "Select jabatan from pegawai Where Nama = '" + txnama.Text.Trim() + "' and pass = '" + txpass.Text.Trim() + "'";
            connection = new SqlConnection(constring);
            com = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                jabatan = r.GetString(0);
            }
            connection.Close();
        

            if(jabatan != null)
            {

                pesanan ps = new pesanan();
                ps.Jabatan = jabatan;
                ps.Cek1 = jabatan;
                Form2 isi = new Form2();
                isi.Cek1 = jabatan;
                this.Hide();
                isi.Show();

            }
            else if (txnama.Text == "" || txpass.Text == "")
            {
                MessageBox.Show("kolom tidak boleh kosong");
            }
            else
            {
                MessageBox.Show("Nama/Password anda salah");
            }


            
        }

        private void txpass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void txnama_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void labelnama()
        {


        
        }

        private void txpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
