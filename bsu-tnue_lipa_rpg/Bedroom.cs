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
    public partial class Bedroom : Form
    {
        bool go_up, go_down, go_left, go_right;
        int walk = 20;
        public Bedroom()
        {
            InitializeComponent();
        }

        //initiate character movement in the bedroom
        private void bedroomWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && bedroom_charac.Left > 149)
            {
                bedroom_charac.Left -= walk;
            }
            if (go_right == true && bedroom_charac.Left < 897)
            {
                bedroom_charac.Left += walk;
            }
            if (go_up == true && bedroom_charac.Top > 46)
            {
                bedroom_charac.Top -= walk;
            }
            if (go_down == true && bedroom_charac.Top + bedroom_charac.Height < this.ClientSize.Height)
            {
                bedroom_charac.Top += walk;
            }

            //to open closet
            foreach (Control closet in this.Controls)
            {
                if (closet is PictureBox && (string)closet.Tag == "closet_open")
                {
                    if (bedroom_charac.Bounds.IntersectsWith(closet.Bounds))
                    {
                        //stop character movement
                        bedroomWalkTimer.Stop();

                        //move character away from collision box
                        bedroom_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to closet form
                        this.Hide();
                        Closet opened_closet = new Closet();
                        opened_closet.ShowDialog();
                        this.Close();
                    }
                }
            }

            //to go out
            foreach (Control door in this.Controls)
            {
                if (door is PictureBox && (string)door.Tag == "go_outside")
                {
                    if (bedroom_charac.Bounds.IntersectsWith(door.Bounds))
                    {
                        //stop character movement
                        bedroomWalkTimer.Stop();

                        //move character away from collision box
                        bedroom_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to closet form
                        this.Hide();
                        Facade to_facade = new Facade();
                        to_facade.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        //navigation button events
        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                bedroom_charac.Image = Properties.Resources.male_casual_left;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                bedroom_charac.Image = Properties.Resources.male_casual_right;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                bedroom_charac.Image = Properties.Resources.male_casual_back;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                bedroom_charac.Image = Properties.Resources.male_casual_front;
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
