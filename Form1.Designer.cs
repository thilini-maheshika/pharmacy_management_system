namespace Pharmacy_Management_System
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.btnsignin = new Guna.UI.WinForms.GunaButton();
            this.btnreset = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 770);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 281);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "LANKA PHARMACY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHARMACY MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.AnimationHoverSpeed = 0.07F;
            this.btnexit.AnimationSpeed = 0.03F;
            this.btnexit.BaseColor = System.Drawing.Color.White;
            this.btnexit.BorderColor = System.Drawing.Color.Black;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnexit.FocusedColor = System.Drawing.Color.Empty;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnexit.Location = new System.Drawing.Point(1320, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnexit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnexit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnexit.OnHoverImage = null;
            this.btnexit.OnPressedColor = System.Drawing.Color.Black;
            this.btnexit.Size = new System.Drawing.Size(48, 42);
            this.btnexit.TabIndex = 1;
            this.btnexit.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(780, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sign In to Your Account";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(860, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.BaseColor = System.Drawing.Color.White;
            this.txtusername.BorderColor = System.Drawing.Color.Silver;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(860, 265);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(260, 30);
            this.txtusername.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.BaseColor = System.Drawing.Color.White;
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(860, 356);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(260, 30);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnsignin
            // 
            this.btnsignin.AnimationHoverSpeed = 0.07F;
            this.btnsignin.AnimationSpeed = 0.03F;
            this.btnsignin.BackColor = System.Drawing.Color.Transparent;
            this.btnsignin.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnsignin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsignin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsignin.FocusedColor = System.Drawing.Color.Empty;
            this.btnsignin.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.White;
            this.btnsignin.Image = null;
            this.btnsignin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsignin.Location = new System.Drawing.Point(747, 461);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsignin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsignin.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnsignin.OnHoverImage = null;
            this.btnsignin.OnPressedColor = System.Drawing.Color.Black;
            this.btnsignin.Radius = 6;
            this.btnsignin.Size = new System.Drawing.Size(149, 40);
            this.btnsignin.TabIndex = 8;
            this.btnsignin.Text = "Sign In";
            this.btnsignin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsignin.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btnreset
            // 
            this.btnreset.AnimationHoverSpeed = 0.07F;
            this.btnreset.AnimationSpeed = 0.03F;
            this.btnreset.BackColor = System.Drawing.Color.Transparent;
            this.btnreset.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnreset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnreset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnreset.FocusedColor = System.Drawing.Color.Empty;
            this.btnreset.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = null;
            this.btnreset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnreset.Location = new System.Drawing.Point(971, 461);
            this.btnreset.Name = "btnreset";
            this.btnreset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnreset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnreset.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnreset.OnHoverImage = null;
            this.btnreset.OnPressedColor = System.Drawing.Color.Black;
            this.btnreset.Radius = 6;
            this.btnreset.Size = new System.Drawing.Size(149, 40);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 760);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private Guna.UI.WinForms.GunaButton btnsignin;
        private Guna.UI.WinForms.GunaButton btnreset;
        public Guna.UI.WinForms.GunaTextBox txtpassword;
    }
}

