using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int rSayi;
        byte hak = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rSayi = rnd.Next(1, 101); // 1-100 arasında sayı oluşturuluyor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahminSayisi = Convert.ToInt32(textBox1.Text); // Tahminin bir TextBox'tan alınması

            if (rSayi == tahminSayisi)
            {
                MessageBox.Show("Bildiniz Tebrikler", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false; // Doğru tahmin yapıldığında buton devre dışı bırakılıyor
            }
            else
            {
                hak--;
                label2.Text = "Kalan Hakkınız: " + hak;

                if (hak == 0)
                {
                    MessageBox.Show("Üzgünüm, hakkınız bitti. Doğru sayı: " + rSayi, "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Enabled = false; // Haklar bitince buton devre dışı bırakılıyor
                }
                else
                {
                    MessageBox.Show("Bilemediniz, tekrar deneyin.", "Tekrar Deneyin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }  
}
