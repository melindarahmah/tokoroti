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
    public partial class Nota : Form
    {
        string sDataPass = string.Empty;
        public Nota()
        {
            InitializeComponent();
        }
  
        public string darinota
        {
           get { return nobilltx.Text; }
          
            
        }
        public Nota(string sPassing)
        {
            InitializeComponent();
            sDataPass = sPassing;
            nobilltx.Text = sPassing;
            menutx.Text = sPassing;
            totaltx.Text = sPassing;
        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menutx_Click(object sender, EventArgs e)
        {

        }

        private void nobilltx_Click(object sender, EventArgs e)
        {

        }

        private void Nota_Load(object sender, EventArgs e)
        {
            jam.Text = DateTime.Now.ToLongTimeString();
            tanggal.Text = DateTime.Now.ToLongDateString();
        }

        private void jam_Click(object sender, EventArgs e)
        {

        }

        private void tanggal_Click(object sender, EventArgs e)
        {

        }

        private void bback_Click(object sender, EventArgs e)
        {
            placeorder p = new placeorder();
            p.Show();
            this.Hide();
        }
    }
}
