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
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        AracManager aracManager = new AracManager();

        void Yukle()
        {
            dgvMusteriler.DataSource = manager.GetAll();
            cbAracId.DataSource = aracManager.GetAll();
            cbAracId.DisplayMember = "Modeli";
            cbAracId.ValueMember = "Id";

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

        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Musteri
                    {
                        Adi = txtAdi.Text,
                        Adres = txtAdres.Text,
                        AracId = Convert.ToInt32(cbAracId.SelectedValue),
                        Email = txtEmail.Text,
                        Notlar = txtNotlar.Text,
                        Soyadi = txtSoyadi.Text,
                        TcNo = txtTcNo.Text,
                        Telefon = txtTelefon.Text,
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

                MessageBox.Show("Hata oluştu! kayıt eklenemedi!");
            }
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var musteri = manager.Find(Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value));
                if (musteri != null)
                {
                    txtAdi.Text = musteri.Adi;
                    txtAdres.Text = musteri.Adres;
                    txtEmail.Text = musteri.Email;
                    txtNotlar.Text = musteri.Notlar;
                    txtSoyadi.Text = musteri.Soyadi;
                    txtTcNo.Text = musteri.TcNo;
                    txtTelefon.Text = musteri.Telefon;
                    
                    cbAracId.SelectedValue = musteri.AracId;
                    lblId.Text = musteri.Id.ToString();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bilgiler yüklenemedi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(
                    new Musteri
                    {
                        Id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value),
                        Adi = txtAdi.Text,
                        Adres = txtAdres.Text,
                        AracId = Convert.ToInt32(cbAracId.SelectedValue),
                        Email = txtEmail.Text,
                        Notlar = txtNotlar.Text,
                        Soyadi = txtSoyadi.Text,
                        TcNo = txtTcNo.Text,
                        Telefon = txtTelefon.Text,
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

                MessageBox.Show("Hata oluştu! kayıt güncellenemedi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value));

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

                throw;
            }
        }
    }
}
