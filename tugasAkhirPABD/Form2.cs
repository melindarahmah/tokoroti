using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasAkhirPABD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
                       
        }
        public string Cek1 { get; set; }
        void cek()
        {
            //untuk mengecek jabatan
            //pesanan ps = new pesanan();
            //string cekae = ps.Cek1;
            //string cekjabatan = ps.Jabatan;
            
            if (Cek1 == "karyawan")
            {
                menuitemdetail.Enabled = false;
                detailProdukToolStripMenuItem.Enabled = false;
                
            }
        }
        
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            menuitemdetail.Enabled = true;

            

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void detailKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            karyawan k = new karyawan();
            k.Show();
            this.Close();
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void detailProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productdetails d = new productdetails();
            d.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            n.Show();
            this.Hide();
        }

        private void btorder_Click(object sender, EventArgs e)
        {
            placeorder p = new placeorder();
            p.Show();
            this.Hide();
        }

        private void lblogin_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokorotiDataSet.pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.tokorotiDataSet.pegawai);
            cek();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
