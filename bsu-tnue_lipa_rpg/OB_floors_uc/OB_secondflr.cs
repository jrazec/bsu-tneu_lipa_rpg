using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    public partial class OB_secondflr : UserControl
    {
        public static OB_secondflr instance;
        public static OB_secondflr INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new OB_secondflr();
                }
                return instance;
            }
        }
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
        readonly int walk = 20;
        public OB_secondflr()
        {
            InitializeComponent();
            Bedroom.instance.characFront(obsecondflr_charac);
        }

        private void obsecondWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && obsecondflr_charac.Left > 0)
            {
                obsecondflr_charac.Left -= walk;
            }
            if (go_right == true && obsecondflr_charac.Left + obsecondflr_charac.Width < this.ClientSize.Width)
            {
                obsecondflr_charac.Left += walk;
            }
            if (go_up == true && obsecondflr_charac.Top > 175)
            {
                obsecondflr_charac.Top -= walk;
            }
            if (go_down == true && obsecondflr_charac.Top < 390)
            {
                obsecondflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //go up
                if (navigation is PictureBox && (string)navigation.Tag == "go_up")
                {
                    if (obsecondflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        obsecondWalkTimer.Stop();

                        //move character away from collision box
                        obsecondflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //go to third floor uc
                        this.Hide();

                        Old_Bldg.instance.obcontainer_panel.Controls.Clear();
                        Old_Bldg.instance.obcontainer_panel.Controls.Add(OB_thirdflr.INSTANCE);

                        OB_thirdflr.INSTANCE.Show();
                        OB_thirdflr.INSTANCE.obthirdWalkTimer.Start();
                        OB_thirdflr.INSTANCE.Focus();
                        OB_thirdflr.INSTANCE.BringToFront();

                    }
                }
                //go down
                if (navigation is PictureBox && (string)navigation.Tag == "go_down")
                {
                    if (obsecondflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        obsecondWalkTimer.Stop();

                        //move character away from collision box
                        obsecondflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //go back to first floor uc
                        this.Hide();

                        Old_Bldg.instance.obcontainer_panel.Controls.Clear();
                        Old_Bldg.instance.obcontainer_panel.Controls.Add(OB_firstflr.INSTANCE);

                        OB_firstflr.INSTANCE.Show();
                        OB_firstflr.INSTANCE.obfirstWalkTimer.Start();
                        OB_firstflr.INSTANCE.Focus();
                        OB_firstflr.INSTANCE.BringToFront();
                    }
                }
            }
        }
        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(obsecondflr_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(obsecondflr_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(obsecondflr_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(obsecondflr_charac);
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
