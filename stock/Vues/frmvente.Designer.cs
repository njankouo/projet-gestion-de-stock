namespace stock.Vues
{
    partial class frmvente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvente));
            this.txtdate = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.txtsearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionVentesEtApprovisionnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDuFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesApprovisionnementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvisionnementChezFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionsVentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rembourssementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesChezFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPersonnelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrersousToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aperçuavantimpressionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dgfournisseur = new System.Windows.Forms.DataGridView();
            this.Txtnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.Animated = true;
            this.txtdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdate.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdate.LineColor = System.Drawing.Color.Gainsboro;
            this.txtdate.Location = new System.Drawing.Point(1144, 44);
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.Size = new System.Drawing.Size(200, 53);
            this.txtdate.TabIndex = 22;
            this.txtdate.Text = "Search from date....";
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton5.Location = new System.Drawing.Point(359, 44);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 11;
            this.gunaButton5.Size = new System.Drawing.Size(160, 53);
            this.gunaButton5.TabIndex = 21;
            this.gunaButton5.Text = "rafraichir";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Animated = true;
            this.txtsearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtsearch.Location = new System.Drawing.Point(849, 44);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Size = new System.Drawing.Size(280, 53);
            this.txtsearch.TabIndex = 20;
            this.txtsearch.Text = "Search from name....";
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.Enabled = false;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton4.Location = new System.Drawing.Point(525, 44);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 11;
            this.gunaButton4.Size = new System.Drawing.Size(160, 53);
            this.gunaButton4.TabIndex = 19;
            this.gunaButton4.Text = "corbeille";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton3.Location = new System.Drawing.Point(193, 44);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 11;
            this.gunaButton3.Size = new System.Drawing.Size(160, 53);
            this.gunaButton3.TabIndex = 18;
            this.gunaButton3.Text = "Imprimer";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaButton1.Location = new System.Drawing.Point(16, 44);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 11;
            this.gunaButton1.Size = new System.Drawing.Size(171, 53);
            this.gunaButton1.TabIndex = 17;
            this.gunaButton1.Text = "nouvelle Vente";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionVentesEtApprovisionnementToolStripMenuItem,
            this.gestionDeStockToolStripMenuItem,
            this.gestionDesApprovisionnementsToolStripMenuItem,
            this.gestionDesProduitsToolStripMenuItem,
            this.gestionsVentesToolStripMenuItem,
            this.gestionCommandesToolStripMenuItem,
            this.gestionPersonnelsToolStripMenuItem,
            this.fichierToolStripMenuItem,
            this.fichierToolStripMenuItem1,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(16, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1325, 30);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionVentesEtApprovisionnementToolStripMenuItem
            // 
            this.gestionVentesEtApprovisionnementToolStripMenuItem.Checked = true;
            this.gestionVentesEtApprovisionnementToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gestionVentesEtApprovisionnementToolStripMenuItem.Enabled = false;
            this.gestionVentesEtApprovisionnementToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionVentesEtApprovisionnementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionVentesEtApprovisionnementToolStripMenuItem.Image")));
            this.gestionVentesEtApprovisionnementToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Navy;
            this.gestionVentesEtApprovisionnementToolStripMenuItem.Name = "gestionVentesEtApprovisionnementToolStripMenuItem";
            this.gestionVentesEtApprovisionnementToolStripMenuItem.ShowShortcutKeys = false;
            this.gestionVentesEtApprovisionnementToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.gestionVentesEtApprovisionnementToolStripMenuItem.Text = "LIste des Ventes";
            // 
            // gestionDeStockToolStripMenuItem
            // 
            this.gestionDeStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockDuFournisseurToolStripMenuItem});
            this.gestionDeStockToolStripMenuItem.Name = "gestionDeStockToolStripMenuItem";
            this.gestionDeStockToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.gestionDeStockToolStripMenuItem.Text = "Gestion De Stock";
            // 
            // stockDuFournisseurToolStripMenuItem
            // 
            this.stockDuFournisseurToolStripMenuItem.Name = "stockDuFournisseurToolStripMenuItem";
            this.stockDuFournisseurToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.stockDuFournisseurToolStripMenuItem.Text = "Stock Du Fournisseur";
            // 
            // gestionDesApprovisionnementsToolStripMenuItem
            // 
            this.gestionDesApprovisionnementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approvisionnementChezFournisseurToolStripMenuItem});
            this.gestionDesApprovisionnementsToolStripMenuItem.Name = "gestionDesApprovisionnementsToolStripMenuItem";
            this.gestionDesApprovisionnementsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.gestionDesApprovisionnementsToolStripMenuItem.Text = "Gestion Des Appros";
            // 
            // approvisionnementChezFournisseurToolStripMenuItem
            // 
            this.approvisionnementChezFournisseurToolStripMenuItem.Name = "approvisionnementChezFournisseurToolStripMenuItem";
            this.approvisionnementChezFournisseurToolStripMenuItem.Size = new System.Drawing.Size(331, 24);
            this.approvisionnementChezFournisseurToolStripMenuItem.Text = "Approvisionnement Chez Fournisseur";
            // 
            // gestionDesProduitsToolStripMenuItem
            // 
            this.gestionDesProduitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesProduitsToolStripMenuItem,
            this.produitsToolStripMenuItem});
            this.gestionDesProduitsToolStripMenuItem.Name = "gestionDesProduitsToolStripMenuItem";
            this.gestionDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.gestionDesProduitsToolStripMenuItem.Text = "Gestion Des Produits";
            // 
            // categoriesProduitsToolStripMenuItem
            // 
            this.categoriesProduitsToolStripMenuItem.Name = "categoriesProduitsToolStripMenuItem";
            this.categoriesProduitsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.categoriesProduitsToolStripMenuItem.Text = "Categories Produits";
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // gestionsVentesToolStripMenuItem
            // 
            this.gestionsVentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventesToolStripMenuItem,
            this.rembourssementsToolStripMenuItem});
            this.gestionsVentesToolStripMenuItem.Name = "gestionsVentesToolStripMenuItem";
            this.gestionsVentesToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.gestionsVentesToolStripMenuItem.Text = "Gestions Ventes";
            // 
            // ventesToolStripMenuItem
            // 
            this.ventesToolStripMenuItem.Name = "ventesToolStripMenuItem";
            this.ventesToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.ventesToolStripMenuItem.Text = "ventes";
            // 
            // rembourssementsToolStripMenuItem
            // 
            this.rembourssementsToolStripMenuItem.Name = "rembourssementsToolStripMenuItem";
            this.rembourssementsToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.rembourssementsToolStripMenuItem.Text = "Rembourssements";
            // 
            // gestionCommandesToolStripMenuItem
            // 
            this.gestionCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandesChezFournisseursToolStripMenuItem});
            this.gestionCommandesToolStripMenuItem.Name = "gestionCommandesToolStripMenuItem";
            this.gestionCommandesToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.gestionCommandesToolStripMenuItem.Text = "Gestion Commandes";
            // 
            // commandesChezFournisseursToolStripMenuItem
            // 
            this.commandesChezFournisseursToolStripMenuItem.Name = "commandesChezFournisseursToolStripMenuItem";
            this.commandesChezFournisseursToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.commandesChezFournisseursToolStripMenuItem.Text = "Commandes Chez Fournisseurs";
            // 
            // gestionPersonnelsToolStripMenuItem
            // 
            this.gestionPersonnelsToolStripMenuItem.Name = "gestionPersonnelsToolStripMenuItem";
            this.gestionPersonnelsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.gestionPersonnelsToolStripMenuItem.Text = "Gestion Personnels";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
            this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.nouveauToolStripMenuItem.Text = "&Nouveau";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(240, 6);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
            this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            // 
            // enregistrersousToolStripMenuItem
            // 
            this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
            this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
            this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.imprimerToolStripMenuItem.Text = "&Imprimer";
            // 
            // aperçuavantimpressionToolStripMenuItem
            // 
            this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
            this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
            this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(240, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1,
            this.ouvrirToolStripMenuItem1,
            this.toolStripSeparator3,
            this.enregistrerToolStripMenuItem1,
            this.enregistrersousToolStripMenuItem1,
            this.toolStripSeparator4,
            this.imprimerToolStripMenuItem1,
            this.aperçuavantimpressionToolStripMenuItem1,
            this.toolStripSeparator5,
            this.quitterToolStripMenuItem1});
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(71, 26);
            this.fichierToolStripMenuItem1.Text = "&Fichier";
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem1.Image")));
            this.nouveauToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.nouveauToolStripMenuItem1.Text = "&Nouveau";
            // 
            // ouvrirToolStripMenuItem1
            // 
            this.ouvrirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem1.Image")));
            this.ouvrirToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripMenuItem1.Name = "ouvrirToolStripMenuItem1";
            this.ouvrirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.ouvrirToolStripMenuItem1.Text = "&Ouvrir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(240, 6);
            // 
            // enregistrerToolStripMenuItem1
            // 
            this.enregistrerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem1.Image")));
            this.enregistrerToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripMenuItem1.Name = "enregistrerToolStripMenuItem1";
            this.enregistrerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.enregistrerToolStripMenuItem1.Text = "&Enregistrer";
            // 
            // enregistrersousToolStripMenuItem1
            // 
            this.enregistrersousToolStripMenuItem1.Name = "enregistrersousToolStripMenuItem1";
            this.enregistrersousToolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.enregistrersousToolStripMenuItem1.Text = "Enregistrer &sous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(240, 6);
            // 
            // imprimerToolStripMenuItem1
            // 
            this.imprimerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem1.Image")));
            this.imprimerToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripMenuItem1.Name = "imprimerToolStripMenuItem1";
            this.imprimerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimerToolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.imprimerToolStripMenuItem1.Text = "&Imprimer";
            // 
            // aperçuavantimpressionToolStripMenuItem1
            // 
            this.aperçuavantimpressionToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem1.Image")));
            this.aperçuavantimpressionToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aperçuavantimpressionToolStripMenuItem1.Name = "aperçuavantimpressionToolStripMenuItem1";
            this.aperçuavantimpressionToolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.aperçuavantimpressionToolStripMenuItem1.Text = "Aperçu a&vant impression";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(240, 6);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.quitterToolStripMenuItem1.Text = "&Quitter";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 26);
            // 
            // dgfournisseur
            // 
            this.dgfournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgfournisseur.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgfournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgfournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Txtnom,
            this.nom,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgfournisseur.Location = new System.Drawing.Point(12, 113);
            this.dgfournisseur.Name = "dgfournisseur";
            this.dgfournisseur.Size = new System.Drawing.Size(1338, 441);
            this.dgfournisseur.TabIndex = 23;
            // 
            // Txtnom
            // 
            this.Txtnom.HeaderText = "#";
            this.Txtnom.Name = "Txtnom";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom Des Fournisseurs";
            this.nom.Name = "nom";
            this.nom.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telephone Des Fournisseurs";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Code Fournisseurs";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adresse Fournisseurs";
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 300F;
            this.Column6.HeaderText = "etat du fournisseur";
            this.Column6.Name = "Column6";
            this.Column6.Width = 450;
            // 
            // frmvente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 555);
            this.Controls.Add(this.dgfournisseur);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.gunaButton5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmvente";
            this.Text = "frmvente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txtdate;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaLineTextBox txtsearch;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionVentesEtApprovisionnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDuFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesApprovisionnementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvisionnementChezFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionsVentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rembourssementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandesChezFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPersonnelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView dgfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txtnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}