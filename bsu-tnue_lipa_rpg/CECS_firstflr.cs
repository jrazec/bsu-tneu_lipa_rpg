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
    public partial class CECS_firstflr : UserControl
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
        
        public CECS_firstflr()
        {
            InitializeComponent();
        }

        private void cecsfirstWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && cecsfirstflr_charac.Left > 149)
            {
                cecsfirstflr_charac.Left -= walk;
            }
            if (go_right == true && cecsfirstflr_charac.Left + cecsfirstflr_charac.Width < this.ClientSize.Width)
            {
                cecsfirstflr_charac.Left += walk;
            }
            if (go_up == true && cecsfirstflr_charac.Top > 46)
            {
                cecsfirstflr_charac.Top -= walk;
            }
            if (go_down == true && cecsfirstflr_charac.Top + cecsfirstflr_charac.Height < this.ClientSize.Height)
            {
                cecsfirstflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                if (navigation is PictureBox && (string)navigation.Tag == "return_to_map")
                {
                    if (cecsfirstflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        cecsfirstWalkTimer.Stop();

                        //move character away from collision box
                        cecsfirstflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //return to map form
                        this.Hide();
                        Map returntomap = new Map();
                        returntomap.ShowDialog();
                        CECS_bldg.instance.Close();

                    }
                }

                if (navigation is PictureBox && (string)navigation.Tag == "go_to_elev")
                {
                    if (cecsfirstflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        cecsfirstWalkTimer.Stop();

                        //move character away from collision box
                        cecsfirstflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //proceed to elev
                        CECS_bldg.instance.cecscontainer_panel.Visible = false;
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
                //characLeft();
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                go_right = true;
                //characRight();
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                e.Handled = true;
                go_up = true;
               // characBack();
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                e.Handled = true;
                go_down = true;
                //characFront();
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
