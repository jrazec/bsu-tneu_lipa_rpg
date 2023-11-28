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
        public static CECS_firstflr instance;
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
        
        public CECS_firstflr()
        {
            InitializeComponent();
            instance = this;
            cecsfirstWalkTimer.Start();
            //this.Focus();
            //this.KeyDown += key_is_down;
            //this.KeyUp += key_is_up;
            //this.TabStop = true;
            //this.Enter += (sender, e) => this.Focus();

        }

        private void cecsfirstWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && cecsfirstflr_charac.Left > 0)
            {
                cecsfirstflr_charac.Left -= walk;
            }
            if (go_right == true && cecsfirstflr_charac.Left + cecsfirstflr_charac.Width < this.ClientSize.Width)
            {
                cecsfirstflr_charac.Left += walk;
            }
            if (go_up == true && cecsfirstflr_charac.Top > 175)
            {
                cecsfirstflr_charac.Top -= walk;
            }
            if (go_down == true && cecsfirstflr_charac.Top < 354)
            {
                cecsfirstflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //return to map
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
                        CECS_bldg.instance.Hide();
                        CECS_bldg.instance.Close();
                        Map returntomap = new Map();
                        returntomap.ShowDialog();
                       

                    }
                }

                //go to elevator
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

                        //proceed to elev -- to be fixed
                        this.Hide();
                        CECS_bldg.instance.cecscontainer_panel.Visible = false;
                        //cecsfirstWalkTimer.Enabled = true;
                        //cecsfirstWalkTimer.Start();
                        
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
                cecsfirstflr_charac.Image = Properties.Resources.female_org_left;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                go_right = true;
                //characRight();
                cecsfirstflr_charac.Image = Properties.Resources.female_org_right;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                e.Handled = true;
                go_up = true;
                // characBack();
                cecsfirstflr_charac.Image = Properties.Resources.female_org_back;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                e.Handled = true;
                go_down = true;
                //characFront();
                cecsfirstflr_charac.Image = Properties.Resources.female_org_front;
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
