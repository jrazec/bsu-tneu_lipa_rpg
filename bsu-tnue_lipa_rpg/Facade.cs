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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
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

            //to interact with guard
            foreach (Control interact in this.Controls)
            {
                if (interact is PictureBox && (string)interact.Tag == "interact_w_guard")
                {
                    if (facade_charac.Bounds.IntersectsWith(interact.Bounds))
                    {
                        //stop character movement
                        //facadeWalkTimer.Stop();

                        //move character away from collision box
                        facade_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //code here to initiate dialogue:
                        //
                        //

                        //temporary code to go to map
                        //if makapasok
                        Map gotomap = new Map();
                        this.Hide();
                        gotomap.ShowDialog();
                        this.Close();
                        //else balik sa bedroom
                        
                        
                    }
                }
            }

            //to return home
            foreach (Control gohome in this.Controls)
            {
                if (gohome is PictureBox && (string)gohome.Tag == "return_home")
                {
                    if (facade_charac.Bounds.IntersectsWith(gohome.Bounds))
                    {
                        //stop character movement
                        facadeWalkTimer.Stop();

                        //move character away from collision box
                        facade_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to closet form
                        this.Hide();
                        Bedroom returned = new Bedroom();
                        returned.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                facade_charac.Image = Properties.Resources.male_uni_left;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                facade_charac.Image = Properties.Resources.male_uni_right;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                facade_charac.Image = Properties.Resources.male_uni_back;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                facade_charac.Image = Properties.Resources.male_uni_front;
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
