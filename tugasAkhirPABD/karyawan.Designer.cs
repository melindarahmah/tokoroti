namespace tugasAkhirPABD
{
    partial class karyawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karyawan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txpass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbjabatan = new System.Windows.Forms.ComboBox();
            this.rbperempuan = new System.Windows.Forms.RadioButton();
            this.rblaki = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txemailkaryawan = new System.Windows.Forms.TextBox();
            this.txnotelpkaryawan = new System.Windows.Forms.TextBox();
            this.txalamatkaryawan = new System.Windows.Forms.TextBox();
            this.txnamakaryawan = new System.Windows.Forms.TextBox();
            this.txidkaryawan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txsearchkaryawan = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btdeletekaryawan = new System.Windows.Forms.Button();
            this.btclearkaryawan = new System.Windows.Forms.Button();
            this.btsavekaryawan = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tokorotiDataSet6 = new tugasAkhirPABD.tokorotiDataSet6();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiTableAdapter = new tugasAkhirPABD.tokorotiDataSet6TableAdapters.pegawaiTableAdapter();
            this.idkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglmasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txpass);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbjabatan);
            this.groupBox1.Controls.Add(this.rbperempuan);
            this.groupBox1.Controls.Add(this.rblaki);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txemailkaryawan);
            this.groupBox1.Controls.Add(this.txnotelpkaryawan);
            this.groupBox1.Controls.Add(this.txalamatkaryawan);
            this.groupBox1.Controls.Add(this.txnamakaryawan);
            this.groupBox1.Controls.Add(this.txidkaryawan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details Karyawan";
            // 
            // txpass
            // 
            this.txpass.Location = new System.Drawing.Point(175, 86);
            this.txpass.Name = "txpass";
            this.txpass.Size = new System.Drawing.Size(258, 22);
            this.txpass.TabIndex = 23;
            this.txpass.TextChanged += new System.EventHandler(this.txpass_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Password";
            // 
            // cbjabatan
            // 
            this.cbjabatan.FormattingEnabled = true;
            this.cbjabatan.Items.AddRange(new object[] {
            "Admin",
            "Karyawan"});
            this.cbjabatan.Location = new System.Drawing.Point(175, 143);
            this.cbjabatan.Name = "cbjabatan";
            this.cbjabatan.Size = new System.Drawing.Size(258, 24);
            this.cbjabatan.TabIndex = 21;
            this.cbjabatan.SelectedIndexChanged += new System.EventHandler(this.cbjabatan_SelectedIndexChanged);
            // 
            // rbperempuan
            // 
            this.rbperempuan.AutoSize = true;
            this.rbperempuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbperempuan.Location = new System.Drawing.Point(281, 246);
            this.rbperempuan.Name = "rbperempuan";
            this.rbperempuan.Size = new System.Drawing.Size(73, 21);
            this.rbperempuan.TabIndex = 20;
            this.rbperempuan.TabStop = true;
            this.rbperempuan.Text = "Wanita";
            this.rbperempuan.UseVisualStyleBackColor = true;
            // 
            // rblaki
            // 
            this.rblaki.AutoSize = true;
            this.rblaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblaki.Location = new System.Drawing.Point(176, 246);
            this.rblaki.Name = "rblaki";
            this.rblaki.Size = new System.Drawing.Size(54, 21);
            this.rblaki.TabIndex = 19;
            this.rblaki.TabStop = true;
            this.rblaki.Text = "Pria";
            this.rblaki.UseVisualStyleBackColor = true;
            this.rblaki.CheckedChanged += new System.EventHandler(this.rblaki_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txemailkaryawan
            // 
            this.txemailkaryawan.Location = new System.Drawing.Point(175, 213);
            this.txemailkaryawan.Name = "txemailkaryawan";
            this.txemailkaryawan.Size = new System.Drawing.Size(258, 22);
            this.txemailkaryawan.TabIndex = 15;
            // 
            // txnotelpkaryawan
            // 
            this.txnotelpkaryawan.Location = new System.Drawing.Point(175, 177);
            this.txnotelpkaryawan.Name = "txnotelpkaryawan";
            this.txnotelpkaryawan.Size = new System.Drawing.Size(258, 22);
            this.txnotelpkaryawan.TabIndex = 14;
            // 
            // txalamatkaryawan
            // 
            this.txalamatkaryawan.Location = new System.Drawing.Point(175, 115);
            this.txalamatkaryawan.Name = "txalamatkaryawan";
            this.txalamatkaryawan.Size = new System.Drawing.Size(258, 22);
            this.txalamatkaryawan.TabIndex = 11;
            // 
            // txnamakaryawan
            // 
            this.txnamakaryawan.Location = new System.Drawing.Point(175, 58);
            this.txnamakaryawan.Name = "txnamakaryawan";
            this.txnamakaryawan.Size = new System.Drawing.Size(258, 22);
            this.txnamakaryawan.TabIndex = 10;
            this.txnamakaryawan.TextChanged += new System.EventHandler(this.txnamakaryawan_TextChanged);
            // 
            // txidkaryawan
            // 
            this.txidkaryawan.Location = new System.Drawing.Point(175, 30);
            this.txidkaryawan.Name = "txidkaryawan";
            this.txidkaryawan.Size = new System.Drawing.Size(258, 22);
            this.txidkaryawan.TabIndex = 9;
            this.txidkaryawan.TextChanged += new System.EventHandler(this.txidkaryawan_TextChanged);
            this.txidkaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txidkaryawan_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tanggal Masuk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "No Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jabatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Karyawan";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txsearchkaryawan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(553, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Nama Karyawan";
            // 
            // txsearchkaryawan
            // 
            this.txsearchkaryawan.Location = new System.Drawing.Point(22, 41);
            this.txsearchkaryawan.Name = "txsearchkaryawan";
            this.txsearchkaryawan.Size = new System.Drawing.Size(238, 22);
            this.txsearchkaryawan.TabIndex = 0;
            this.txsearchkaryawan.TextChanged += new System.EventHandler(this.txsearchkaryawan_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btdeletekaryawan);
            this.groupBox3.Controls.Add(this.btclearkaryawan);
            this.groupBox3.Controls.Add(this.btsavekaryawan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(568, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btdeletekaryawan
            // 
            this.btdeletekaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeletekaryawan.Location = new System.Drawing.Point(104, 90);
            this.btdeletekaryawan.Name = "btdeletekaryawan";
            this.btdeletekaryawan.Size = new System.Drawing.Size(66, 36);
            this.btdeletekaryawan.TabIndex = 2;
            this.btdeletekaryawan.Text = "Delete";
            this.btdeletekaryawan.UseVisualStyleBackColor = true;
            this.btdeletekaryawan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btclearkaryawan
            // 
            this.btclearkaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclearkaryawan.Location = new System.Drawing.Point(104, 49);
            this.btclearkaryawan.Name = "btclearkaryawan";
            this.btclearkaryawan.Size = new System.Drawing.Size(67, 33);
            this.btclearkaryawan.TabIndex = 1;
            this.btclearkaryawan.Text = "Clear";
            this.btclearkaryawan.UseVisualStyleBackColor = true;
            this.btclearkaryawan.Click += new System.EventHandler(this.btclearkaryawan_Click);
            // 
            // btsavekaryawan
            // 
            this.btsavekaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsavekaryawan.Location = new System.Drawing.Point(104, 12);
            this.btsavekaryawan.Name = "btsavekaryawan";
            this.btsavekaryawan.Size = new System.Drawing.Size(67, 32);
            this.btsavekaryawan.TabIndex = 0;
            this.btsavekaryawan.Text = "Save";
            this.btsavekaryawan.UseVisualStyleBackColor = true;
            this.btsavekaryawan.Click += new System.EventHandler(this.btsavekaryawan_Click);
            // 
            // bthome
            // 
            this.bthome.BackColor = System.Drawing.Color.Transparent;
            this.bthome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthome.BackgroundImage")));
            this.bthome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthome.Location = new System.Drawing.Point(12, 12);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(42, 37);
            this.bthome.TabIndex = 3;
            this.bthome.UseVisualStyleBackColor = false;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkaryawanDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn,
            this.notelponDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.tglmasukDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pegawaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(74, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 130);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tokorotiDataSet6
            // 
            this.tokorotiDataSet6.DataSetName = "tokorotiDataSet6";
            this.tokorotiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "pegawai";
            this.pegawaiBindingSource.DataSource = this.tokorotiDataSet6;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // idkaryawanDataGridViewTextBoxColumn
            // 
            this.idkaryawanDataGridViewTextBoxColumn.DataPropertyName = "idkaryawan";
            this.idkaryawanDataGridViewTextBoxColumn.HeaderText = "idkaryawan";
            this.idkaryawanDataGridViewTextBoxColumn.Name = "idkaryawanDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "jabatan";
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            // 
            // notelponDataGridViewTextBoxColumn
            // 
            this.notelponDataGridViewTextBoxColumn.DataPropertyName = "notelpon";
            this.notelponDataGridViewTextBoxColumn.HeaderText = "notelpon";
            this.notelponDataGridViewTextBoxColumn.Name = "notelponDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // tglmasukDataGridViewTextBoxColumn
            // 
            this.tglmasukDataGridViewTextBoxColumn.DataPropertyName = "tglmasuk";
            this.tglmasukDataGridViewTextBoxColumn.HeaderText = "tglmasuk";
            this.tglmasukDataGridViewTextBoxColumn.Name = "tglmasukDataGridViewTextBoxColumn";
            // 
            // karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bthome);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "karyawan";
            this.Text = "karyawan";
            this.Load += new System.EventHandler(this.karyawan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokorotiDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbperempuan;
        private System.Windows.Forms.RadioButton rblaki;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txemailkaryawan;
        private System.Windows.Forms.TextBox txnotelpkaryawan;
        private System.Windows.Forms.TextBox txalamatkaryawan;
        private System.Windows.Forms.TextBox txnamakaryawan;
        private System.Windows.Forms.TextBox txidkaryawan;
        private System.Windows.Forms.TextBox txsearchkaryawan;
        private System.Windows.Forms.Button btdeletekaryawan;
        private System.Windows.Forms.Button btclearkaryawan;
        private System.Windows.Forms.Button btsavekaryawan;
        private System.Windows.Forms.ComboBox cbjabatan;
        private System.Windows.Forms.TextBox txpass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tokorotiDataSet6 tokorotiDataSet6;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private tokorotiDataSet6TableAdapters.pegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglmasukDataGridViewTextBoxColumn;
    }
}