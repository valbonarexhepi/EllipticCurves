using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIEK_ECC;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHA256CryptoServiceProvider sh256 = new SHA256CryptoServiceProvider();

            // Krijimi i dy instancave per komunikim Alice/Bob
            FIEK_ELLIPTIC_CURVE f1 = new FIEK_ELLIPTIC_CURVE();
            FIEK_ELLIPTIC_CURVE f2 = new FIEK_ELLIPTIC_CURVE();

            rtb_Public_1.Text = Convert.ToBase64String(f1.PublicKey);
            rtb_Public_2.Text = Convert.ToBase64String(f2.PublicKey);

            label7.Text = Convert.ToBase64String(sh256.ComputeHash(Convert.FromBase64String(rtb_Public_1.Text)));
            label8.Text = Convert.ToBase64String(sh256.ComputeHash(Convert.FromBase64String(rtb_Public_2.Text)));

            string[] ret = f1.Encrypt(f2.PublicKey, rtb_Plain_1.Text);
            rtb_Cipher_1.Text = ret[0];
            rtb_Cipher_2.Text = ret[0];

            string msg = f2.Decrypt(f1.PublicKey, Convert.FromBase64String(ret[1]), Convert.FromBase64String(ret[0]));
            rtb_Plain_2.Text = msg;

            // Testimi permes krijimit te nje instance te re (pales se trete)
             FIEK_ELLIPTIC_CURVE f3 = new FIEK_ELLIPTIC_CURVE();
            /* string msg2 = f3.Decrypt(f1.PublicKey, Convert.FromBase64String(ret[1]), Convert.FromBase64String(ret[0]));
             MessageBox.Show(msg2); */

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rtb_Public_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
