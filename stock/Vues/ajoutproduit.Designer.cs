namespace stock.Vues
{
    partial class ajoutproduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutproduit));
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnsave = new Guna.UI.WinForms.GunaGradientButton();
            this.btnannuler = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtpu = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtnom = new Guna.UI.WinForms.GunaTextBox();
            this.cblibelle = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(-35, 258);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(35, 19);
            this.gunaLabel5.TabIndex = 59;
            this.gunaLabel5.Text = "etat";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(6, 97);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(108, 19);
            this.gunaLabel1.TabIndex = 58;
            this.gunaLabel1.Text = "nom du produit";
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
            this.btnsave.Location = new System.Drawing.Point(349, 218);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Black;
            this.btnsave.Radius = 11;
            this.btnsave.Size = new System.Drawing.Size(152, 50);
            this.btnsave.TabIndex = 56;
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
            this.btnannuler.Location = new System.Drawing.Point(10, 218);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnannuler.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnannuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnannuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnannuler.OnHoverImage = null;
            this.btnannuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnannuler.Radius = 11;
            this.btnannuler.Size = new System.Drawing.Size(145, 50);
            this.btnannuler.TabIndex = 55;
            this.btnannuler.Text = "annuler";
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(6, 160);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(161, 19);
            this.gunaLabel3.TabIndex = 64;
            this.gunaLabel3.Text = "prix unitaire du produit";
            // 
            // txtpu
            // 
            this.txtpu.BaseColor = System.Drawing.Color.White;
            this.txtpu.BorderColor = System.Drawing.Color.Silver;
            this.txtpu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpu.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpu.Location = new System.Drawing.Point(176, 150);
            this.txtpu.Name = "txtpu";
            this.txtpu.PasswordChar = '\0';
            this.txtpu.Size = new System.Drawing.Size(326, 41);
            this.txtpu.TabIndex = 65;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(12, 36);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(120, 19);
            this.gunaLabel4.TabIndex = 66;
            this.gunaLabel4.Text = "libelle du produit";
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
            this.txtnom.Location = new System.Drawing.Point(175, 87);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.Size = new System.Drawing.Size(326, 41);
            this.txtnom.TabIndex = 67;
            // 
            // cblibelle
            // 
            this.cblibelle.BackColor = System.Drawing.Color.Transparent;
            this.cblibelle.BaseColor = System.Drawing.Color.White;
            this.cblibelle.BorderColor = System.Drawing.Color.Silver;
            this.cblibelle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cblibelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblibelle.FocusedColor = System.Drawing.Color.Empty;
            this.cblibelle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblibelle.ForeColor = System.Drawing.Color.Black;
            this.cblibelle.FormattingEnabled = true;
            this.cblibelle.Location = new System.Drawing.Point(175, 32);
            this.cblibelle.Name = "cblibelle";
            this.cblibelle.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cblibelle.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cblibelle.Size = new System.Drawing.Size(326, 30);
            this.cblibelle.TabIndex = 68;
            // 
            // ajoutproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 277);
            this.Controls.Add(this.cblibelle);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtpu);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnannuler);
            this.Name = "ajoutproduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajoutproduit";
            this.Load += new System.EventHandler(this.ajoutproduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public Guna.UI.WinForms.GunaRadioButton Chketat
        {
            get { return chketat; }
            set { chketat = value; }
        }
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton btnsave;
        private Guna.UI.WinForms.GunaGradientButton btnannuler;

        public Guna.UI.WinForms.GunaTextBox Txtnom
        {
            get { return txtnom; }
            set { txtnom = value; }
        }
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtpu;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtnom;
        private Guna.UI.WinForms.GunaComboBox cblibelle;

        public Guna.UI.WinForms.GunaTextBox Txtpu
        {
            get { return txtpu; }
            set { txtpu = value; }
        }
    }
}