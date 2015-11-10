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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_podaci_o_bolnici;
        private System.Windows.Forms.GroupBox gb_podaci_o_pacijentu;
        private System.Windows.Forms.GroupBox gb_dijagnoze_procedure;
        private System.Windows.Forms.GroupBox gb_zakljucni_podaci;
        private System.Windows.Forms.Button btn_unos_izvestaja;
    }
}