namespace tugasAkhirPABD
{
    partial class placeorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placeorder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbill = new System.Windows.Forms.TextBox();
            this.txpilihmenu = new System.Windows.Forms.TextBox();
            this.txharga = new System.Windows.Forms.TextBox();
            this.txqty = new System.Windows.Forms.TextBox();
            this.txtotalharga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btprint = new System.Windows.Forms.Button();
            this.btclearpesanan = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.dataGridpesanan = new System.Windows.Forms.DataGridView();
            this.nobillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokorotiDataSet4 = new tugasAkhirPABD.tokorotiDataSet4();
            this.pesananTableAdapter = new tugasAkhirPABD.tokorotiDataSet4TableAdapters.pesananTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txnamamenu = new System.Windows.Forms.TextBox();
            this.tokorotiDataSet2 = new tugasAkhirPABD.tokorotiDataSet2();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new tugasAkhirPABD.tokorotiDataSet2TableAdapters.menuTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmenuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamenuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tokorotiDataSet5 = new tugasAkhirPABD.tokorotiDataSet5();
            this.menuTableAdapter1 = new tugasAkhirPABD.tokorotiDataSet5TableAdapters.menuTableAdapter();
            this.btbackplaceorder = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "BillNo.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pilih Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qty";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbill
            // 
            this.txbill.Location = new System.Drawing.Point(232, 36);
            this.txbill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbill.Name = "txbill";
            this.txbill.Size = new System.Drawing.Size(255, 29);
            this.txbill.TabIndex = 7;
            this.txbill.TextChanged += new System.EventHandler(this.txbill_TextChanged);
            // 
            // txpilihmenu
            // 
            this.txpilihmenu.Location = new System.Drawing.Point(232, 85);
            this.txpilihmenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txpilihmenu.Name = "txpilihmenu";
            this.txpilihmenu.Size = new System.Drawing.Size(255, 29);
            this.txpilihmenu.TabIndex = 8;
            this.txpilihmenu.TextChanged += new System.EventHandler(this.txpilihmenu_TextChanged);
            // 
            // txharga
            // 
            this.txharga.Location = new System.Drawing.Point(232, 183);
            this.txharga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txharga.Name = "txharga";
            this.txharga.Size = new System.Drawing.Size(255, 29);
            this.txharga.TabIndex = 9;
            this.txharga.TextChanged += new System.EventHandler(this.txharga_TextChanged);
            // 
            // txqty
            // 
            this.txqty.Location = new System.Drawing.Point(232, 234);
            this.txqty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txqty.Name = "txqty";
            this.txqty.Size = new System.Drawing.Size(255, 29);
            this.txqty.TabIndex = 10;
            this.txqty.TextChanged += new System.EventHandler(this.txqty_TextChanged);
            // 
            // txtotalharga
            // 
            this.txtotalharga.Location = new System.Drawing.Point(232, 283);
            this.txtotalharga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtotalharga.Name = "txtotalharga";
            this.txtotalharga.Size = new System.Drawing.Size(255, 29);
            this.txtotalharga.TabIndex = 11;
            this.txtotalharga.TextChanged += new System.EventHandler(this.txtotalharga_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btprint);
            this.groupBox1.Controls.Add(this.btclearpesanan);
            this.groupBox1.Controls.Add(this.btadd);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(624, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(218, 274);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btprint
            // 
            this.btprint.Location = new System.Drawing.Point(48, 210);
            this.btprint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(94, 41);
            this.btprint.TabIndex = 4;
            this.btprint.Text = "Print";
            this.btprint.UseVisualStyleBackColor = true;
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
            // 
            // btclearpesanan
            // 
            this.btclearpesanan.Location = new System.Drawing.Point(48, 116);
            this.btclearpesanan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btclearpesanan.Name = "btclearpesanan";
            this.btclearpesanan.Size = new System.Drawing.Size(94, 41);
            this.btclearpesanan.TabIndex = 3;
            this.btclearpesanan.Text = "Clear";
            this.btclearpesanan.UseVisualStyleBackColor = true;
            this.btclearpesanan.Click += new System.EventHandler(this.btclearpesanan_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(48, 28);
            this.btadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(94, 46);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "Save";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // dataGridpesanan
            // 
            this.dataGridpesanan.AutoGenerateColumns = false;
            this.dataGridpesanan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridpesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nobillDataGridViewTextBoxColumn,
            this.idmenu,
            this.namamenuDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.totalhargaDataGridViewTextBoxColumn});
            this.dataGridpesanan.DataSource = this.pesananBindingSource;
            this.dataGridpesanan.Location = new System.Drawing.Point(116, 339);
            this.dataGridpesanan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridpesanan.Name = "dataGridpesanan";
            this.dataGridpesanan.RowTemplate.Height = 24;
            this.dataGridpesanan.Size = new System.Drawing.Size(825, 337);
            this.dataGridpesanan.TabIndex = 13;
            this.dataGridpesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpesanan_CellContentClick);
            this.dataGridpesanan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridpesanan_MouseDoubleClick);
            // 
            // nobillDataGridViewTextBoxColumn
            // 
            this.nobillDataGridViewTextBoxColumn.DataPropertyName = "nobill";
            this.nobillDataGridViewTextBoxColumn.HeaderText = "Bill NO";
            this.nobillDataGridViewTextBoxColumn.Name = "nobillDataGridViewTextBoxColumn";
            // 
            // idmenu
            // 
            this.idmenu.DataPropertyName = "idmenu";
            this.idmenu.HeaderText = "Id Menu";
            this.idmenu.Name = "idmenu";
            // 
            // namamenuDataGridViewTextBoxColumn
            // 
            this.namamenuDataGridViewTextBoxColumn.DataPropertyName = "Namamenu";
            this.namamenuDataGridViewTextBoxColumn.HeaderText = "Nama Menu";
            this.namamenuDataGridViewTextBoxColumn.Name = "namamenuDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "totalharga";
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "total harga";
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            // 
            // pesananBindingSource
            // 
            this.pesananBindingSource.DataMember = "pesanan";
            this.pesananBindingSource.DataSource = this.tokorotiDataSet4;
            // 
            // tokorotiDataSet4
            // 
            this.tokorotiDataSet4.DataSetName = "tokorotiDataSet4";
            this.tokorotiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesananTableAdapter
            // 
            this.pesananTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nama Menu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txnamamenu
            // 
            this.txnamamenu.Location = new System.Drawing.Point(232, 132);
            this.txnamamenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txnamamenu.Name = "txnamamenu";
            this.txnamamenu.Size = new System.Drawing.Size(255, 29);
            this.txnamamenu.TabIndex = 15;
            this.txnamamenu.TextChanged += new System.EventHandler(this.txnamamenu_TextChanged);
            // 
            // tokorotiDataSet2
            // 
            this.tokorotiDataSet2.DataSetName = "tokorotiDataSet2";
            this.tokorotiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.tokorotiDataSet2;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmenuDataGridViewTextBoxColumn1,
            this.namamenuDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.menuBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Pink;
            this.dataGridView1.Location = new System.Drawing.Point(980, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(196, 579);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idmenuDataGridViewTextBoxColumn1
            // 
            this.idmenuDataGridViewTextBoxColumn1.DataPropertyName = "idmenu";
            this.idmenuDataGridViewTextBoxColumn1.HeaderText = "Id Menu";
            this.idmenuDataGridViewTextBoxColumn1.Name = "idmenuDataGridViewTextBoxColumn1";
            // 
            // namamenuDataGridViewTextBoxColumn1
            // 
            this.namamenuDataGridViewTextBoxColumn1.DataPropertyName = "Namamenu";
            this.namamenuDataGridViewTextBoxColumn1.HeaderText = "Nama Menu";
            this.namamenuDataGridViewTextBoxColumn1.Name = "namamenuDataGridViewTextBoxColumn1";
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "menu";
            this.menuBindingSource1.DataSource = this.tokorotiDataSet5;
            // 
            // tokorotiDataSet5
            // 
            this.tokorotiDataSet5.DataSetName = "tokorotiDataSet5";
            this.tokorotiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // btbackplaceorder
            // 
            this.btbackplaceorder.BackColor = System.Drawing.Color.Transparent;
            this.btbackplaceorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbackplaceorder.BackgroundImage")));
            this.btbackplaceorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbackplaceorder.Location = new System.Drawing.Point(1165, 1);
            this.btbackplaceorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btbackplaceorder.Name = "btbackplaceorder";
            this.btbackplaceorder.Size = new System.Drawing.Size(51, 40);
            this.btbackplaceorder.TabIndex = 17;
            this.btbackplaceorder.UseVisualStyleBackColor = false;
            this.btbackplaceorder.Click += new System.EventHandler(this.btbackplaceorder_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Minion Pro SmBd", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(1004, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "DAFTAR MENU";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // placeorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 734);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btbackplaceorder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txnamamenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridpesanan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtotalharga);
            this.Controls.Add(this.txqty);
            this.Controls.Add(this.txharga);
            this.Controls.Add(this.txpilihmenu);
            this.Controls.Add(this.txbill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Adobe Hebrew", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "placeorder";
            this.Text = "placeorder";
            this.Load += new System.EventHandler(this.placeorder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbill;
        private System.Windows.Forms.TextBox txpilihmenu;
        private System.Windows.Forms.TextBox txharga;
        private System.Windows.Forms.TextBox txqty;
        private System.Windows.Forms.TextBox txtotalharga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btclearpesanan;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.DataGridView dataGridpesanan;
        private tokorotiDataSet4 tokorotiDataSet4;
        private System.Windows.Forms.BindingSource pesananBindingSource;
        private tokorotiDataSet4TableAdapters.pesananTableAdapter pesananTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txnamamenu;
        private tokorotiDataSet2 tokorotiDataSet2;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private tokorotiDataSet2TableAdapters.menuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tokorotiDataSet5 tokorotiDataSet5;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private tokorotiDataSet5TableAdapters.menuTableAdapter menuTableAdapter1;
        private System.Windows.Forms.Button btbackplaceorder;
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn nobillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmenuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamenuDataGridViewTextBoxColumn1;
    }
}