namespace Aviacao
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnTickets = new FontAwesome.Sharp.IconButton();
            this.btnManageFlights = new FontAwesome.Sharp.IconButton();
            this.iconButtonManagePlanes = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblCanceledFlights = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCanceledTickets = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPassagensVendidas = new System.Windows.Forms.Label();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.dateTimePickerSelectYear = new System.Windows.Forms.DateTimePicker();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.btnTickets);
            this.panelMenu.Controls.Add(this.btnManageFlights);
            this.panelMenu.Controls.Add(this.iconButtonManagePlanes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(492, 988);
            this.panelMenu.TabIndex = 1;
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.No;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 922);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(492, 66);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Sobre";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTickets.FlatAppearance.BorderSize = 0;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btnTickets.IconColor = System.Drawing.Color.White;
            this.btnTickets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTickets.IconSize = 40;
            this.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.Location = new System.Drawing.Point(0, 354);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTickets.Size = new System.Drawing.Size(492, 107);
            this.btnTickets.TabIndex = 3;
            this.btnTickets.Text = "Passagens";
            this.btnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTickets.UseVisualStyleBackColor = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnManageFlights
            // 
            this.btnManageFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageFlights.FlatAppearance.BorderSize = 0;
            this.btnManageFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageFlights.ForeColor = System.Drawing.Color.White;
            this.btnManageFlights.IconChar = FontAwesome.Sharp.IconChar.Passport;
            this.btnManageFlights.IconColor = System.Drawing.Color.White;
            this.btnManageFlights.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageFlights.IconSize = 40;
            this.btnManageFlights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageFlights.Location = new System.Drawing.Point(0, 247);
            this.btnManageFlights.Name = "btnManageFlights";
            this.btnManageFlights.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnManageFlights.Size = new System.Drawing.Size(492, 107);
            this.btnManageFlights.TabIndex = 2;
            this.btnManageFlights.Text = "Vôos ";
            this.btnManageFlights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageFlights.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageFlights.UseVisualStyleBackColor = true;
            this.btnManageFlights.Click += new System.EventHandler(this.btnManageFlights_Click);
            // 
            // iconButtonManagePlanes
            // 
            this.iconButtonManagePlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonManagePlanes.FlatAppearance.BorderSize = 0;
            this.iconButtonManagePlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonManagePlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButtonManagePlanes.ForeColor = System.Drawing.Color.White;
            this.iconButtonManagePlanes.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.iconButtonManagePlanes.IconColor = System.Drawing.Color.White;
            this.iconButtonManagePlanes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonManagePlanes.IconSize = 40;
            this.iconButtonManagePlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManagePlanes.Location = new System.Drawing.Point(0, 140);
            this.iconButtonManagePlanes.Name = "iconButtonManagePlanes";
            this.iconButtonManagePlanes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonManagePlanes.Size = new System.Drawing.Size(492, 107);
            this.iconButtonManagePlanes.TabIndex = 1;
            this.iconButtonManagePlanes.Text = "Aviões";
            this.iconButtonManagePlanes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManagePlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonManagePlanes.UseVisualStyleBackColor = true;
            this.iconButtonManagePlanes.Click += new System.EventHandler(this.iconButtonManagePlanes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(492, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(489, 137);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.panelTitleBar.Controls.Add(this.iconButtonClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildFormIcon);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(492, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1495, 80);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(46)))));
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 40;
            this.iconButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.Location = new System.Drawing.Point(1411, 9);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonClose.Size = new System.Drawing.Size(72, 71);
            this.iconButtonClose.TabIndex = 2;
            this.iconButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(116, 22);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(86, 31);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildFormIcon
            // 
            this.iconCurrentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.iconCurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildFormIcon.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildFormIcon.IconSize = 64;
            this.iconCurrentChildFormIcon.Location = new System.Drawing.Point(19, 11);
            this.iconCurrentChildFormIcon.Name = "iconCurrentChildFormIcon";
            this.iconCurrentChildFormIcon.Size = new System.Drawing.Size(64, 64);
            this.iconCurrentChildFormIcon.TabIndex = 0;
            this.iconCurrentChildFormIcon.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(492, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1495, 10);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelDesktop.Controls.Add(this.tabControl3);
            this.panelDesktop.Controls.Add(this.tabControl2);
            this.panelDesktop.Controls.Add(this.tabControl1);
            this.panelDesktop.Controls.Add(this.btnShowResults);
            this.panelDesktop.Controls.Add(this.dateTimePickerSelectYear);
            this.panelDesktop.Controls.Add(this.formsPlot1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelDesktop.Location = new System.Drawing.Point(492, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1495, 898);
            this.panelDesktop.TabIndex = 4;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(1061, 579);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(369, 134);
            this.tabControl3.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.tabPage3.Controls.Add(this.lblCanceledFlights);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.tabPage3.Location = new System.Drawing.Point(8, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(353, 81);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Vôos Cancelados";
            // 
            // lblCanceledFlights
            // 
            this.lblCanceledFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanceledFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.lblCanceledFlights.Location = new System.Drawing.Point(9, 18);
            this.lblCanceledFlights.Name = "lblCanceledFlights";
            this.lblCanceledFlights.Size = new System.Drawing.Size(341, 48);
            this.lblCanceledFlights.TabIndex = 0;
            this.lblCanceledFlights.Text = "label2";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(1061, 396);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(369, 134);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.tabPage2.Controls.Add(this.lblCanceledTickets);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.tabPage2.Location = new System.Drawing.Point(8, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 81);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Passagens Canceladas";
            // 
            // lblCanceledTickets
            // 
            this.lblCanceledTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanceledTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.lblCanceledTickets.Location = new System.Drawing.Point(9, 18);
            this.lblCanceledTickets.Name = "lblCanceledTickets";
            this.lblCanceledTickets.Size = new System.Drawing.Size(328, 48);
            this.lblCanceledTickets.TabIndex = 0;
            this.lblCanceledTickets.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1061, 221);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 134);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.labelPassagensVendidas);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.tabPage1.Location = new System.Drawing.Point(8, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 81);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passagens Vendidas";
            // 
            // labelPassagensVendidas
            // 
            this.labelPassagensVendidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassagensVendidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.labelPassagensVendidas.Location = new System.Drawing.Point(6, 14);
            this.labelPassagensVendidas.Name = "labelPassagensVendidas";
            this.labelPassagensVendidas.Size = new System.Drawing.Size(328, 43);
            this.labelPassagensVendidas.TabIndex = 0;
            this.labelPassagensVendidas.Text = "label1";
            // 
            // btnShowResults
            // 
            this.btnShowResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnShowResults.FlatAppearance.BorderSize = 0;
            this.btnShowResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(155)))));
            this.btnShowResults.Location = new System.Drawing.Point(465, 50);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(193, 60);
            this.btnShowResults.TabIndex = 3;
            this.btnShowResults.Text = "Ok";
            this.btnShowResults.UseVisualStyleBackColor = false;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // dateTimePickerSelectYear
            // 
            this.dateTimePickerSelectYear.CustomFormat = "true";
            this.dateTimePickerSelectYear.Location = new System.Drawing.Point(116, 59);
            this.dateTimePickerSelectYear.Name = "dateTimePickerSelectYear";
            this.dateTimePickerSelectYear.Size = new System.Drawing.Size(283, 38);
            this.dateTimePickerSelectYear.TabIndex = 2;
            // 
            // formsPlot1
            // 
            this.formsPlot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.formsPlot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.formsPlot1.Location = new System.Drawing.Point(56, 157);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(948, 634);
            this.formsPlot1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1987, 988);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnTickets;
        private FontAwesome.Sharp.IconButton btnManageFlights;
        private FontAwesome.Sharp.IconButton iconButtonManagePlanes;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFormIcon;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private ScottPlot.FormsPlot formsPlot1;
        private DateTimePicker dateTimePickerSelectYear;
        private Button btnShowResults;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label labelPassagensVendidas;
        private TabControl tabControl3;
        private TabPage tabPage3;
        private Label lblCanceledFlights;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private Label lblCanceledTickets;
    }
}