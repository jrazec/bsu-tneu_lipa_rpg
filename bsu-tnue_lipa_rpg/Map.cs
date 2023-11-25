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
    public partial class Map : Form
    {
        bool go_up, go_down, go_left, go_right;
        int walk = 20;
        public Map()
        {
            InitializeComponent();
        }

        private void mapWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && map_charac.Left > 149)
            {
                map_charac.Left -= walk;
            }
            if (go_right == true && map_charac.Left + map_charac.Width < this.ClientSize.Width)
            {
                map_charac.Left += walk;
            }
            if (go_up == true && map_charac.Top > 46)
            {
                map_charac.Top -= walk;
            }
            if (go_down == true && map_charac.Top + map_charac.Height < this.ClientSize.Height)
            {
                map_charac.Top += walk;
            }
        }

        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                e.Handled = true;
                go_left = true;
                map_charac.Image = Properties.Resources.male_uni_left;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                go_right = true;
                map_charac.Image = Properties.Resources.male_uni_right;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                e.Handled = true;
                go_up = true;
                map_charac.Image = Properties.Resources.male_uni_back;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                e.Handled = true;
                go_down = true;
                map_charac.Image = Properties.Resources.male_uni_front;
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
