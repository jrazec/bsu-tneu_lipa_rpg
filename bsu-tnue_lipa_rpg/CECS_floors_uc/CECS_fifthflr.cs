using bsu_tnue_lipa_rpg.Closet_garments_uc;
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
    public partial class CECS_fifthflr : UserControl
    {
        public static CECS_fifthflr instance;
        public static CECS_fifthflr INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new CECS_fifthflr();
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
        public CECS_fifthflr()
        {
            InitializeComponent();
            Bedroom.instance.characFront(cecsfifthflr_charac);
            door1_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door2_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door3_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            dr_dg.BackColor = Color.FromArgb(179, 0, 0, 0);
        }

        private void cecsfifthWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && cecsfifthflr_charac.Left > 0)
            {
                cecsfifthflr_charac.Left -= walk;
            }
            if (go_right == true && cecsfifthflr_charac.Left + cecsfifthflr_charac.Width < this.ClientSize.Width)
            {
                cecsfifthflr_charac.Left += walk;
            }
            if (go_up == true && cecsfifthflr_charac.Top > 175)
            {
                cecsfifthflr_charac.Top -= walk;
            }
            if (go_down == true && cecsfifthflr_charac.Top < 354)
            {
                cecsfifthflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //go to elevator
                if (navigation is PictureBox && (string)navigation.Tag == "go_to_elev")
                {
                    if (cecsfifthflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        cecsfifthWalkTimer.Stop();

                        //move character away from collision box
                        cecsfifthflr_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //proceed to elev
                        this.Hide();
                        CECS_bldg.instance.cecscontainer_panel.Visible = false;
                    }
                }

                if (drbalazon_pbox.Enabled)
                {
                    //Dr Balazon
                    if (navigation is PictureBox && (string)navigation.Tag == "dr")
                    {
                        if (cecsfifthflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                        {
                            //stop character movement
                            cecsfifthWalkTimer.Stop();

                            //move character away from collision box
                            cecsfifthflr_charac.Location = new Point(364, 166);

                            //reset boolean directions
                            go_left = false;
                            go_right = false;
                            go_up = false;
                            go_down = false;

                            //proceed to elev
                            padayon_btn.Visible = true;
                            padayon_btn.Enabled = true;
                            dg_pbox.Visible = true;
                            dr_dg.Visible = true;
                            dr_dg.BringToFront();
                        }
                    }
                }
            }
        }

        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(cecsfifthflr_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(cecsfifthflr_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(cecsfifthflr_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(cecsfifthflr_charac);
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

        private void padayon_btn_Click(object sender, EventArgs e)
        {
            door1_panel.Visible = true;
            door2_panel.Visible = true;
            door3_panel.Visible = true;
            success_door.Enabled = true;
            success_door.Visible = true;
            click_lbl.Visible = true;
        }

        private void success_door_Click(object sender, EventArgs e)
        {
            this.Hide();
            CECS_bldg.instance.Hide();
            CECS_bldg.instance.Close();
            Chapter_End cE = new Chapter_End();
            cE.ShowDialog();
        }
    }
}
