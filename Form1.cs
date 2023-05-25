using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Gboy, Gkilo, bki = 0;

            Gboy = Convert.ToDouble(boy.Text);
            Gkilo = Convert.ToDouble(kilo.Text);

            bki = Gkilo / (Gboy*Gboy);


            if (bki < 18)
            {
                sonuc.Text = "İdeal Kilonun Altındasınız!";
                sonuc.ForeColor = Color.White;
                sonuc.BackColor = Color.Red;
                vki.Text = bki.ToString();
                vki.ForeColor = Color.White;
            }
            else if (bki > 18 && bki < 25)
            {
                sonuc.Text = "İdeal Kilodasınız!";
                sonuc.ForeColor = Color.White;
                sonuc.BackColor = Color.Green;
                vki.Text = bki.ToString();
                vki.ForeColor = Color.White;
            }
            else if (bki > 25 && bki < 30)
            {
                sonuc.Text = "İdeal Kilonun Üstündesiniz!";
                sonuc.ForeColor = Color.White;
                sonuc.BackColor = Color.Orange;
                vki.Text = bki.ToString();
                vki.ForeColor = Color.White;
            }
            else if (bki > 30 && bki < 40)
            {
                sonuc.Text = "İdeal Kilonun Çok Üstündesiniz(OBEZ)!";
                sonuc.ForeColor = Color.White;
                sonuc.BackColor = Color.Red;
                vki.Text = bki.ToString();
                vki.ForeColor = Color.White;
            }
            else
            {
                sonuc.Text = "İdeal Kilonun Çok Üstündesiniz(MORBİD OBEZ)!";
                sonuc.ForeColor = Color.White;
                sonuc.BackColor = Color.Red;
                vki.Text = bki.ToString();
                vki.ForeColor = Color.White;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {   
                if ((int)e.KeyChar == 44)
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }

        }

        private void kilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                if ((int)e.KeyChar == 44)
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }

        }
    }
}
    