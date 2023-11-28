using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.CECS_floors_uc
{
    public partial class CECS_secondflr : UserControl
    {
        public static CECS_secondflr instance;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        #region FIX: Make arrow keys work inside uc w/o holding ctrl key
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    if (e.Shift)
                    {

                    }
                    else
                    {
                    }
                    break;
            }
        }
        #endregion

        bool go_up, go_down, go_left, go_right;
        int walk = 20;
        public CECS_secondflr()
        {
            InitializeComponent();
            instance = this;
        }
        private void cecssecondWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && cecssecondflr_charac.Left > 0)
            {
                cecssecondflr_charac.Left -= walk;
            }
            if (go_right == true && cecssecondflr_charac.Left + cecssecondflr_charac.Width < this.ClientSize.Width)
            {
                cecssecondflr_charac.Left += walk;
            }
            if (go_up == true && cecssecondflr_charac.Top > 175)
            {
                cecssecondflr_charac.Top -= walk;
            }
            if (go_down == true && cecssecondflr_charac.Top < 354)
            {
                cecssecondflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //go to elevator
                if (navigation is PictureBox && (string)navigation.Tag == "go_to_elev")
                {
                    if (cecssecondflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        cecssecondWalkTimer.Stop();

                        //move character away from collision box
                        cecssecondflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //proceed to elev -- to be debugged
                        CECS_bldg.instance.cecscontainer_panel.Visible = false;
                        //cecssecondWalkTimer.Start();

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
                cecssecondflr_charac.Image = Properties.Resources.female_org_left;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                go_right = true;
                //characRight();
                cecssecondflr_charac.Image = Properties.Resources.female_org_right;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                e.Handled = true;
                go_up = true;
                // characBack();
                cecssecondflr_charac.Image = Properties.Resources.female_org_back;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                e.Handled = true;
                go_down = true;
                //characFront();
                cecssecondflr_charac.Image = Properties.Resources.female_org_front;
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
