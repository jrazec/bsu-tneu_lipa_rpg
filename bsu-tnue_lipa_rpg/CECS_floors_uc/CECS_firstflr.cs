using bsu_tnue_lipa_rpg.Closet_garments_uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        public static CECS_firstflr INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new CECS_firstflr(); 
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
        
        public CECS_firstflr()
        {
            InitializeComponent();
            Bedroom.instance.characFront(cecsfirstflr_charac);
            door1_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door2_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            door3_panel.BackColor = Color.FromArgb(180, 128, 0, 0);
            atty_dg.BackColor = Color.FromArgb(179, 0, 0, 0);
        }

        private void cecsfirstWalkTimer_Tick(object sender, EventArgs e)
        {
            //cecsfirstWalkTimer.Start();
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
                        Map returntomap = Map.instance;
                        returntomap.mapWalkTimer.Start();
                        returntomap.Show();
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

                        //proceed to elev
                        this.Hide();
                        CECS_bldg.instance.cecscontainer_panel.Visible = false;
                    }
                }

                if (atty_pbox.Enabled)
                {
                    //Atty. Alvin
                    if (navigation is PictureBox && (string)navigation.Tag == "atty")
                    {
                        if (cecsfirstflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                        {
                            //stop character movement


                            //reset boolean directions
                            go_left = false;
                            go_right = false;
                            go_up = false;
                            go_down = false;

                            //move character away from collision box
                            cecsfirstflr_charac.Location = new Point(59, 148);

                            //proceed to elev
                            dg_pbox.Visible = true;
                            atty_dg.Visible = true;
                            atty_dg.BringToFront();

                            door1_panel.Visible = true;
                            door2_panel.Visible = true;
                            door3_panel.Visible = true;
                            success_registrar.Enabled = true;
                            success_registrar.Visible = true;
                            click_lbl.Visible = true;
                        }
                    }
                }

                if (success_registrar.Enabled)
                {
                    //going to chpater end part
                    if (navigation is PictureBox && (string)navigation.Tag == "regis")
                    {
                        if (cecsfirstflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                        {
                            //stop character movement
                            cecsfirstWalkTimer.Stop();

                            //move character away from collision box
                            cecsfirstflr_charac.Location = new Point(1259, 228);

                            //reset boolean directions
                            go_left = false;
                            go_right = false;
                            go_up = false;
                            go_down = false;

                            this.Hide();
                            CECS_bldg.instance.Hide();
                            CECS_bldg.instance.Close();
                            Chapter_End cE = new Chapter_End();
                            cE.ShowDialog();
                        }
                    }
                }
            }
        }

        private void success_registrar_Click(object sender, EventArgs e)
        {

        }

        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(cecsfirstflr_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(cecsfirstflr_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(cecsfirstflr_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(cecsfirstflr_charac);
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
