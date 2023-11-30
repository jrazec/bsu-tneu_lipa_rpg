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
    public partial class CECS_thirdflr : UserControl
    {
        public static CECS_thirdflr instance;

        public static CECS_thirdflr INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new CECS_thirdflr();
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

        public CECS_thirdflr()
        {
            InitializeComponent();
            Bedroom.instance.characFront(cecsthirdflr_charac);
        }
        private void cecsthirdWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && cecsthirdflr_charac.Left > 0)
            {
                cecsthirdflr_charac.Left -= walk;
            }
            if (go_right == true && cecsthirdflr_charac.Left + cecsthirdflr_charac.Width < this.ClientSize.Width)
            {
                cecsthirdflr_charac.Left += walk;
            }
            if (go_up == true && cecsthirdflr_charac.Top > 175)
            {
                cecsthirdflr_charac.Top -= walk;
            }
            if (go_down == true && cecsthirdflr_charac.Top < 354)
            {
                cecsthirdflr_charac.Top += walk;
            }

            //to navigate
            foreach (Control navigation in this.Controls)
            {
                //go to elevator
                if (navigation is PictureBox && (string)navigation.Tag == "go_to_elev")
                {
                    if (cecsthirdflr_charac.Bounds.IntersectsWith(navigation.Bounds))
                    {
                        //stop character movement
                        cecsthirdWalkTimer.Stop();

                        //move character away from collision box
                        cecsthirdflr_charac.Location = new Point(277, 322);

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
            }
        }
        
        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(cecsthirdflr_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(cecsthirdflr_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(cecsthirdflr_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(cecsthirdflr_charac);
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
