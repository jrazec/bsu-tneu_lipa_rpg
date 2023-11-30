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
    public partial class OB_thirdflr : UserControl
    {
        public static OB_thirdflr instance;
        public static OB_thirdflr INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new OB_thirdflr();
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
        public OB_thirdflr()
        {
            InitializeComponent();
            Bedroom.instance.characFront(obthirdflr_charac);
        }

        private void obthirdWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && obthirdflr_charac.Left > 0)
            {
                obthirdflr_charac.Left -= walk;
            }
            if (go_right == true && obthirdflr_charac.Left + obthirdflr_charac.Width < this.ClientSize.Width)
            {
                obthirdflr_charac.Left += walk;
            }
            if (go_up == true && obthirdflr_charac.Top > 175)
            {
                obthirdflr_charac.Top -= walk;
            }
            if (go_down == true && obthirdflr_charac.Top < 390)
            {
                obthirdflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //go up
                if (navigation is PictureBox && (string)navigation.Tag == "go_up")
                {
                    if (obthirdflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        obthirdWalkTimer.Stop();

                        //move character away from collision box
                        obthirdflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //go to fourth floor uc
                        this.Hide();

                        Old_Bldg.instance.obcontainer_panel.Controls.Clear();
                        Old_Bldg.instance.obcontainer_panel.Controls.Add(OB_fourthflr.INSTANCE);

                        OB_fourthflr.INSTANCE.Show();
                        OB_fourthflr.INSTANCE.obfourthWalkTimer.Start();
                        OB_fourthflr.INSTANCE.Focus();
                        OB_fourthflr.INSTANCE.BringToFront();

                    }
                }
                //go down
                if (navigation is PictureBox && (string)navigation.Tag == "go_down")
                {
                    if (obthirdflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        obthirdWalkTimer.Stop();

                        //move character away from collision box
                        obthirdflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //go back to second floor uc
                        this.Hide();

                        Old_Bldg.instance.obcontainer_panel.Controls.Clear();
                        Old_Bldg.instance.obcontainer_panel.Controls.Add(OB_secondflr.INSTANCE);

                        OB_secondflr.INSTANCE.Show();
                        OB_secondflr.INSTANCE.obsecondWalkTimer.Start();
                        OB_secondflr.INSTANCE.Focus();
                        OB_secondflr.INSTANCE.BringToFront();
                    }
                }
            }
        }

        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(obthirdflr_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(obthirdflr_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(obthirdflr_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(obthirdflr_charac);
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
