namespace Aviacao
{
    partial class CreateFlight
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
            this.dateTimePickerSelectedFlightDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrigemCountry = new System.Windows.Forms.TextBox();
            this.txtDestinyCountry = new System.Windows.Forms.TextBox();
            this.dateTimePickerHour = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAvioes = new System.Windows.Forms.ComboBox();
            this.numericUpDownEconomica = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrimeiraClasse = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEconomica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimeiraClasse)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerSelectedFlightDate
            // 
            this.dateTimePickerSelectedFlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSelectedFlightDate.Location = new System.Drawing.Point(304, 214);
            this.dateTimePickerSelectedFlightDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerSelectedFlightDate.MinDate = new System.DateTime(2023, 3, 7, 0, 0, 0, 0);
            this.dateTimePickerSelectedFlightDate.Name = "dateTimePickerSelectedFlightDate";
            this.dateTimePickerSelectedFlightDate.Size = new System.Drawing.Size(179, 38);
            this.dateTimePickerSelectedFlightDate.TabIndex = 0;
            this.dateTimePickerSelectedFlightDate.Value = new System.DateTime(2023, 3, 7, 0, 0, 0, 0);
            // 
            // txtOrigemCountry
            // 
            this.txtOrigemCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOrigemCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOrigemCountry.Enabled = false;
            this.txtOrigemCountry.Location = new System.Drawing.Point(304, 26);
            this.txtOrigemCountry.Name = "txtOrigemCountry";
            this.txtOrigemCountry.Size = new System.Drawing.Size(759, 38);
            this.txtOrigemCountry.TabIndex = 2;
            // 
            // txtDestinyCountry
            // 
            this.txtDestinyCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDestinyCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDestinyCountry.Enabled = false;
            this.txtDestinyCountry.Location = new System.Drawing.Point(304, 121);
            this.txtDestinyCountry.Name = "txtDestinyCountry";
            this.txtDestinyCountry.Size = new System.Drawing.Size(759, 38);
            this.txtDestinyCountry.TabIndex = 3;
            // 
            // dateTimePickerHour
            // 
            this.dateTimePickerHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHour.Location = new System.Drawing.Point(854, 207);
            this.dateTimePickerHour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerHour.MinDate = new System.DateTime(2023, 3, 7, 0, 0, 0, 0);
            this.dateTimePickerHour.Name = "dateTimePickerHour";
            this.dateTimePickerHour.Size = new System.Drawing.Size(209, 38);
            this.dateTimePickerHour.TabIndex = 4;
            this.dateTimePickerHour.Value = new System.DateTime(2023, 3, 7, 0, 0, 0, 0);
            // 
            // comboBoxAvioes
            // 
            this.comboBoxAvioes.FormattingEnabled = true;
            this.comboBoxAvioes.Location = new System.Drawing.Point(304, 307);
            this.comboBoxAvioes.Name = "comboBoxAvioes";
            this.comboBoxAvioes.Size = new System.Drawing.Size(759, 39);
            this.comboBoxAvioes.TabIndex = 5;
            // 
            // numericUpDownEconomica
            // 
            this.numericUpDownEconomica.DecimalPlaces = 2;
            this.numericUpDownEconomica.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownEconomica.Location = new System.Drawing.Point(442, 478);
            this.numericUpDownEconomica.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownEconomica.Name = "numericUpDownEconomica";
            this.numericUpDownEconomica.Size = new System.Drawing.Size(240, 38);
            this.numericUpDownEconomica.TabIndex = 6;
            // 
            // numericUpDownPrimeiraClasse
            // 
            this.numericUpDownPrimeiraClasse.DecimalPlaces = 2;
            this.numericUpDownPrimeiraClasse.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPrimeiraClasse.Location = new System.Drawing.Point(442, 388);
            this.numericUpDownPrimeiraClasse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrimeiraClasse.Name = "numericUpDownPrimeiraClasse";
            this.numericUpDownPrimeiraClasse.Size = new System.Drawing.Size(240, 38);
            this.numericUpDownPrimeiraClasse.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1128, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(266, 84);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDestinyCountry);
            this.panel1.Controls.Add(this.txtOrigemCountry);
            this.panel1.Controls.Add(this.comboBoxAvioes);
            this.panel1.Controls.Add(this.numericUpDownEconomica);
            this.panel1.Controls.Add(this.numericUpDownPrimeiraClasse);
            this.panel1.Controls.Add(this.dateTimePickerSelectedFlightDate);
            this.panel1.Controls.Add(this.dateTimePickerHour);
            this.panel1.Location = new System.Drawing.Point(103, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 540);
            this.panel1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(103, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor Econômica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(103, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor Primeira Classe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aviões:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(713, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Origem:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(816, 619);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(266, 84);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateFlight
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1469, 745);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(144)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1495, 898);
            this.MinimumSize = new System.Drawing.Size(1495, 816);
            this.Name = "CreateFlight";
            this.Text = "Adicionar Vôo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEconomica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimeiraClasse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dateTimePickerSelectedFlightDate;
        private TextBox txtOrigemCountry;
        private TextBox txtDestinyCountry;
        private DateTimePicker dateTimePickerHour;
        private ComboBox comboBoxAvioes;
        private NumericUpDown numericUpDownEconomica;
        private NumericUpDown numericUpDownPrimeiraClasse;
        private Button btnCriarVoo;
        private Panel panel1;
        private Button btnSave;
        private Button btnCancel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}