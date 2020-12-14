namespace tugasAkhirPABD
{
    partial class productdetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productdetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uploadproduk = new System.Windows.Forms.Button();
            this.cbjenisproduk = new System.Windows.Forms.ComboBox();
            this.gambarproduk = new System.Windows.Forms.PictureBox();
            this.txhargaproduk = new System.Windows.Forms.TextBox();
            this.txnamaproduk = new System.Windows.Forms.TextBox();
            this.txprodukid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btdeleteproduk = new System.Windows.Forms.Button();
            this.btclearproduk = new System.Windows.Forms.Button();
            this.btsaveproduk = new System.Windows.Forms.Button();
            this.dataGridproduk = new System.Windows.Forms.DataGridView();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokorotiDataSet2 = new tugasAkhirPABD.tokorotiDataSet2();
            this.menuTableAdapter = new tugasAkhirPABD.tokorotiDataSet2TableAdapters.menuTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txsearch = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.idmenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenismenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarproduk)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.uploadproduk);
            this.groupBox1.Controls.Add(this.cbjenisproduk);
            this.groupBox1.Controls.Add(this.gambarproduk);
            this.groupBox1.Controls.Add(this.txhargaproduk);
            this.groupBox1.Controls.Add(this.txnamaproduk);
            this.groupBox1.Controls.Add(this.txprodukid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // uploadproduk
            // 
            this.uploadproduk.Location = new System.Drawing.Point(70, 219);
            this.uploadproduk.Name = "uploadproduk";
            this.uploadproduk.Size = new System.Drawing.Size(75, 23);
            this.uploadproduk.TabIndex = 11;
            this.uploadproduk.Text = "Upload";
            this.uploadproduk.UseVisualStyleBackColor = true;
            this.uploadproduk.Click += new System.EventHandler(this.uploadproduk_Click);
            // 
            // cbjenisproduk
            // 
            this.cbjenisproduk.FormattingEnabled = true;
            this.cbjenisproduk.Items.AddRange(new object[] {
            "Kue Basah",
            "Kue Kering",
            "Cake",
            "Minuman"});
            this.cbjenisproduk.Location = new System.Drawing.Point(322, 132);
            this.cbjenisproduk.Name = "cbjenisproduk";
            this.cbjenisproduk.Size = new System.Drawing.Size(152, 24);
            this.cbjenisproduk.TabIndex = 10;
            // 
            // gambarproduk
            // 
            this.gambarproduk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gambarproduk.Location = new System.Drawing.Point(16, 29);
            this.gambarproduk.Name = "gambarproduk";
            this.gambarproduk.Size = new System.Drawing.Size(175, 181);
            this.gambarproduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gambarproduk.TabIndex = 9;
            this.gambarproduk.TabStop = false;
            // 
            // txhargaproduk
            // 
            this.txhargaproduk.Location = new System.Drawing.Point(322, 177);
            this.txhargaproduk.Name = "txhargaproduk";
            this.txhargaproduk.Size = new System.Drawing.Size(151, 22);
            this.txhargaproduk.TabIndex = 8;
            this.txhargaproduk.TextChanged += new System.EventHandler(this.txhargaproduk_TextChanged);
            // 
            // txnamaproduk
            // 
            this.txnamaproduk.Location = new System.Drawing.Point(322, 81);
            this.txnamaproduk.Name = "txnamaproduk";
            this.txnamaproduk.Size = new System.Drawing.Size(152, 22);
            this.txnamaproduk.TabIndex = 6;
            this.txnamaproduk.TextChanged += new System.EventHandler(this.txnamaproduk_TextChanged);
            // 
            // txprodukid
            // 
            this.txprodukid.Location = new System.Drawing.Point(322, 29);
            this.txprodukid.Name = "txprodukid";
            this.txprodukid.Size = new System.Drawing.Size(152, 22);
            this.txprodukid.TabIndex = 5;
            this.txprodukid.TextChanged += new System.EventHandler(this.txprodukid_TextChanged);
            this.txprodukid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txprodukid_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btdeleteproduk);
            this.groupBox2.Controls.Add(this.btclearproduk);
            this.groupBox2.Controls.Add(this.btsaveproduk);
            this.groupBox2.Location = new System.Drawing.Point(635, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btdeleteproduk
            // 
            this.btdeleteproduk.Location = new System.Drawing.Point(59, 98);
            this.btdeleteproduk.Name = "btdeleteproduk";
            this.btdeleteproduk.Size = new System.Drawing.Size(75, 23);
            this.btdeleteproduk.TabIndex = 2;
            this.btdeleteproduk.Text = "Delete";
            this.btdeleteproduk.UseVisualStyleBackColor = true;
            this.btdeleteproduk.Click += new System.EventHandler(this.btdeleteproduk_Click);
            // 
            // btclearproduk
            // 
            this.btclearproduk.Location = new System.Drawing.Point(59, 67);
            this.btclearproduk.Name = "btclearproduk";
            this.btclearproduk.Size = new System.Drawing.Size(75, 23);
            this.btclearproduk.TabIndex = 1;
            this.btclearproduk.Text = "Clear";
            this.btclearproduk.UseVisualStyleBackColor = true;
            this.btclearproduk.Click += new System.EventHandler(this.btclearproduk_Click);
            // 
            // btsaveproduk
            // 
            this.btsaveproduk.Location = new System.Drawing.Point(59, 33);
            this.btsaveproduk.Name = "btsaveproduk";
            this.btsaveproduk.Size = new System.Drawing.Size(75, 23);
            this.btsaveproduk.TabIndex = 0;
            this.btsaveproduk.Text = "Save";
            this.btsaveproduk.UseVisualStyleBackColor = true;
            this.btsaveproduk.Click += new System.EventHandler(this.btsaveproduk_Click);
            // 
            // dataGridproduk
            // 
            this.dataGridproduk.AutoGenerateColumns = false;
            this.dataGridproduk.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproduk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmenuDataGridViewTextBoxColumn,
            this.namamenuDataGridViewTextBoxColumn,
            this.jenismenuDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridproduk.DataSource = this.menuBindingSource;
            this.dataGridproduk.Location = new System.Drawing.Point(83, 323);
            this.dataGridproduk.Name = "dataGridproduk";
            this.dataGridproduk.RowTemplate.Height = 24;
            this.dataGridproduk.Size = new System.Drawing.Size(738, 187);
            this.dataGridproduk.TabIndex = 2;
            this.dataGridproduk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridproduk_CellContentClick);
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.tokorotiDataSet2;
            // 
            // tokorotiDataSet2
            // 
            this.tokorotiDataSet2.DataSetName = "tokorotiDataSet2";
            this.tokorotiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txsearch);
            this.groupBox3.Location = new System.Drawing.Point(635, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search by Id";
            // 
            // txsearch
            // 
            this.txsearch.Location = new System.Drawing.Point(36, 34);
            this.txsearch.Name = "txsearch";
            this.txsearch.Size = new System.Drawing.Size(150, 22);
            this.txsearch.TabIndex = 0;
            this.txsearch.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(880, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 37);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // idmenuDataGridViewTextBoxColumn
            // 
            this.idmenuDataGridViewTextBoxColumn.DataPropertyName = "idmenu";
            this.idmenuDataGridViewTextBoxColumn.HeaderText = "ID Menu";
            this.idmenuDataGridViewTextBoxColumn.Name = "idmenuDataGridViewTextBoxColumn";
            // 
            // namamenuDataGridViewTextBoxColumn
            // 
            this.namamenuDataGridViewTextBoxColumn.DataPropertyName = "Namamenu";
            this.namamenuDataGridViewTextBoxColumn.HeaderText = "Nama Menu";
            this.namamenuDataGridViewTextBoxColumn.Name = "namamenuDataGridViewTextBoxColumn";
            // 
            // jenismenuDataGridViewTextBoxColumn
            // 
            this.jenismenuDataGridViewTextBoxColumn.DataPropertyName = "jenismenu";
            this.jenismenuDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenismenuDataGridViewTextBoxColumn.Name = "jenismenuDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // productdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 522);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridproduk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "productdetails";
            this.Text = "productdetails";
            this.Load += new System.EventHandler(this.productdetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarproduk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox gambarproduk;
        private System.Windows.Forms.TextBox txhargaproduk;
        private System.Windows.Forms.TextBox txnamaproduk;
        private System.Windows.Forms.TextBox txprodukid;
        private System.Windows.Forms.DataGridView dataGridproduk;
        private tokorotiDataSet2 tokorotiDataSet2;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private tokorotiDataSet2TableAdapters.menuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Button btdeleteproduk;
        private System.Windows.Forms.Button btclearproduk;
        private System.Windows.Forms.Button btsaveproduk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txsearch;
        private System.Windows.Forms.ComboBox cbjenisproduk;
        private System.Windows.Forms.Button uploadproduk;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenismenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}