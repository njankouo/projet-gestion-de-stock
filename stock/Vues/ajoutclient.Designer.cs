namespace stock.Vues
{
    partial class ajoutclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutclient));
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.chketat = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txttel = new Guna.UI.WinForms.GunaTextBox();
            this.txtadresse = new Guna.UI.WinForms.GunaTextBox();
            this.txtnom = new Guna.UI.WinForms.GunaTextBox();
            this.btnsave = new Guna.UI.WinForms.GunaGradientButton();
            this.btnannuler = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // dtdate
            // 
            this.dtdate.Enabled = false;
            this.dtdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdate.Location = new System.Drawing.Point(178, 167);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(326, 29);
            this.dtdate.TabIndex = 42;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(8, 167);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(171, 19);
            this.gunaLabel6.TabIndex = 41;
            this.gunaLabel6.Text = "date de l\'enregistrement";
            // 
            // chketat
            // 
            this.chketat.BaseColor = System.Drawing.SystemColors.Control;
            this.chketat.Checked = true;
            this.chketat.CheckedOffColor = System.Drawing.Color.Gray;
            this.chketat.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chketat.Enabled = false;
            this.chketat.FillColor = System.Drawing.Color.White;
            this.chketat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chketat.Location = new System.Drawing.Point(178, 227);
            this.chketat.Name = "chketat";
            this.chketat.Size = new System.Drawing.Size(62, 22);
            this.chketat.TabIndex = 40;
            this.chketat.Text = "actif";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(12, 227);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(35, 19);
            this.gunaLabel5.TabIndex = 39;
            this.gunaLabel5.Text = "etat";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(8, 118);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(121, 19);
            this.gunaLabel4.TabIndex = 38;
            this.gunaLabel4.Text = "adresse du client";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(8, 68);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(134, 19);
            this.gunaLabel2.TabIndex = 37;
            this.gunaLabel2.Text = "telephone du client";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 19);
            this.gunaLabel1.TabIndex = 36;
            this.gunaLabel1.Text = "nom du client";
            // 
            // txttel
            // 
            this.txttel.BaseColor = System.Drawing.Color.White;
            this.txttel.BorderColor = System.Drawing.Color.Silver;
            this.txttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttel.FocusedBaseColor = System.Drawing.Color.White;
            this.txttel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttel.Location = new System.Drawing.Point(178, 59);
            this.txttel.Name = "txttel";
            this.txttel.PasswordChar = '\0';
            this.txttel.Size = new System.Drawing.Size(326, 41);
            this.txttel.TabIndex = 35;
            // 
            // txtadresse
            // 
            this.txtadresse.BaseColor = System.Drawing.Color.White;
            this.txtadresse.BorderColor = System.Drawing.Color.Silver;
            this.txtadresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadresse.FocusedBaseColor = System.Drawing.Color.White;
            this.txtadresse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtadresse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtadresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtadresse.Location = new System.Drawing.Point(178, 106);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.PasswordChar = '\0';
            this.txtadresse.Size = new System.Drawing.Size(326, 41);
            this.txtadresse.TabIndex = 34;
            // 
            // txtnom
            // 
            this.txtnom.BaseColor = System.Drawing.Color.White;
            this.txtnom.BorderColor = System.Drawing.Color.Silver;
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtnom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnom.Location = new System.Drawing.Point(178, 12);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.Size = new System.Drawing.Size(326, 41);
            this.txtnom.TabIndex = 33;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.AnimationHoverSpeed = 0.07F;
            this.btnsave.AnimationSpeed = 0.03F;
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnsave.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnsave.BorderColor = System.Drawing.Color.Black;
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsave.FocusedColor = System.Drawing.Color.Empty;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnsave.Location = new System.Drawing.Point(352, 274);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Black;
            this.btnsave.Radius = 11;
            this.btnsave.Size = new System.Drawing.Size(152, 50);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "enregistrer";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.AnimationHoverSpeed = 0.07F;
            this.btnannuler.AnimationSpeed = 0.03F;
            this.btnannuler.BackColor = System.Drawing.Color.Transparent;
            this.btnannuler.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnannuler.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnannuler.BorderColor = System.Drawing.Color.Black;
            this.btnannuler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnannuler.FocusedColor = System.Drawing.Color.Empty;
            this.btnannuler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.ForeColor = System.Drawing.Color.White;
            this.btnannuler.Image = ((System.Drawing.Image)(resources.GetObject("btnannuler.Image")));
            this.btnannuler.ImageSize = new System.Drawing.Size(40, 40);
            this.btnannuler.Location = new System.Drawing.Point(12, 265);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnannuler.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnannuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnannuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnannuler.OnHoverImage = null;
            this.btnannuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnannuler.Radius = 11;
            this.btnannuler.Size = new System.Drawing.Size(145, 50);
            this.btnannuler.TabIndex = 31;
            this.btnannuler.Text = "annuler";
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // ajoutclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 335);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.chketat);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnannuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ajoutclient";
            this.Text = "ajoutclient";
            this.Load += new System.EventHandler(this.ajoutclient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtdate;

        public System.Windows.Forms.DateTimePicker Dtdate
        {
            get { return dtdate; }
            set { dtdate = value; }
        }
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaRadioButton chketat;

        public Guna.UI.WinForms.GunaRadioButton Chketat
        {
            get { return chketat; }
            set { chketat = value; }
        }
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txttel;

        public Guna.UI.WinForms.GunaTextBox Txttel
        {
            get { return txttel; }
            set { txttel = value; }
        }
        private Guna.UI.WinForms.GunaTextBox txtadresse;

        public Guna.UI.WinForms.GunaTextBox Txtadresse
        {
            get { return txtadresse; }
            set { txtadresse = value; }
        }
        private Guna.UI.WinForms.GunaTextBox txtnom;

        public Guna.UI.WinForms.GunaTextBox Txtnom
        {
            get { return txtnom; }
            set { txtnom = value; }
        }
        private Guna.UI.WinForms.GunaGradientButton btnsave;
        private Guna.UI.WinForms.GunaGradientButton btnannuler;
    }
}