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
    public partial class karyawan : Form
    {
        string cs = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
      
        public karyawan()
        {
            InitializeComponent();
        }

        private void karyawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokorotiDataSet6.pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.tokorotiDataSet6.pegawai);
            // TODO: This line of code loads data into the 'tokorotiDataSet1.pegawai' table. You can move, or remove it, as needed.
            //this.pegawaiTableAdapter.Fill(this.tokorotiDataSet1.pegawai);
            // TODO: This line of code loads data into the 'tokorotiDataSet.pegawai' table. You can move, or remove it, as needed.
            //this.pegawaiTableAdapter.Fill(this.tokorotiDataSet.pegawai);
            //// TODO: This line of code loads data into the 'tokorotiDataSet.pegawai' table. You can move, or remove it, as needed.
            //this.pegawaiTableAdapter.Fill(this.tokorotiDataSet.pegawai);

            cbjabatan.Text = "-- Pilih Jabatan  --";
           
          
            //con = new SqlConnection(cs);
            //con.Open();
            //adapt = new SqlDataAdapter("select * from pegawai", con);
            //dt = new DataTable();
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void txidkaryawan_TextChanged(object sender, EventArgs e)
        {
            txnamakaryawan.Enabled = true;
        }

        private void txidkaryawan_KeyPress(object sender, KeyPressEventArgs e)
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
                txnamakaryawan.Select();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rblaki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txnamakaryawan_TextChanged(object sender, EventArgs e)
        {
            if (btsavekaryawan.Text.Equals("Save"))
            {
                //untuk memasukkan id barang
                if (txnamakaryawan.Text.Length > 0)
                {
                    string id = txidkaryawan.Text.ToString();
                    string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
                    SqlConnection koneksi = new SqlConnection();
                    koneksi.ConnectionString = strKoneksi;
                    koneksi.Open();

                    string str = "select * from pegawai where idkaryawan=@add";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@add", id));

                    string hasil = "";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read()) { hasil = dr["idkaryawan"].ToString(); }
                    dr.Close();
                    koneksi.Close();
                    //jIKA aLREADY
                    if (hasil.Equals(id))
                    {
                        refreshform();
                        DialogResult dlg = MessageBox.Show("Id sudah ada", "Warning", MessageBoxButtons.OK);
                        if (dlg == DialogResult.OK) { }
                    }

                    //else
                    txalamatkaryawan.Enabled = true;
                    txemailkaryawan.Enabled = true;
                    txnotelpkaryawan.Enabled = true;
                    cbjabatan.Enabled = true;

                }
            }
        }

        private void btsavekaryawan_Click(object sender, EventArgs e)
        {


            string jkelamin = " ";
            if (rblaki.Checked)
            {
                jkelamin = "L";

            }
            else
            {
                jkelamin = "P";
            }

            string str = "";
            string idk = txidkaryawan.Text.ToString();
            string nama = txnamakaryawan.Text.ToString();
            string ps = txpass.Text.ToString();
            string alamat = txalamatkaryawan.Text.ToString();
            string jabatank = "";
            if (cbjabatan.Text == "admin")
            {
                jabatank = "admin";
            }
            else
            {
                jabatank = "karyawan";
            }
            string tgll = dateTimePicker1.Text.ToString();


            string notelpk = txnotelpkaryawan.Text.ToString();
            string emailk = txemailkaryawan.Text.ToString();

            string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            try
            {
                if (btsavekaryawan.Text.Equals("Save")) str = "insert into pegawai values (@Id, @Nk, @al, @ps,  @jbtn, @notelp, @email, @gr,  @tgl)";
                if (btsavekaryawan.Text.Equals("Edit")) str = "update pegawai set idkaryawan=@Id, Nama=@Nk, alamat=@al, pass=@ps, jabatan=@jbtn, notelpon=@notelp, email=@email, gender=@gr, tglmasuk=@tgl " +
                        " where idkaryawan=@Id ";

                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("Id", idk));
                cmd.Parameters.Add(new SqlParameter("Nk", nama));
                cmd.Parameters.Add(new SqlParameter("al", alamat));
                cmd.Parameters.Add(new SqlParameter("ps", ps));
                cmd.Parameters.Add(new SqlParameter("jbtn", jabatank));
                cmd.Parameters.Add(new SqlParameter("notelp", notelpk));
                cmd.Parameters.Add(new SqlParameter("email", emailk));
                cmd.Parameters.Add(new SqlParameter("gr", jkelamin));
                cmd.Parameters.Add(new SqlParameter("tgl", tgll));
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                //string hasil = ex.ToString();
                MessageBox.Show(ex.ToString());
                return;
            }
            
        
            this.pegawaiTableAdapter.Fill(this.tokorotiDataSet6.pegawai);
            dataGridView1.Refresh();
            refreshform();
        }

        private void refreshform()
        {
            txidkaryawan.Text = "";
            txnamakaryawan.Text = "";
            txpass.Text = "";
            txalamatkaryawan.Text = "";
            cbjabatan.Text = "-- Pilih Jabatan  --";
            txnotelpkaryawan.Text = " ";
            rblaki.Text = "Pria";
            rbperempuan.Text = "Wanita";
            dateTimePicker1.Text = "";
            txemailkaryawan.Text = "";

     

            txidkaryawan.Enabled = true;
            txnamakaryawan.Enabled = true;
            txpass.Enabled = true;
            txidkaryawan.Select();

            btsavekaryawan.Text = "Save";
            btsavekaryawan.Enabled = true;
            btdeletekaryawan.Enabled = true;
            btclearkaryawan.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strKoneksi = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = koneksi.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from pegawai where Nama = '" + txnamakaryawan.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();

            this.pegawaiTableAdapter.Fill(this.tokorotiDataSet6.pegawai);
            dataGridView1.Refresh();
            refreshform();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbjabatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bthome_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2();
            k.Show();
            this.Hide();
        }

        private void txsearchkaryawan_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from pegawai where Nama like '" + txsearchkaryawan.Text  + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btsearchkaryawan_Click(object sender, EventArgs e)
        {

        }

        private void btclearkaryawan_Click(object sender, EventArgs e)
        {
            txidkaryawan.Text = "";
            txnamakaryawan.Text = "";
            txpass.Text = "";
            txalamatkaryawan.Text = "";
            cbjabatan.Text = "-- Pilih Jabatan  --";
            txnotelpkaryawan.Text = " ";
            rblaki.Text = "Pria";
            rbperempuan.Text = "Wanita";
            dateTimePicker1.Text = "";
            txemailkaryawan.Text = "";

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (btsavekaryawan.Text.Equals("Save")) btsavekaryawan.Text = "Edit";
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string idkaryawan = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string namak = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string pass = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string alamatk = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string jabatan = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            string genderk = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            string notelp = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);

            txidkaryawan.Text = idkaryawan;
            txnamakaryawan.Text = namak;
            txpass.Text = pass;
            txalamatkaryawan.Text = alamatk;
            cbjabatan.Text = jabatan;
            txnotelpkaryawan.Text = notelp;
            txemailkaryawan.Text = email;

            txidkaryawan.Enabled = false;
            txnamakaryawan.Enabled = true;
            txalamatkaryawan.Enabled = true;
            cbjabatan.Enabled = true;
            btsavekaryawan.Text = "Edit";
            btsavekaryawan.Enabled = true;
        }

        private void txpass_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

