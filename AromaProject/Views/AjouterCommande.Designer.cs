namespace GestionAromaRazan.Views
{
    partial class AjouterCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TXTQTE1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduit = new Guna.UI.WinForms.GunaTextBox();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtCNIE = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaDataGridView2 = new Guna.UI.WinForms.GunaDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTQTE2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprix = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.calculer = new System.Windows.Forms.Button();
            this.NumCommadne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentifiantProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIEClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtprixtotal = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTQTE1
            // 
            this.TXTQTE1.Enabled = false;
            this.TXTQTE1.Location = new System.Drawing.Point(414, 499);
            this.TXTQTE1.Margin = new System.Windows.Forms.Padding(4);
            this.TXTQTE1.Mask = "99999999";
            this.TXTQTE1.Name = "TXTQTE1";
            this.TXTQTE1.Size = new System.Drawing.Size(221, 22);
            this.TXTQTE1.TabIndex = 5;
            this.TXTQTE1.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(208, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "Num Commande";
            // 
            // txtProduit
            // 
            this.txtProduit.BaseColor = System.Drawing.Color.White;
            this.txtProduit.BorderColor = System.Drawing.Color.Silver;
            this.txtProduit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProduit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProduit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtProduit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProduit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProduit.Location = new System.Drawing.Point(412, 363);
            this.txtProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.PasswordChar = '\0';
            this.txtProduit.SelectedText = "";
            this.txtProduit.Size = new System.Drawing.Size(376, 37);
            this.txtProduit.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.Silver;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(412, 324);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(376, 37);
            this.txtId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(208, 457);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 82;
            this.label2.Text = "Date Commande";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Orange;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(296, 665);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(157, 48);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Vider";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(131, 665);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(157, 48);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(208, 496);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 81;
            this.label6.Text = "Quantite de Stock";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(412, 447);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(304, 26);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(377, 26);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // txtCNIE
            // 
            this.txtCNIE.BaseColor = System.Drawing.Color.White;
            this.txtCNIE.BorderColor = System.Drawing.Color.Silver;
            this.txtCNIE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCNIE.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCNIE.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCNIE.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCNIE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCNIE.Location = new System.Drawing.Point(412, 405);
            this.txtCNIE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNIE.Name = "txtCNIE";
            this.txtCNIE.PasswordChar = '\0';
            this.txtCNIE.SelectedText = "";
            this.txtCNIE.Size = new System.Drawing.Size(376, 37);
            this.txtCNIE.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(208, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 85;
            this.label3.Text = "CNIE Client";
            // 
            // gunaDataGridView2
            // 
            this.gunaDataGridView2.AllowUserToAddRows = false;
            this.gunaDataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(198)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridView2.ColumnHeadersHeight = 21;
            this.gunaDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCommadne,
            this.IdentifiantProduit,
            this.CNIEClient,
            this.DateCommande,
            this.Quantite,
            this.Prix,
            this.PrixTotal});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDataGridView2.EnableHeadersVisualStyles = false;
            this.gunaDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView2.Location = new System.Drawing.Point(0, 74);
            this.gunaDataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaDataGridView2.Name = "gunaDataGridView2";
            this.gunaDataGridView2.ReadOnly = true;
            this.gunaDataGridView2.RowHeadersVisible = false;
            this.gunaDataGridView2.RowHeadersWidth = 51;
            this.gunaDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView2.Size = new System.Drawing.Size(1168, 222);
            this.gunaDataGridView2.TabIndex = 86;
            this.gunaDataGridView2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(198)))), ((int)(((byte)(156)))));
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.SlateBlue;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.Height = 21;
            this.gunaDataGridView2.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView2_CellClick);
            this.gunaDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1020, 644);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(208, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 89;
            this.label5.Text = "Identifiant Produit";
            // 
            // TXTQTE2
            // 
            this.TXTQTE2.Location = new System.Drawing.Point(414, 543);
            this.TXTQTE2.Margin = new System.Windows.Forms.Padding(4);
            this.TXTQTE2.Mask = "99999999";
            this.TXTQTE2.Name = "TXTQTE2";
            this.TXTQTE2.Size = new System.Drawing.Size(221, 22);
            this.TXTQTE2.TabIndex = 4;
            this.TXTQTE2.ValidatingType = typeof(int);
            this.TXTQTE2.MaskChanged += new System.EventHandler(this.TXTQTE2_MaskChanged);
            this.TXTQTE2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TXTQTE2_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(643, 496);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 81);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quantité Disponible ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qte});
            this.dataGridView1.Location = new System.Drawing.Point(0, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(13, 23);
            this.dataGridView1.TabIndex = 92;
            // 
            // Qte
            // 
            this.Qte.DataPropertyName = "Qte_Stock";
            this.Qte.HeaderText = "Qte";
            this.Qte.MinimumWidth = 6;
            this.Qte.Name = "Qte";
            this.Qte.Width = 125;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(627, 665);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(157, 48);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.White;
            this.BtnModifier.Location = new System.Drawing.Point(461, 665);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(157, 48);
            this.BtnModifier.TabIndex = 9;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "Rechercher Numero Commande";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(485, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(435, 22);
            this.txtSearch.TabIndex = 95;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::GestionAromaRazan.Properties.Resources.Refresh;
            this.button4.Location = new System.Drawing.Point(1115, 297);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 48);
            this.button4.TabIndex = 97;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(198)))), ((int)(((byte)(156)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::GestionAromaRazan.Properties.Resources.digital_art_lion4;
            this.button3.Location = new System.Drawing.Point(0, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 48);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(208, 540);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 98;
            this.label7.Text = "Quantite ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(208, 579);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 23);
            this.label8.TabIndex = 99;
            this.label8.Text = "Prix De Produit";
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(412, 576);
            this.txtprix.Margin = new System.Windows.Forms.Padding(4);
            this.txtprix.Mask = "99999999";
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(223, 22);
            this.txtprix.TabIndex = 100;
            this.txtprix.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(208, 611);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 102;
            this.label9.Text = "Prix Total";
            // 
            // calculer
            // 
            this.calculer.BackColor = System.Drawing.Color.Green;
            this.calculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculer.ForeColor = System.Drawing.Color.White;
            this.calculer.Location = new System.Drawing.Point(792, 665);
            this.calculer.Margin = new System.Windows.Forms.Padding(4);
            this.calculer.Name = "calculer";
            this.calculer.Size = new System.Drawing.Size(137, 49);
            this.calculer.TabIndex = 103;
            this.calculer.Text = "Calculer";
            this.calculer.UseVisualStyleBackColor = false;
            this.calculer.Click += new System.EventHandler(this.button5_Click);
            // 
            // NumCommadne
            // 
            this.NumCommadne.DataPropertyName = "IdCommande";
            this.NumCommadne.HeaderText = "Num Commadne";
            this.NumCommadne.MinimumWidth = 6;
            this.NumCommadne.Name = "NumCommadne";
            this.NumCommadne.ReadOnly = true;
            // 
            // IdentifiantProduit
            // 
            this.IdentifiantProduit.DataPropertyName = "IdentifiantProduit";
            this.IdentifiantProduit.HeaderText = "Identifiant Produit";
            this.IdentifiantProduit.MinimumWidth = 6;
            this.IdentifiantProduit.Name = "IdentifiantProduit";
            this.IdentifiantProduit.ReadOnly = true;
            // 
            // CNIEClient
            // 
            this.CNIEClient.DataPropertyName = "CNIE_Client";
            this.CNIEClient.HeaderText = "CNIE Client ";
            this.CNIEClient.MinimumWidth = 6;
            this.CNIEClient.Name = "CNIEClient";
            this.CNIEClient.ReadOnly = true;
            // 
            // DateCommande
            // 
            this.DateCommande.DataPropertyName = "DateCommande";
            this.DateCommande.HeaderText = "Date Commande";
            this.DateCommande.MinimumWidth = 6;
            this.DateCommande.Name = "DateCommande";
            this.DateCommande.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "Qte";
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.MinimumWidth = 6;
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // PrixTotal
            // 
            this.PrixTotal.DataPropertyName = "PrixTotal";
            this.PrixTotal.HeaderText = "PrixTotal";
            this.PrixTotal.MinimumWidth = 6;
            this.PrixTotal.Name = "PrixTotal";
            this.PrixTotal.ReadOnly = true;
            // 
            // txtprixtotal
            // 
            this.txtprixtotal.Enabled = false;
            this.txtprixtotal.Location = new System.Drawing.Point(412, 614);
            this.txtprixtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtprixtotal.Mask = "99999999";
            this.txtprixtotal.Name = "txtprixtotal";
            this.txtprixtotal.Size = new System.Drawing.Size(223, 22);
            this.txtprixtotal.TabIndex = 104;
            this.txtprixtotal.ValidatingType = typeof(int);
            // 
            // AjouterCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(198)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1168, 727);
            this.Controls.Add(this.txtprixtotal);
            this.Controls.Add(this.calculer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXTQTE2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunaDataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCNIE);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.TXTQTE1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjouterCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterCommande";
            this.Load += new System.EventHandler(this.AjouterCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TXTQTE1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtProduit;
        private Guna.UI.WinForms.GunaTextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Guna.UI.WinForms.GunaTextBox txtCNIE;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TXTQTE2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtprix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calculer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCommadne;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifiantProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIEClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixTotal;
        private System.Windows.Forms.MaskedTextBox txtprixtotal;
    }
}