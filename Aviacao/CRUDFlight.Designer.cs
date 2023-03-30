namespace Aviacao
{
    partial class CRUDFlight
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
            this.txtSearchFlight = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNewFlight = new System.Windows.Forms.Button();
            this.listViewFlights = new System.Windows.Forms.ListView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearchFlight
            // 
            this.txtSearchFlight.Location = new System.Drawing.Point(384, 59);
            this.txtSearchFlight.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSearchFlight.Name = "txtSearchFlight";
            this.txtSearchFlight.Size = new System.Drawing.Size(598, 38);
            this.txtSearchFlight.TabIndex = 10;
            this.txtSearchFlight.TextChanged += new System.EventHandler(this.txtSearchFlight_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnEdit.Location = new System.Drawing.Point(538, 723);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(404, 63);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar Vôo";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewFlight
            // 
            this.btnNewFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnNewFlight.FlatAppearance.BorderSize = 0;
            this.btnNewFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnNewFlight.Location = new System.Drawing.Point(38, 723);
            this.btnNewFlight.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNewFlight.Name = "btnNewFlight";
            this.btnNewFlight.Size = new System.Drawing.Size(404, 63);
            this.btnNewFlight.TabIndex = 8;
            this.btnNewFlight.Text = "Novo Vôo";
            this.btnNewFlight.UseVisualStyleBackColor = false;
            this.btnNewFlight.Click += new System.EventHandler(this.btnNewFlight_Click);
            // 
            // listViewFlights
            // 
            this.listViewFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.listViewFlights.FullRowSelect = true;
            this.listViewFlights.HoverSelection = true;
            this.listViewFlights.Location = new System.Drawing.Point(38, 125);
            this.listViewFlights.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listViewFlights.MultiSelect = false;
            this.listViewFlights.Name = "listViewFlights";
            this.listViewFlights.Size = new System.Drawing.Size(1398, 555);
            this.listViewFlights.TabIndex = 7;
            this.listViewFlights.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnCancelar.Location = new System.Drawing.Point(1032, 723);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(404, 63);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar Vôo";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisar por colunas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CRUDFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1469, 827);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSearchFlight);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewFlight);
            this.Controls.Add(this.listViewFlights);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1495, 898);
            this.MinimumSize = new System.Drawing.Size(1495, 898);
            this.Name = "CRUDFlight";
            this.Text = "Gestor Vôos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSearchFlight;
        private Button btnEdit;
        private Button btnNewFlight;
        private ListView listViewFlights;
        private Button btnCancelar;
        private Label label1;
    }
}