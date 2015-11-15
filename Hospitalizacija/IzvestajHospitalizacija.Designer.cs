namespace Hospitalizacija
{
    partial class IzvestajHospitalizacija
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
            this.label1 = new System.Windows.Forms.Label();
            this.gb_podaci_o_bolnici = new System.Windows.Forms.GroupBox();
            this.gb_podaci_o_pacijentu = new System.Windows.Forms.GroupBox();
            this.gb_dijagnoze_procedure = new System.Windows.Forms.GroupBox();
            this.gb_zakljucni_podaci = new System.Windows.Forms.GroupBox();
            this.btn_unos_izvestaja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gb_podaci_o_bolnici.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Историја болести";
            // 
            // gb_podaci_o_bolnici
            // 
            this.gb_podaci_o_bolnici.Controls.Add(this.dateTimePicker1);
            this.gb_podaci_o_bolnici.Controls.Add(this.textBox1);
            this.gb_podaci_o_bolnici.Controls.Add(this.comboBox2);
            this.gb_podaci_o_bolnici.Controls.Add(this.comboBox1);
            this.gb_podaci_o_bolnici.Controls.Add(this.label5);
            this.gb_podaci_o_bolnici.Controls.Add(this.label4);
            this.gb_podaci_o_bolnici.Controls.Add(this.label3);
            this.gb_podaci_o_bolnici.Controls.Add(this.label2);
            this.gb_podaci_o_bolnici.Location = new System.Drawing.Point(13, 53);
            this.gb_podaci_o_bolnici.Name = "gb_podaci_o_bolnici";
            this.gb_podaci_o_bolnici.Size = new System.Drawing.Size(756, 170);
            this.gb_podaci_o_bolnici.TabIndex = 1;
            this.gb_podaci_o_bolnici.TabStop = false;
            this.gb_podaci_o_bolnici.Text = "Подаци о болници";
            // 
            // gb_podaci_o_pacijentu
            // 
            this.gb_podaci_o_pacijentu.Location = new System.Drawing.Point(13, 230);
            this.gb_podaci_o_pacijentu.Name = "gb_podaci_o_pacijentu";
            this.gb_podaci_o_pacijentu.Size = new System.Drawing.Size(756, 150);
            this.gb_podaci_o_pacijentu.TabIndex = 2;
            this.gb_podaci_o_pacijentu.TabStop = false;
            this.gb_podaci_o_pacijentu.Text = "Подаци о пацијенту";
            // 
            // gb_dijagnoze_procedure
            // 
            this.gb_dijagnoze_procedure.Location = new System.Drawing.Point(13, 387);
            this.gb_dijagnoze_procedure.Name = "gb_dijagnoze_procedure";
            this.gb_dijagnoze_procedure.Size = new System.Drawing.Size(756, 218);
            this.gb_dijagnoze_procedure.TabIndex = 3;
            this.gb_dijagnoze_procedure.TabStop = false;
            this.gb_dijagnoze_procedure.Text = "Дијагнозе и процедуре";
            // 
            // gb_zakljucni_podaci
            // 
            this.gb_zakljucni_podaci.Location = new System.Drawing.Point(13, 612);
            this.gb_zakljucni_podaci.Name = "gb_zakljucni_podaci";
            this.gb_zakljucni_podaci.Size = new System.Drawing.Size(756, 210);
            this.gb_zakljucni_podaci.TabIndex = 4;
            this.gb_zakljucni_podaci.TabStop = false;
            this.gb_zakljucni_podaci.Text = "Закључни подаци";
            // 
            // btn_unos_izvestaja
            // 
            this.btn_unos_izvestaja.Location = new System.Drawing.Point(13, 839);
            this.btn_unos_izvestaja.Name = "btn_unos_izvestaja";
            this.btn_unos_izvestaja.Size = new System.Drawing.Size(98, 23);
            this.btn_unos_izvestaja.TabIndex = 5;
            this.btn_unos_izvestaja.Text = "Унос извештаја";
            this.btn_unos_izvestaja.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Здравствена установа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Одељење на пријему";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Број историје болести";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Датум пријема";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(468, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(172, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(468, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // IzvestajHospitalizacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 879);
            this.Controls.Add(this.btn_unos_izvestaja);
            this.Controls.Add(this.gb_zakljucni_podaci);
            this.Controls.Add(this.gb_dijagnoze_procedure);
            this.Controls.Add(this.gb_podaci_o_pacijentu);
            this.Controls.Add(this.gb_podaci_o_bolnici);
            this.Controls.Add(this.label1);
            this.Name = "IzvestajHospitalizacija";
            this.Text = "Izveštaj o hospitalizaciji";
            this.gb_podaci_o_bolnici.ResumeLayout(false);
            this.gb_podaci_o_bolnici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_podaci_o_bolnici;
        private System.Windows.Forms.GroupBox gb_podaci_o_pacijentu;
        private System.Windows.Forms.GroupBox gb_dijagnoze_procedure;
        private System.Windows.Forms.GroupBox gb_zakljucni_podaci;
        private System.Windows.Forms.Button btn_unos_izvestaja;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}