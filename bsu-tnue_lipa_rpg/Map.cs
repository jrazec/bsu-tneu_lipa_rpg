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
        int walk = 10;
        public Map()
        {
            InitializeComponent();
        }

        private void next_pbox_Click(object sender, EventArgs e)
        {
            next_pbox.Visible = false;
            dg_map.Text = "Clue: ...";
            click_lbl.Visible = true;
            click_lbl.Text = "Press to start.";
            enter_lbl.Visible = true;
        }

        private void enter_lbl_Click(object sender, EventArgs e)
        {
            enter_lbl.Visible = false;
            dg_pbox.Visible = false;
            dg_map.Visible = false;
            click_lbl.Visible = false;
            mapWalkTimer.Start();
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

            //to enter bldgs
            foreach (Control bldg in this.Controls)
            {
                //enter cecs building
                if (bldg is PictureBox && (string)bldg.Tag == "cecs")
                {
                    if (map_charac.Bounds.IntersectsWith(bldg.Bounds))
                    {
                        //stop character movement
                        mapWalkTimer.Stop();

                        //move character away from collision box
                        map_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to CECS form
                        this.Hide();
                        //CECS enter_cecs = new CECS();
                        //enter_cecs.ShowDialog();

                    }
                }

                //enter ob building
                if (bldg is PictureBox && (string)bldg.Tag == "ob")
                {
                    if (map_charac.Bounds.IntersectsWith(bldg.Bounds))
                    {
                        //stop character movement
                        mapWalkTimer.Stop();

                        //move character away from collision box
                        map_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to OB form
                        this.Hide();
                        //OB enter_ob = new OB();
                        //enter_ob.ShowDialog();

                    }
                }
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
