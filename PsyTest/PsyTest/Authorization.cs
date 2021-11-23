using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsyTest
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        public int idUs;

        private void llRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Hide();
        }

        private void btnComing_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string req = "SELECT COUNT(1) FROM users WHERE login = '" + tbLogin.Text + "' AND password = '" + tbPassword.Text + "'";
            int CounterUser = Convert.ToInt32(db.sqlRequestSELECT(req));
            db.Close();
            if (CounterUser == 1)
            {
                string reqs = "SELECT id FROM users WHERE login = '" + tbLogin.Text + "' AND password = '" + tbPassword.Text + "'";
                idUs = Convert.ToInt32(db.sqlRequestSELECT(reqs));
                db.Close();
                Form1 f = new Form1(idUs);
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Пользователь не найден. Пройдите регистрацию!", "Ошибка");
            }
        }

        private void llAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminWin f = new AdminWin();
            f.Show();
            Hide();
        }
    }
}
