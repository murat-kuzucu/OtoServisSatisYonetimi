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
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();

        RoleManager roleManager = new RoleManager();

        void Yukle()
        {
            var ozelSorgu = (from k in manager.GetAllByInclude("Rol")
                             select new
                             {
                                 Id = k.Id,
                                 Adı = k.Adi,
                                 Soyadı = k.Soyadi,
                                 Email = k.Email,
                                 Telefon = k.Telefon,
                                 Kullanıcı_Adı = k.KullaniciAdi,
                                 Durum = k.AktifMi,
                                 Eklenme_Tarihi = k.EklenmeTarihi,
                                 Rolü = k.Rol.Adi
                             }).ToList();




            //dgvKullanicilar.DataSource = manager.GetAll();
            cbKullaniciRolu.DataSource = roleManager.GetAll();
            dgvKullanicilar.DataSource = ozelSorgu;

        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();

        }
        private void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtTelefon.Text = string.Empty;

        }

        private void lblEklenmeTarihi_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    int islemSonucu = manager.Add(
                        new Kullanici
                        {
                            Adi = txtAdi.Text,
                            AktifMi = cbAktif.Checked,
                            EklenmeTarihi = DateTime.Now,
                            Email = txtEmail.Text,
                            KullaniciAdi = txtKullaniciAdi.Text,
                            RolId = Convert.ToInt32(cbKullaniciRolu.SelectedValue.ToString()),
                            Sifre = txtSifre.Text,
                            Soyadi = txtSoyadi.Text,
                            Telefon = txtTelefon.Text,


                        });

                    if (islemSonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kullanıcı başarıyla eklendi.");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu! Kullanıcı eklenemedi.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    int kulId = Convert.ToInt32(lblId.Text);


                    int islemSonucu = manager.Update(
                        new Kullanici
                        {
                            Id = kulId,
                            Adi = txtAdi.Text,
                            AktifMi = cbAktif.Checked,
                            EklenmeTarihi = DateTime.Now,
                            Email = txtEmail.Text,
                            KullaniciAdi = txtKullaniciAdi.Text,
                            RolId = Convert.ToInt32(cbKullaniciRolu.SelectedValue.ToString()),
                            Sifre = txtSifre.Text,
                            Soyadi = txtSoyadi.Text,
                            Telefon = txtTelefon.Text,


                        });

                    if (islemSonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                    }
                }
                    
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu! Kullanıcı güncellenemedi.");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int kulId = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);
                if (kulId > 0)
                {
                    var kullanici = manager.Find(kulId);
                    txtAdi.Text = kullanici.Adi;
                    txtEmail.Text = kullanici.Email;
                    txtKullaniciAdi.Text = kullanici.KullaniciAdi;
                    txtSifre.Text = kullanici.Sifre;
                    txtSoyadi.Text = kullanici.Soyadi;
                    txtTelefon.Text = kullanici.Telefon;
                    cbAktif.Checked = kullanici.AktifMi;
                    cbKullaniciRolu.SelectedValue = kullanici.RolId;
                    lblEklenmeTarihi.Text = kullanici.EklenmeTarihi.ToString();
                    lblId.Text = kullanici.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Listeden silenecek kaydı seçiniz!");
                }
                else
                {
                    int kulId = Convert.ToInt32(lblId.Text);
                    var sonuc = manager.Delete(kulId);

                    if (sonuc > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kayıt silindi.");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu! Kayıt silinemedi.");
            }
        }
    }
}
