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
    public partial class CECS_fourthflr : UserControl
    {
        public static CECS_fourthflr INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new CECS_fourthflr();
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
        int walk = 20;

        public static CECS_fourthflr instance;
        public CECS_fourthflr()
        {
            InitializeComponent();
            Bedroom.instance.characFront(cecsfourthflr_charac);
            Bedroom.instance.characLeft(cecsfourthflr_charac);
            Bedroom.instance.characBack(cecsfourthflr_charac);
            Bedroom.instance.characRight(cecsfourthflr_charac);
            door1_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door2_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door3_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            sir_dg.BackColor = Color.FromArgb(179, 0, 0, 0);
        }


        private void cecsfourthWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && cecsfourthflr_charac.Left > 0)
            {
                cecsfourthflr_charac.Left -= walk;
            }
            if (go_right == true && cecsfourthflr_charac.Left + cecsfourthflr_charac.Width < this.ClientSize.Width)
            {
                cecsfourthflr_charac.Left += walk;
            }
            if (go_up == true && cecsfourthflr_charac.Top > 175)
            {
                cecsfourthflr_charac.Top -= walk;
            }
            if (go_down == true && cecsfourthflr_charac.Top < 354)
            {
                cecsfourthflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //go to elevator
                if (navigation is PictureBox && (string)navigation.Tag == "go_to_elev")
                {
                    if (cecsfourthflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        cecsfourthWalkTimer.Stop();

                        //move character away from collision box
                        cecsfourthflr_charac.Location = new Point(73, 267);

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
                if (sirtiquio_pbox.Enabled)
                {
                    if (navigation is PictureBox && (string)navigation.Tag == "sir")
                    {
                        if (cecsfourthflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                        {
                            //stop character movement
                            cecsfourthWalkTimer.Stop();

                            //move character away from collision box
                            cecsfourthflr_charac.Location = new Point(878, 174);

                            //reset boolean directions
                            go_left = false;
                            go_right = false;
                            go_up = false;
                            go_down = false;

                            //proceed to elev
                            padayon_btn.Visible = true;
                            padayon_btn.Enabled = true;
                            dg_pbox.Visible = true;
                            sir_dg.Visible = true;
                            sir_dg.BringToFront();
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
                Bedroom.instance.characLeft(cecsfourthflr_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(cecsfourthflr_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(cecsfourthflr_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(cecsfourthflr_charac);
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

        private void door_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void sirtiquio_pbox_Click(object sender, EventArgs e)
        {

        }
    }
}

