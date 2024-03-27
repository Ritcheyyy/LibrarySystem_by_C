using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Login_Reader_Click(object sender, EventArgs e)
        {
            Frm_Login_User win_login_user = new Frm_Login_User(this);
            win_login_user.Show();
            this.Hide();
        }

        private void btn_Login_Admin_Click(object sender, EventArgs e)
        {
            Frm_Login_Admin win_login_Admin = new Frm_Login_Admin(this);
            win_login_Admin.Show();
            this.Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Frm_Register win_register = new Frm_Register(this);
            win_register.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
