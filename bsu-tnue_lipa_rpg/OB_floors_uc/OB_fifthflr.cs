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
    public partial class OB_fifthflr : UserControl
    {
        public static OB_fifthflr instance;

        public static OB_fifthflr INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new OB_fifthflr();
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
        public OB_fifthflr()
        {
            InitializeComponent();
            Bedroom.instance.characFront(obfifthflr_charac);
            door1_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door2_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door3_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            engr_dg.BackColor = Color.FromArgb(179, 0, 0, 0);
        }
        private void obfifthWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && obfifthflr_charac.Left > 0)
            {
                obfifthflr_charac.Left -= walk;
            }
            if (go_right == true && obfifthflr_charac.Left + obfifthflr_charac.Width < this.ClientSize.Width)
            {
                obfifthflr_charac.Left += walk;
            }
            if (go_up == true && obfifthflr_charac.Top > 175)
            {
                obfifthflr_charac.Top -= walk;
            }
            if (go_down == true && obfifthflr_charac.Top < 390)
            {
                obfifthflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //go down
                if (navigation is PictureBox && (string)navigation.Tag == "go_down")
                {
                    if (obfifthflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        obfifthWalkTimer.Stop();

                        //move character away from collision box
                        obfifthflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //go back to fourth floor uc
                        this.Hide();

                        Old_Bldg.instance.obcontainer_panel.Controls.Clear();
                        Old_Bldg.instance.obcontainer_panel.Controls.Add(OB_fourthflr.INSTANCE);

                        OB_fourthflr.INSTANCE.Show();
                        OB_fourthflr.INSTANCE.obfourthWalkTimer.Start();
                        OB_fourthflr.INSTANCE.Focus();
                        OB_fourthflr.INSTANCE.BringToFront();
                    }
                }
            }
        }
        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(obfifthflr_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(obfifthflr_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(obfifthflr_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(obfifthflr_charac);
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
