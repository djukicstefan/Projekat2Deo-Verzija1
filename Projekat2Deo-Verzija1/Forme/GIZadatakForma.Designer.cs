﻿
namespace Projekat2Deo_Verzija1.Forme
{
    partial class GIZadatakForma
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
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbZadaci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vreme rešavanja:";
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(160, 35);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(121, 20);
            this.txtVreme.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(101, 146);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(125, 38);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbZadaci
            // 
            this.cmbZadaci.FormattingEnabled = true;
            this.cmbZadaci.Location = new System.Drawing.Point(160, 86);
            this.cmbZadaci.Name = "cmbZadaci";
            this.cmbZadaci.Size = new System.Drawing.Size(121, 21);
            this.cmbZadaci.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Izaberi zadatak:";
            // 
            // GrupniZadatakForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZadaci);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtVreme);
            this.Controls.Add(this.label1);
            this.Name = "GrupniZadatakForma";
            this.Text = "Grupni zadatak";
            this.Load += new System.EventHandler(this.GrupniZadatakForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbZadaci;
        private System.Windows.Forms.Label label2;
    }
}