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
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }

        MarkaManager manager = new MarkaManager();

        void Yukle()
        {
            dgvMarkalar.DataSource = manager.GetAll();
        }

        void Temizle()
        {
            lblId.Text = "0";
            txtMarkaAdi.Text = string.Empty;
        }


        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
                txtMarkaAdi.Text = dgvMarkalar.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var marka = manager.Get(int.Parse(lblId.Text));

                    int islemSonucu = manager.Delete(marka);
                    

                    if(islemSonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Marka başarıyla silindi.");
                    }

                }
                else MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!");



            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu! Kayıt silinemedi.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = manager.Add(
                    new Marka
                    {
                    Adi = txtMarkaAdi.Text

                });

                if (islemSonucu > 0)
                {
                    Yukle();
                    Temizle();
                    MessageBox.Show("Marka başarıyla eklendi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Kayıt eklenemedi!");
                
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    int islemSonucu = manager.Update(
                    new Marka
                    {
                        Id = int.Parse(lblId.Text),
                        Adi = txtMarkaAdi.Text

                    });

                    if (islemSonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Marka başarıyla güncellendi.");
                    }
                }
                else
                {
                    MessageBox.Show("Listeden güncellemek istediğiniz kaydı seçiniz!");
                }
                
                
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Kayıt güncellenemedi!");

            }
        }
    }
}
