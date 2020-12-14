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
    public partial class productdetails : Form
    {
        string cs = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public productdetails()
        {
            InitializeComponent();
        }

        private void productdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokorotiDataSet2.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.tokorotiDataSet2.menu);
            cbjenisproduk.Text = "--Pilih Jenis--";

        }

        private void btsaveproduk_Click(object sender, EventArgs e)
        {

            string str = "";
            string id = txprodukid.Text.ToString();
            string nm = txnamaproduk.Text.ToString();
            

            string jenis = " ";
            if (cbjenisproduk.Text == "Kue Basah")
            {
                jenis = "Kue Basah";
            }
            else if (cbjenisproduk.Text == "Kue Kering")
            {
                jenis = "Kue Kering";
            }
            else if (cbjenisproduk.Text == "Cake")
            {
                jenis = "Cake";
            }
            else if(cbjenisproduk.Text == "Minuman")
            {
                jenis = "Minuman";
            }

            string hg = txhargaproduk.Text.ToString();

            string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            try
            { 
            if (btsaveproduk.Text.Equals("Save")) str = "insert into menu values (@id, @nm, @js, @hg)";
            if (btsaveproduk.Text.Equals("Edit")) str = "update menu set idmenu=@id, Namamenu=@nm, jenismenu=@js, harga=@hg " +
                    " where idmenu=@id ";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.Parameters.Add(new SqlParameter("nm", nm));
            cmd.Parameters.Add(new SqlParameter("js", jenis));
            cmd.Parameters.Add(new SqlParameter("hg", hg));

            cmd.ExecuteNonQuery();
            koneksi.Close();
              }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.menuTableAdapter.Fill(this.tokorotiDataSet2.menu);
            dataGridproduk.Refresh();
            refreshform();

        }

        private void uploadproduk_Click(object sender, EventArgs e)
        {
            String imagelocation = " ";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    gambarproduk.ImageLocation = imagelocation;


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "eror mel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void txprodukid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txprodukid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
              false : true;
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("hanya bisa menginput angka");
            }

            if (e.KeyChar == 13)
            {
                txnamaproduk.Select();
            }
        }

        private void dataGridproduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btsaveproduk.Text.Equals("Save")) btsaveproduk.Text = "Edit";
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string idproduk = Convert.ToString(dataGridproduk.Rows[e.RowIndex].Cells[0].Value);
            string namaproduk = Convert.ToString(dataGridproduk.Rows[e.RowIndex].Cells[1].Value);
            string jenis = Convert.ToString(dataGridproduk.Rows[e.RowIndex].Cells[2].Value);
            string harga = Convert.ToString(dataGridproduk.Rows[e.RowIndex].Cells[3].Value);

            txprodukid.Text = idproduk;
            txnamaproduk.Text = namaproduk;
            cbjenisproduk.Text = jenis;
            txhargaproduk.Text = harga;

            txprodukid.Enabled = false;
            txnamaproduk.Enabled = true;
            cbjenisproduk.Enabled = true;
            txhargaproduk.Enabled = true;
            btsaveproduk.Text = "Edit";
            btsaveproduk.Enabled = true;
        }

        private void txnamaproduk_TextChanged(object sender, EventArgs e)
        {

            if (btsaveproduk.Text.Equals("Save"))
            {
                //untuk memasukkan id barang
                if (txnamaproduk.Text.Length > 0)
                {
                    string id = txprodukid.Text.ToString();
                    string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
                    SqlConnection koneksi = new SqlConnection();
                    koneksi.ConnectionString = strKoneksi;
                    koneksi.Open();

                    string str = "select * from menu where idmenu=@add";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@add", id));

                    string hasil = "";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read()) { hasil = dr["idmenu"].ToString(); }
                    dr.Close();
                    koneksi.Close();
                    //jIKA aLREADY
                    if (hasil.Equals(id))
                    {
                        refreshform();
                        DialogResult dlg = MessageBox.Show("Menu dengan ID in Sudah ada", "Warning", MessageBoxButtons.OK);
                        if (dlg == DialogResult.OK) { }
                    }

                    //else
                    txnamaproduk.Enabled = true;
                    cbjenisproduk.Enabled = true;
                    txhargaproduk.Enabled = true;
                    
                    

                }

            }
        }
        private void refreshform()
        {
            txprodukid.Text = "";
            txnamaproduk.Text = "";
            cbjenisproduk.Text = "--Pilih Jenis--";
            txhargaproduk.Text = "";

            txprodukid.Enabled = true;
            txnamaproduk.Enabled = true;
            cbjenisproduk.Enabled = true;
            txhargaproduk.Enabled = true;
            txprodukid.Select();

            btsaveproduk.Text = "Save";
            btsaveproduk.Enabled = true;
            btdeleteproduk.Enabled = true;
            btclearproduk.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from menu where idmenu like '" + txsearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridproduk.DataSource = dt;
            con.Close();
        }

        private void btdeleteproduk_Click(object sender, EventArgs e)
        {
            string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = koneksi.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from menu where idmenu = '" + txprodukid.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();

            this.menuTableAdapter.Fill(this.tokorotiDataSet2.menu);
            dataGridproduk.Refresh();
            refreshform();
        }

        private void btclearproduk_Click(object sender, EventArgs e)
        {
            txprodukid.Text = "";
            txnamaproduk.Text = "";
            cbjenisproduk.Text = "--Pilih Jenis--";
            txhargaproduk.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txhargaproduk_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

