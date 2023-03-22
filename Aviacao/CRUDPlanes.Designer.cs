namespace Aviacao
{
    partial class CRUDPlanes
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
            this.listViewPlanes = new System.Windows.Forms.ListView();
            this.btnNewPlane = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearchPlane = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInativar = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnManutencao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPlanes
            // 
            this.listViewPlanes.BackColor = System.Drawing.Color.White;
            this.listViewPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.listViewPlanes.FullRowSelect = true;
            this.listViewPlanes.GridLines = true;
            this.listViewPlanes.HoverSelection = true;
            this.listViewPlanes.Location = new System.Drawing.Point(68, 148);
            this.listViewPlanes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewPlanes.MultiSelect = false;
            this.listViewPlanes.Name = "listViewPlanes";
            this.listViewPlanes.Size = new System.Drawing.Size(946, 639);
            this.listViewPlanes.TabIndex = 0;
            this.listViewPlanes.UseCompatibleStateImageBehavior = false;
            // 
            // btnNewPlane
            // 
            this.btnNewPlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnNewPlane.FlatAppearance.BorderSize = 0;
            this.btnNewPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewPlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnNewPlane.Location = new System.Drawing.Point(1050, 198);
            this.btnNewPlane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewPlane.Name = "btnNewPlane";
            this.btnNewPlane.Size = new System.Drawing.Size(404, 63);
            this.btnNewPlane.TabIndex = 1;
            this.btnNewPlane.Text = "Novo Avião";
            this.btnNewPlane.UseVisualStyleBackColor = false;
            this.btnNewPlane.Click += new System.EventHandler(this.btnNewPlane_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnEdit.Location = new System.Drawing.Point(1052, 290);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(404, 63);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar Avião";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearchPlane
            // 
            this.txtSearchPlane.Location = new System.Drawing.Point(68, 68);
            this.txtSearchPlane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchPlane.Name = "txtSearchPlane";
            this.txtSearchPlane.Size = new System.Drawing.Size(547, 38);
            this.txtSearchPlane.TabIndex = 3;
            this.txtSearchPlane.TextChanged += new System.EventHandler(this.txtSearchPlane_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(631, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar por colunas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnInativar.FlatAppearance.BorderSize = 0;
            this.btnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInativar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnInativar.Location = new System.Drawing.Point(3, 34);
            this.btnInativar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(408, 63);
            this.btnInativar.TabIndex = 8;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeStatus_MouseClick);
            // 
            // btnAtivar
            // 
            this.btnAtivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnAtivar.FlatAppearance.BorderSize = 0;
            this.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnAtivar.Location = new System.Drawing.Point(7, 199);
            this.btnAtivar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(408, 63);
            this.btnAtivar.TabIndex = 9;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = false;
            this.btnAtivar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeStatus_MouseClick);
            // 
            // btnManutencao
            // 
            this.btnManutencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.btnManutencao.FlatAppearance.BorderSize = 0;
            this.btnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManutencao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnManutencao.Location = new System.Drawing.Point(5, 115);
            this.btnManutencao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(408, 69);
            this.btnManutencao.TabIndex = 10;
            this.btnManutencao.Text = "Manutenção";
            this.btnManutencao.UseVisualStyleBackColor = false;
            this.btnManutencao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeStatus_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtivar);
            this.groupBox1.Controls.Add(this.btnManutencao);
            this.groupBox1.Controls.Add(this.btnInativar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.groupBox1.Location = new System.Drawing.Point(1043, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 346);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Status Avião";
            // 
            // CRUDPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1469, 827);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchPlane);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewPlane);
            this.Controls.Add(this.listViewPlanes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1495, 898);
            this.MinimumSize = new System.Drawing.Size(1495, 898);
            this.Name = "CRUDPlanes";
            this.Text = "Gestor Aeronaves";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewPlanes;
        private Button btnNewPlane;
        private Button btnEdit;
        private TextBox txtSearchPlane;
        private Label label1;
        private Button btnInativar;
        private Button btnAtivar;
        private Button btnManutencao;
        private GroupBox groupBox1;
    }
}