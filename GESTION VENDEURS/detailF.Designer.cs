namespace GESTION_VENDEURS
{
    partial class detailF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprixnet = new System.Windows.Forms.Label();
            this.txtpn = new Guna.UI.WinForms.GunaTextBox();
            this.txtdcc = new Guna.UI.WinForms.GunaTextBox();
            this.txtcinc = new Guna.UI.WinForms.GunaTextBox();
            this.txtncc = new Guna.UI.WinForms.GunaTextBox();
            this.txtnf = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tablevp = new Guna.UI.WinForms.GunaDataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablevp)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtprixnet);
            this.guna2Panel1.Controls.Add(this.txtpn);
            this.guna2Panel1.Controls.Add(this.txtdcc);
            this.guna2Panel1.Controls.Add(this.txtcinc);
            this.guna2Panel1.Controls.Add(this.txtncc);
            this.guna2Panel1.Controls.Add(this.txtnf);
            this.guna2Panel1.Controls.Add(this.gunaLabel4);
            this.guna2Panel1.Controls.Add(this.gunaLabel3);
            this.guna2Panel1.Controls.Add(this.gunaLabel2);
            this.guna2Panel1.Controls.Add(this.gunaLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1487, 470);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(1401, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "/DHS";
            // 
            // txtprixnet
            // 
            this.txtprixnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprixnet.AutoSize = true;
            this.txtprixnet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtprixnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprixnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.txtprixnet.Location = new System.Drawing.Point(1070, 384);
            this.txtprixnet.Name = "txtprixnet";
            this.txtprixnet.Size = new System.Drawing.Size(101, 25);
            this.txtprixnet.TabIndex = 53;
            this.txtprixnet.Text = "PrixNet : ";
            // 
            // txtpn
            // 
            this.txtpn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpn.BackColor = System.Drawing.Color.Transparent;
            this.txtpn.BaseColor = System.Drawing.Color.White;
            this.txtpn.BorderColor = System.Drawing.Color.Silver;
            this.txtpn.BorderSize = 0;
            this.txtpn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpn.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpn.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpn.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpn.Location = new System.Drawing.Point(1176, 363);
            this.txtpn.Name = "txtpn";
            this.txtpn.PasswordChar = '\0';
            this.txtpn.Radius = 20;
            this.txtpn.ReadOnly = true;
            this.txtpn.SelectedText = "";
            this.txtpn.Size = new System.Drawing.Size(219, 63);
            this.txtpn.TabIndex = 52;
            this.txtpn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdcc
            // 
            this.txtdcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdcc.BackColor = System.Drawing.Color.Transparent;
            this.txtdcc.BaseColor = System.Drawing.Color.White;
            this.txtdcc.BorderColor = System.Drawing.Color.Silver;
            this.txtdcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdcc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdcc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdcc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdcc.Location = new System.Drawing.Point(198, 279);
            this.txtdcc.Name = "txtdcc";
            this.txtdcc.PasswordChar = '\0';
            this.txtdcc.Radius = 15;
            this.txtdcc.ReadOnly = true;
            this.txtdcc.SelectedText = "";
            this.txtdcc.Size = new System.Drawing.Size(707, 53);
            this.txtdcc.TabIndex = 7;
            this.txtdcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdcc.TextChanged += new System.EventHandler(this.txtdcc_TextChanged);
            // 
            // txtcinc
            // 
            this.txtcinc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcinc.BackColor = System.Drawing.Color.Transparent;
            this.txtcinc.BaseColor = System.Drawing.Color.White;
            this.txtcinc.BorderColor = System.Drawing.Color.Silver;
            this.txtcinc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcinc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcinc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcinc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcinc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcinc.Location = new System.Drawing.Point(198, 196);
            this.txtcinc.Name = "txtcinc";
            this.txtcinc.PasswordChar = '\0';
            this.txtcinc.Radius = 15;
            this.txtcinc.ReadOnly = true;
            this.txtcinc.SelectedText = "";
            this.txtcinc.Size = new System.Drawing.Size(707, 53);
            this.txtcinc.TabIndex = 6;
            this.txtcinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcinc.TextChanged += new System.EventHandler(this.txtcinc_TextChanged);
            // 
            // txtncc
            // 
            this.txtncc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtncc.BackColor = System.Drawing.Color.Transparent;
            this.txtncc.BaseColor = System.Drawing.Color.White;
            this.txtncc.BorderColor = System.Drawing.Color.Silver;
            this.txtncc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtncc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtncc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtncc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtncc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtncc.Location = new System.Drawing.Point(198, 116);
            this.txtncc.Name = "txtncc";
            this.txtncc.PasswordChar = '\0';
            this.txtncc.Radius = 15;
            this.txtncc.ReadOnly = true;
            this.txtncc.SelectedText = "";
            this.txtncc.Size = new System.Drawing.Size(707, 53);
            this.txtncc.TabIndex = 5;
            this.txtncc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtncc.TextChanged += new System.EventHandler(this.txtncc_TextChanged);
            // 
            // txtnf
            // 
            this.txtnf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnf.BackColor = System.Drawing.Color.Transparent;
            this.txtnf.BaseColor = System.Drawing.Color.White;
            this.txtnf.BorderColor = System.Drawing.Color.Silver;
            this.txtnf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnf.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnf.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtnf.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnf.Location = new System.Drawing.Point(1292, 22);
            this.txtnf.Name = "txtnf";
            this.txtnf.PasswordChar = '\0';
            this.txtnf.Radius = 15;
            this.txtnf.ReadOnly = true;
            this.txtnf.SelectedText = "";
            this.txtnf.Size = new System.Drawing.Size(160, 57);
            this.txtnf.TabIndex = 4;
            this.txtnf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnf.TextChanged += new System.EventHandler(this.txtnf_TextChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(1055, 35);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(204, 31);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Numero Facture : ";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(24, 290);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(82, 31);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Date : ";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(24, 206);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(71, 31);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "CIN : ";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(24, 126);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(154, 31);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Nom Client : ";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // tablevp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablevp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablevp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablevp.BackgroundColor = System.Drawing.Color.White;
            this.tablevp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablevp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablevp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablevp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablevp.ColumnHeadersHeight = 50;
            this.tablevp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablevp.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablevp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablevp.EnableHeadersVisualStyles = false;
            this.tablevp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablevp.Location = new System.Drawing.Point(0, 470);
            this.tablevp.Name = "tablevp";
            this.tablevp.ReadOnly = true;
            this.tablevp.RowHeadersVisible = false;
            this.tablevp.RowHeadersWidth = 51;
            this.tablevp.RowTemplate.Height = 50;
            this.tablevp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablevp.Size = new System.Drawing.Size(1487, 370);
            this.tablevp.TabIndex = 33;
            this.tablevp.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablevp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablevp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablevp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablevp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablevp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablevp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablevp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablevp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tablevp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablevp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablevp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablevp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablevp.ThemeStyle.HeaderStyle.Height = 50;
            this.tablevp.ThemeStyle.ReadOnly = true;
            this.tablevp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablevp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablevp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablevp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablevp.ThemeStyle.RowsStyle.Height = 50;
            this.tablevp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablevp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // detailF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 840);
            this.ControlBox = false;
            this.Controls.Add(this.tablevp);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "detailF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.detailF_Load_1);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablevp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaTextBox txtdcc;
        private Guna.UI.WinForms.GunaTextBox txtcinc;
        private Guna.UI.WinForms.GunaTextBox txtncc;
        private Guna.UI.WinForms.GunaTextBox txtnf;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView tablevp;
        private System.Windows.Forms.Label txtprixnet;
        private Guna.UI.WinForms.GunaTextBox txtpn;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}