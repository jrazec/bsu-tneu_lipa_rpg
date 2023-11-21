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
    public partial class Facade : Form
    {
        bool go_up, go_down, go_left, go_right;
        int walk = 20;
        public Facade()
        {
            InitializeComponent();
        }

        private void facadeWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && facade_charac.Left > 0)
            {
                facade_charac.Left -= walk;
            }
            if (go_right == true && facade_charac.Left + facade_charac.Width < this.ClientSize.Width)
            {
                facade_charac.Left += walk;
            }
            if (go_up == true && facade_charac.Top > 46)
            {
                facade_charac.Top -= walk;
            }
            if (go_down == true && facade_charac.Top + facade_charac.Height < this.ClientSize.Height)
            {
                facade_charac.Top += walk;
            }
        }

        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                facade_charac.Image = Properties.Resources.male_casual_left;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                facade_charac.Image = Properties.Resources.male_casual_right;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                facade_charac.Image = Properties.Resources.male_casual_back;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                facade_charac.Image = Properties.Resources.male_casual_front;
            }
        }

        private void key_is_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = false;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = false;
            }
        }
    }
}
