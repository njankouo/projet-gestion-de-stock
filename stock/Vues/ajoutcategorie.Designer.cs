namespace stock.Vues
{
    partial class ajoutcategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutcategorie));
            this.btnannuler = new Guna.UI.WinForms.GunaGradientButton();
            this.btnsave = new Guna.UI.WinForms.GunaGradientButton();
            this.txtlibelle = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
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
            this.btnannuler.Location = new System.Drawing.Point(16, 106);
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
            this.btnsave.Location = new System.Drawing.Point(267, 96);
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
            // txtlibelle
            // 
            this.txtlibelle.BaseColor = System.Drawing.Color.White;
            this.txtlibelle.BorderColor = System.Drawing.Color.Silver;
            this.txtlibelle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlibelle.FocusedBaseColor = System.Drawing.Color.White;
            this.txtlibelle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtlibelle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtlibelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtlibelle.Location = new System.Drawing.Point(76, 12);
            this.txtlibelle.Name = "txtlibelle";
            this.txtlibelle.PasswordChar = '\0';
            this.txtlibelle.Size = new System.Drawing.Size(343, 55);
            this.txtlibelle.TabIndex = 33;
            this.txtlibelle.TextChanged += new System.EventHandler(this.txtlibelle_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(49, 19);
            this.gunaLabel1.TabIndex = 34;
            this.gunaLabel1.Text = "libelle";
            // 
            // ajoutcategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 176);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtlibelle);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnannuler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ajoutcategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajoutcategorie";
            this.Load += new System.EventHandler(this.ajoutcategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btnannuler;
        private Guna.UI.WinForms.GunaGradientButton btnsave;
        private Guna.UI.WinForms.GunaTextBox txtlibelle;

        public Guna.UI.WinForms.GunaTextBox Txtlibelle
        {
            get { return txtlibelle; }
            set { txtlibelle = value; }
        }
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}