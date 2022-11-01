using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string kullaniciAdi;
        string sifre;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi == "Ber00ka" && sifre == "8520" )
            {
                MessageBox.Show("Welcome");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("The user or password you entered is incorrect!");
            }
        }

        private void txbId_TextChanged(object sender, EventArgs e)
        {
            kullaniciAdi = txbId.Text;
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            sifre = txbPassword.Text;
            txbPassword.PasswordChar = '*';
        }
    }
}
