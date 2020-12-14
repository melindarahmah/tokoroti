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


namespace tugasAkhirPABD
{
    public partial class placeorder : Form
    {
        
      
        static int qty = 1000, harga = 1000;
    
        public placeorder()
        {
            InitializeComponent();
            
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void placeorder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokorotiDataSet5.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter1.Fill(this.tokorotiDataSet5.menu);
            // TODO: This line of code loads data into the 'tokorotiDataSet2.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.tokorotiDataSet2.menu);
            // TODO: This line of code loads data into the 'tokorotiDataSet4.pesanan' table. You can move, or remove it, as needed.
            this.pesananTableAdapter.Fill(this.tokorotiDataSet4.pesanan);
            // TODO: This line of code loads data into the 'tokorotiDataSet3.pesanan' table. You can move, or remove it, as needed.
            //this.pesananTableAdapter.Fill(this.tokorotiDataSet3.pesanan);
    
           
     

        }

        private void btadd_Click(object sender, EventArgs e)
        {
          
            string str = "";
            string bill = txbill.Text.ToString();
            string menu = txnamamenu.Text.ToString();
            string hg = txharga.Text.ToString();
            string qty = txqty.Text.ToString();
            string total = txtotalharga.Text.ToString();
            string idmenu = txpilihmenu.Text.ToString();
            string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            try
            {
                if (btadd.Text.Equals("Save")) str = "insert into pesanan values (@bill, @menu, @hg, @qty, @ttl, @idmenu)";
               
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("bill", bill));
                cmd.Parameters.Add(new SqlParameter("idmenu", idmenu));
                cmd.Parameters.Add(new SqlParameter("hg", hg));
                cmd.Parameters.Add(new SqlParameter("qty", qty));
                cmd.Parameters.Add(new SqlParameter("ttl", total));
                cmd.Parameters.Add(new SqlParameter("menu", menu));

                cmd.ExecuteNonQuery();
                
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.pesananTableAdapter.Fill(this.tokorotiDataSet4.pesanan);
          
            dataGridpesanan.Refresh();
            refreshform();
          
        }
        private void refreshform()
        {
            txbill.Text = "";
            txpilihmenu.Text = "";
            txnamamenu.Text = " ";
            txharga.Text = "";
            txqty.Text = "";
            txtotalharga.Text = "";

            
        }

        private void txpilihmenu_TextChanged(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            SqlConnection connection;
            SqlCommand com;
            string sql = "select Namamenu,[harga] from menu WHERE idmenu = '" + txpilihmenu.Text + "'";
            connection = new SqlConnection(constring);
            com = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                txnamamenu.Text = r.GetString(0);
                txharga.Text = r.GetString(1);
                
            
            }
            connection.Close();
        }

        private void txtotalharga_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txqty_TextChanged(object sender, EventArgs e)
        {
            
            if (Int32.TryParse(txqty.Text, out qty) && Int32.TryParse(txharga.Text, out harga))
            {
                txtotalharga.Text =(qty * harga).ToString();

            }
           
            

        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            //string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            //SqlConnection koneksi = new SqlConnection();
            //koneksi.ConnectionString = strKoneksi;
            //koneksi.Open();

            //SqlCommand cmd = koneksi.CreateCommand();

            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "delete from pesanan where nobill = '" + txbill.Text + "'";
            //cmd.ExecuteNonQuery();
            //koneksi.Close();

            //this.pesananTableAdapter.Fill(this.tokorotiDataSet4.pesanan);
            //dataGridpesanan.Refresh();
            //refreshform();
        }

        private void btclearpesanan_Click(object sender, EventArgs e)
        {
            txbill.Text = "";
            txpilihmenu.Text = "";
            txharga.Text = "";
            txqty.Text = "";
            txtotalharga.Text = "";

        }

        private void txnamamenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridpesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridpesanan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txbill.Text = dataGridpesanan.SelectedRows[0].Cells[0].Value.ToString();
            txnamamenu.Text = dataGridpesanan.SelectedRows[0].Cells[1].Value.ToString();
            txharga.Text = dataGridpesanan.SelectedRows[0].Cells[2].Value.ToString();
            txqty.Text = dataGridpesanan.SelectedRows[0].Cells[3].Value.ToString();
            txtotalharga.Text = dataGridpesanan.SelectedRows[0].Cells[4].Value.ToString();
            txpilihmenu.Text = dataGridpesanan.SelectedRows[0].Cells[5].Value.ToString();
            txbill.Enabled = false;
            txpilihmenu.Enabled = false;
        }

        private void btbackplaceorder_Click(object sender, EventArgs e)
        {


            Form2 d = new Form2();
            d.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap obm = new Bitmap(this.dataGridpesanan.Width, this.dataGridpesanan.Height);
            dataGridpesanan.DrawToBitmap(obm, new Rectangle(3,3,this.dataGridpesanan.Width, this.dataGridpesanan.Height));
            e.Graphics.DrawImage(obm, 200, 150);

            
        }

        private void btprint_Click(object sender, EventArgs e)
        {
            Nota n = new Nota(txbill.Text);
        
            n.Show();
            this.Hide();
            
        }

        private void txbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
