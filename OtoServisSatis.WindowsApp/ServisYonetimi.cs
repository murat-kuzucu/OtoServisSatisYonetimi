using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class ServisYonetimi : Form
    {
        public ServisYonetimi()
        {
            InitializeComponent();
        }
        ServisManager manager = new ServisManager();
        
        void Yukle()
        {
            dgvServisler.DataSource = manager.GetAll();

        }

        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            lblId.Text = "0";
        }

        private void ServisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Servis
                    {
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu = txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.Value,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.Value,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        YapilanIslemler = txtYapilanIslemler.Text,

                    });

                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt başarıyla eklendi!");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu kayıt eklenemedi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(dgvServisler.CurrentRow.Cells[0].Value));

                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt başarıyla silindi!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek kaydı seçiniz!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu kayıt silenemedi!");
            }
        }

        private void dgvServisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var servis = manager.Find(Convert.ToInt32(dgvServisler.CurrentRow.Cells[0].Value));

                if (servis != null)
                {
                    txtAracPlaka.Text = servis.AracPlaka;
                    txtAracSorunu.Text = servis.AracSorunu;
                    txtKasaTipi.Text = servis.KasaTipi;
                    txtMarka.Text = servis.Marka;
                    txtModel.Text = servis.Model;
                    txtNotlar.Text = servis.Notlar;
                    txtSaseNo.Text = servis.SaseNo;
                    txtServisUcreti.Text = servis.ServisUcreti.ToString();
                    txtYapilanIslemler.Text = servis.YapilanIslemler;
                    dtpServiseGelisTarihi.Value = servis.ServiseGelisTarihi;
                    dtpServistenCikisTarihi.Value = servis.ServistenCikisTarihi;
                    cbGaranti.Checked = servis.GarantiKapsamindaMi;
                    lblId.Text = servis.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu kayıt yüklenemedi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(
                    new Servis
                    {
                        Id = Convert.ToInt32(dgvServisler.CurrentRow.Cells[0].Value),
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu = txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.Value,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.Value,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        YapilanIslemler = txtYapilanIslemler.Text,

                    });

                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt başarıyla güncellendi!");
                    }
                }
                else
                {
                    MessageBox.Show("Listeden güncellenecek kaydı seçiniz!");
                }
                
                

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu kayıt güncellenemedi!");
            }
        }
    }
}
