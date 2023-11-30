using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg
{
    public partial class Admin_login : Form
    {
        const string password = "12345";
        const string username = "admin";
        public Admin_login()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in lg = new Log_in();
            lg.ShowDialog();
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(admin_user_txt.Text == username && admin_pass_txt.Text == password)
            {
                MessageBox.Show("Login Success.");
                this.Hide();
                Admin_section ads = new Admin_section();
                ads.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!");
            }
        }

        private void exit_pbox_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure you want to close the program?", "Warning", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                this.Hide();
                Form1 ads = new Form1();
                ads.ShowDialog();
                this.Close();
            }
        }
    }
}
