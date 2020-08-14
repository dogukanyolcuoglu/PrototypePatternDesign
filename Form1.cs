using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PrototypePattern
{
    public partial class Form1 : Form
    {
        List<string> isim = new List<string>();
        List<int> yas = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            lblOyun1.Text = string.Empty;
            lblOyun2.Text = string.Empty;

        }

        private void btnUrunAnahtari_Click(object sender, EventArgs e)
        {
            listOyun1.Items.Clear();
            listOyun2.Items.Clear();
            int sinir = Convert.ToInt32(comboBox1.SelectedItem);

            PrototipOyun po = new Oyun1(txtOyun1.Text)
            {
                UrunAnahtari = "00000-00000-00000-00000"
            };
            PrototipOyun po2 = new Oyun2(txtOyun2.Text)
            {
                UrunAnahtari = "00000-00000-00000-00000"
            };
            PrototipOyun kopya;

            if(txtOyun1.Text == string.Empty || txtOyun2.Text == string.Empty || comboBox1.Text == string.Empty )
            {
                MessageBox.Show("Boş Alanları Giriniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Ürün Anahtarlarınız Oluşturuluyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i <sinir ; i++)
                {
                    Thread.Sleep(2000);
                    kopya = po.Clone();
                    kopya.UrunAnahtari = PrototipOyun.UrunAnahtariUretim();

                    lblOyun1.Text = kopya.Baslik + " Ürün Anahtarı"+"("+sinir+"):";

                    listOyun1.Items.Add(kopya.UrunAnahtari);

                    Thread.Sleep(2000);
                    kopya = po2.Clone();
                    kopya.UrunAnahtari = PrototipOyun.UrunAnahtariUretim();

                    lblOyun2.Text = kopya.Baslik + " Ürün Anahtarı" + "(" +sinir+ "):";

                    listOyun2.Items.Add(kopya.UrunAnahtari);

                }
                MessageBox.Show("Ürün Anahtarlarınız Hazır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listOyun1.Items.Clear();
            listOyun2.Items.Clear();
            comboBox1.Text = string.Empty;
            lblOyun1.Text = string.Empty;
            lblOyun2.Text = string.Empty;
            txtOyun1.Text = string.Empty;
            txtOyun2.Text = string.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x,MousePosition.Y-mouse_y);
            }

        }
    }
}
