using OtoServisSatis.BL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        KullaniciManager kullaniciManager = new KullaniciManager();
        private void btnGiris_Click(object sender, EventArgs e)
        {

            try
            {
                var kullanici = kullaniciManager.Get(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.AktifMi == true);

                if (kullanici != null)
                {
                    AnaMenu anaMenu = new AnaMenu();
                    anaMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş başarısız!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu!");
            }
            
            
        }
    }
}
