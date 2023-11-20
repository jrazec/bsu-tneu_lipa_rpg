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
    public partial class Gameplay_start : Form
    {
        public Gameplay_start()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure log out your account?", "Log-out", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                Form1.STUDENT_USER_SR_CODE = "";
                this.Hide();
                Log_in logIn = new Log_in();
                logIn.ShowDialog();
                this.Close();
            }
            
            
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_mechanics gMech = new Game_mechanics();
            gMech.ShowDialog();
            this.Close();
        }
    }
}
