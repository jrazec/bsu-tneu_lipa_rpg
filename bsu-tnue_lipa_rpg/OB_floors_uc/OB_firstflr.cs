using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    public partial class OB_firstflr : UserControl
    {
        public static OB_firstflr instance;
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

        public OB_firstflr()
        {
            InitializeComponent();
            instance = this;
        }

        private void obfirstWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && obfirstflr_charac.Left > 0)
            {
                obfirstflr_charac.Left -= walk;
            }
            if (go_right == true && obfirstflr_charac.Left + obfirstflr_charac.Width < this.ClientSize.Width)
            {
                obfirstflr_charac.Left += walk;
            }
            if (go_up == true && obfirstflr_charac.Top > 175)
            {
                obfirstflr_charac.Top -= walk;
            }
            if (go_down == true && obfirstflr_charac.Top < 354)
            {
                obfirstflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //return to map
                if (navigation is PictureBox && (string)navigation.Tag == "go_up")
                {
                    if (obfirstflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        obfirstWalkTimer.Stop();

                        //move character away from collision box
                        obfirstflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //go to second floor uc
                        this.Hide();
                        OB_secondflr ob2 = new OB_secondflr();
                        ob2.Show(); 
                        
                        Old_Bldg.instance.obcontainer_panel.Controls.Clear();
                        Old_Bldg.instance.obcontainer_panel.Controls.Add(ob2);

                        // above code works but character in 2nd flr wont move like cecs 2nd flr and up
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
                obfirstflr_charac.Image = Properties.Resources.female_org_left;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                go_right = true;
                //characRight();
                obfirstflr_charac.Image = Properties.Resources.female_org_right;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                e.Handled = true;
                go_up = true;
                // characBack();
                obfirstflr_charac.Image = Properties.Resources.female_org_back;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                e.Handled = true;
                go_down = true;
                //characFront();
                obfirstflr_charac.Image = Properties.Resources.female_org_front;
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
