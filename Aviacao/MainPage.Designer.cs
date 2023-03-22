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
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).BeginInit();
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
            this.iconButtonManagePlanes.Text = "Gerir Aviões";
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
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(492, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1495, 898);
            this.panelDesktop.TabIndex = 4;
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
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).EndInit();
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
    }
}