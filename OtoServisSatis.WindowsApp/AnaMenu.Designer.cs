﻿namespace OtoServisSatis.WindowsApp
{
    partial class AnaMenu
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
            this.btnAracYonetimi = new System.Windows.Forms.Button();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.btnMarkaYonetimi = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnSatisYonetimi = new System.Windows.Forms.Button();
            this.btnRolYonetimi = new System.Windows.Forms.Button();
            this.btnServisYonetimi = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAracYonetimi
            // 
            this.btnAracYonetimi.Location = new System.Drawing.Point(8, 79);
            this.btnAracYonetimi.Name = "btnAracYonetimi";
            this.btnAracYonetimi.Size = new System.Drawing.Size(103, 68);
            this.btnAracYonetimi.TabIndex = 0;
            this.btnAracYonetimi.Text = "Araç Yönetimi";
            this.btnAracYonetimi.UseVisualStyleBackColor = true;
            this.btnAracYonetimi.Click += new System.EventHandler(this.btnAracYonetimi_Click);
            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(117, 79);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(107, 68);
            this.btnKullaniciYonetimi.TabIndex = 1;
            this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.UseVisualStyleBackColor = true;
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
            // 
            // btnMarkaYonetimi
            // 
            this.btnMarkaYonetimi.Location = new System.Drawing.Point(230, 79);
            this.btnMarkaYonetimi.Name = "btnMarkaYonetimi";
            this.btnMarkaYonetimi.Size = new System.Drawing.Size(105, 68);
            this.btnMarkaYonetimi.TabIndex = 2;
            this.btnMarkaYonetimi.Text = "Marka Yönetimi";
            this.btnMarkaYonetimi.UseVisualStyleBackColor = true;
            this.btnMarkaYonetimi.Click += new System.EventHandler(this.btnMarkaYonetimi_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(341, 79);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(101, 68);
            this.btnMusteriYonetimi.TabIndex = 3;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnSatisYonetimi
            // 
            this.btnSatisYonetimi.Location = new System.Drawing.Point(555, 79);
            this.btnSatisYonetimi.Name = "btnSatisYonetimi";
            this.btnSatisYonetimi.Size = new System.Drawing.Size(98, 68);
            this.btnSatisYonetimi.TabIndex = 4;
            this.btnSatisYonetimi.Text = "Satış Yönetimi";
            this.btnSatisYonetimi.UseVisualStyleBackColor = true;
            this.btnSatisYonetimi.Click += new System.EventHandler(this.btnSatisYonetimi_Click);
            // 
            // btnRolYonetimi
            // 
            this.btnRolYonetimi.Location = new System.Drawing.Point(448, 79);
            this.btnRolYonetimi.Name = "btnRolYonetimi";
            this.btnRolYonetimi.Size = new System.Drawing.Size(101, 68);
            this.btnRolYonetimi.TabIndex = 5;
            this.btnRolYonetimi.Text = "Rol Yönetimi";
            this.btnRolYonetimi.UseVisualStyleBackColor = true;
            this.btnRolYonetimi.Click += new System.EventHandler(this.btnRolYonetimi_Click);
            // 
            // btnServisYonetimi
            // 
            this.btnServisYonetimi.Location = new System.Drawing.Point(659, 79);
            this.btnServisYonetimi.Name = "btnServisYonetimi";
            this.btnServisYonetimi.Size = new System.Drawing.Size(96, 68);
            this.btnServisYonetimi.TabIndex = 6;
            this.btnServisYonetimi.Text = "Servis Yönetimi";
            this.btnServisYonetimi.UseVisualStyleBackColor = true;
            this.btnServisYonetimi.Click += new System.EventHandler(this.btnServisYonetimi_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(341, 197);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(103, 68);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 308);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnServisYonetimi);
            this.Controls.Add(this.btnRolYonetimi);
            this.Controls.Add(this.btnSatisYonetimi);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Controls.Add(this.btnMarkaYonetimi);
            this.Controls.Add(this.btnKullaniciYonetimi);
            this.Controls.Add(this.btnAracYonetimi);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracYonetimi;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
        private System.Windows.Forms.Button btnMarkaYonetimi;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnSatisYonetimi;
        private System.Windows.Forms.Button btnRolYonetimi;
        private System.Windows.Forms.Button btnServisYonetimi;
        private System.Windows.Forms.Button btnCikis;
    }
}