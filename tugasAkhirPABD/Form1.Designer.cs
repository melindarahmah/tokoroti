namespace tugasAkhirPABD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Button();
            this.btsignup = new System.Windows.Forms.Button();
            this.txpass = new System.Windows.Forms.TextBox();
            this.txnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.btsignup);
            this.panel1.Controls.Add(this.txpass);
            this.panel1.Controls.Add(this.txnama);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btexit.FlatAppearance.BorderSize = 5;
            this.btexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btexit.Font = new System.Drawing.Font("Swis721 BT", 9F);
            this.btexit.ForeColor = System.Drawing.Color.White;
            this.btexit.Location = new System.Drawing.Point(208, 330);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(113, 42);
            this.btexit.TabIndex = 8;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btsignup
            // 
            this.btsignup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsignup.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btsignup.FlatAppearance.BorderSize = 5;
            this.btsignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btsignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btsignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsignup.Font = new System.Drawing.Font("Swis721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsignup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btsignup.Location = new System.Drawing.Point(420, 330);
            this.btsignup.Name = "btsignup";
            this.btsignup.Size = new System.Drawing.Size(113, 42);
            this.btsignup.TabIndex = 7;
            this.btsignup.Text = "SignUp";
            this.btsignup.UseVisualStyleBackColor = false;
            this.btsignup.Click += new System.EventHandler(this.button1_Click);
            // 
            // txpass
            // 
            this.txpass.Location = new System.Drawing.Point(334, 249);
            this.txpass.Name = "txpass";
            this.txpass.Size = new System.Drawing.Size(209, 22);
            this.txpass.TabIndex = 6;
            this.txpass.TextChanged += new System.EventHandler(this.txpass_TextChanged);
            this.txpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txpass_KeyPress);
            // 
            // txnama
            // 
            this.txnama.Location = new System.Drawing.Point(334, 193);
            this.txnama.Name = "txnama";
            this.txnama.Size = new System.Drawing.Size(209, 22);
            this.txnama.TabIndex = 5;
            this.txnama.TextChanged += new System.EventHandler(this.txnama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Schadow BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(231, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::tugasAkhirPABD.Properties.Resources.KakaStriker;
            this.pictureBox1.Location = new System.Drawing.Point(41, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsignup;
        private System.Windows.Forms.TextBox txpass;
        private System.Windows.Forms.TextBox txnama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btexit;
    }
}

