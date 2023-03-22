namespace Aviacao
{
    partial class SeatsSelector
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnFirstClass = new System.Windows.Forms.Button();
            this.btnEconomy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.panelSeatsSelector = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnOk.Location = new System.Drawing.Point(1180, 721);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(263, 84);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Salvar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnFirstClass
            // 
            this.btnFirstClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnFirstClass.FlatAppearance.BorderSize = 0;
            this.btnFirstClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnFirstClass.Location = new System.Drawing.Point(337, 22);
            this.btnFirstClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFirstClass.Name = "btnFirstClass";
            this.btnFirstClass.Size = new System.Drawing.Size(263, 45);
            this.btnFirstClass.TabIndex = 1;
            this.btnFirstClass.Text = "Primeira Classe";
            this.btnFirstClass.UseVisualStyleBackColor = false;
            this.btnFirstClass.Click += new System.EventHandler(this.btnFirstClass_Click);
            // 
            // btnEconomy
            // 
            this.btnEconomy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnEconomy.FlatAppearance.BorderSize = 0;
            this.btnEconomy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEconomy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnEconomy.Location = new System.Drawing.Point(665, 22);
            this.btnEconomy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Size = new System.Drawing.Size(185, 45);
            this.btnEconomy.TabIndex = 2;
            this.btnEconomy.Text = "Econômica";
            this.btnEconomy.UseVisualStyleBackColor = false;
            this.btnEconomy.Click += new System.EventHandler(this.btnEconomy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFirstClass);
            this.panel2.Controls.Add(this.lblValor);
            this.panel2.Controls.Add(this.btnEconomy);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1455, 94);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(919, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.lblValor.Location = new System.Drawing.Point(1084, 29);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 31);
            this.lblValor.TabIndex = 3;
            // 
            // panelSeatsSelector
            // 
            this.panelSeatsSelector.AutoScroll = true;
            this.panelSeatsSelector.Location = new System.Drawing.Point(15, 111);
            this.panelSeatsSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSeatsSelector.Name = "panelSeatsSelector";
            this.panelSeatsSelector.Size = new System.Drawing.Size(1455, 545);
            this.panelSeatsSelector.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnClose.Location = new System.Drawing.Point(878, 721);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(263, 84);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SeatsSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1469, 827);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelSeatsSelector);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1495, 898);
            this.MinimumSize = new System.Drawing.Size(1495, 898);
            this.Name = "SeatsSelector";
            this.Text = "Seletor Lugares";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblValor;
        private Label label2;
        private Panel panel1;
        private Button button2;
        private Button btnOk;
        private Button btnFirstClass;
        private Button btnEconomy;
        private Panel panel2;
        private Panel panelSeatsSelector;
        private Button btnClose;
        private Label label1;
    }
}