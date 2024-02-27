namespace GESTION_VENDEURS
{
    partial class H_vents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H_vents));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tablevents = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtnf = new Guna.UI.WinForms.GunaTextBox();
            this.txtncc = new Guna.UI.WinForms.GunaTextBox();
            this.txtcinc = new Guna.UI.WinForms.GunaTextBox();
            this.txtdcc = new Guna.UI.WinForms.GunaTextBox();
            this.btn_consulter = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablevents)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Panel1.Controls.Add(this.btn_consulter);
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
            this.guna2Panel1.Size = new System.Drawing.Size(1078, 422);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.tablevents);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 422);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1078, 341);
            this.guna2Panel2.TabIndex = 1;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tablevents
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tablevents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablevents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablevents.BackgroundColor = System.Drawing.Color.White;
            this.tablevents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablevents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablevents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablevents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablevents.ColumnHeadersHeight = 50;
            this.tablevents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablevents.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablevents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablevents.EnableHeadersVisualStyles = false;
            this.tablevents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablevents.Location = new System.Drawing.Point(0, 0);
            this.tablevents.Name = "tablevents";
            this.tablevents.ReadOnly = true;
            this.tablevents.RowHeadersVisible = false;
            this.tablevents.RowHeadersWidth = 51;
            this.tablevents.RowTemplate.Height = 50;
            this.tablevents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablevents.Size = new System.Drawing.Size(1078, 341);
            this.tablevents.TabIndex = 1;
            this.tablevents.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablevents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablevents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablevents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablevents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablevents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablevents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablevents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablevents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tablevents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablevents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tablevents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablevents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablevents.ThemeStyle.HeaderStyle.Height = 50;
            this.tablevents.ThemeStyle.ReadOnly = true;
            this.tablevents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablevents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablevents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.tablevents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablevents.ThemeStyle.RowsStyle.Height = 50;
            this.tablevents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablevents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablevents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablevents_CellContentClick);
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
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(646, 35);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(204, 31);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Numero Facture : ";
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
            this.txtnf.Location = new System.Drawing.Point(883, 22);
            this.txtnf.Name = "txtnf";
            this.txtnf.PasswordChar = '\0';
            this.txtnf.Radius = 15;
            this.txtnf.ReadOnly = true;
            this.txtnf.SelectedText = "";
            this.txtnf.Size = new System.Drawing.Size(160, 57);
            this.txtnf.TabIndex = 4;
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
            this.txtncc.Size = new System.Drawing.Size(298, 53);
            this.txtncc.TabIndex = 5;
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
            this.txtcinc.Size = new System.Drawing.Size(298, 53);
            this.txtcinc.TabIndex = 6;
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
            this.txtdcc.Size = new System.Drawing.Size(298, 53);
            this.txtdcc.TabIndex = 7;
            // 
            // btn_consulter
            // 
            this.btn_consulter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consulter.AnimationHoverSpeed = 0.07F;
            this.btn_consulter.AnimationSpeed = 0.03F;
            this.btn_consulter.BackColor = System.Drawing.Color.Transparent;
            this.btn_consulter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btn_consulter.BorderColor = System.Drawing.Color.Black;
            this.btn_consulter.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_consulter.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_consulter.CheckedForeColor = System.Drawing.Color.White;
            this.btn_consulter.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_consulter.CheckedImage")));
            this.btn_consulter.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_consulter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_consulter.FocusedColor = System.Drawing.Color.Empty;
            this.btn_consulter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulter.ForeColor = System.Drawing.Color.White;
            this.btn_consulter.Image = null;
            this.btn_consulter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_consulter.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_consulter.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_consulter.Location = new System.Drawing.Point(847, 279);
            this.btn_consulter.Name = "btn_consulter";
            this.btn_consulter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_consulter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_consulter.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_consulter.OnHoverImage = null;
            this.btn_consulter.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_consulter.OnPressedColor = System.Drawing.Color.Black;
            this.btn_consulter.Radius = 20;
            this.btn_consulter.Size = new System.Drawing.Size(196, 63);
            this.btn_consulter.TabIndex = 45;
            this.btn_consulter.Text = "Consulter ";
            this.btn_consulter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H_vents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 763);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "H_vents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.H_vents_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablevents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI.WinForms.GunaDataGridView tablevents;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtdcc;
        private Guna.UI.WinForms.GunaTextBox txtcinc;
        private Guna.UI.WinForms.GunaTextBox txtncc;
        private Guna.UI.WinForms.GunaTextBox txtnf;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_consulter;
    }
}