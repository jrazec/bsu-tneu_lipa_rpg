using bsu_tnue_lipa_rpg.Menu_options_forms;
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
    public partial class Facade : Form
    {
        public static Facade instance;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        bool go_up, go_down, go_left, go_right;
        int walk = 20;
        public Facade()
        {
            InitializeComponent();
            Bedroom.instance.characBack(facade_charac);
            instance = this;
            day_lbl.Text = Bedroom.instance.DAY;

        }
        bool openMenu = false;
        bool openHint = false;

        public bool tasksClicked = false;
        public bool achievsClicked = false;
        public bool returnClicked = false;

        #region menu & hint events
        private void menu_pbox_Click(object sender, EventArgs e)
        {
            if (openMenu == false)
            {
                openMenu = true;
                viewmenu_panel.Visible = true;
                viewmenu_panel.BringToFront();
                facadeWalkTimer.Stop();
            }
            else
            {
                openMenu = false;
                viewmenu_panel.Visible = false;
                facadeWalkTimer.Start();
            }
        }

        private void hint_pbox_Click(object sender, EventArgs e)
        {
            if (openHint == false)
            {
                openHint = true;
                hint_panel.Visible = true;
                hint_panel.BringToFront();
            }
            else
            {
                openHint = false;
                hint_panel.Visible = false;
            }
        }
        #endregion

        #region hover menu events

        private void tasks_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(tasks_lbl);
        }

        private void tasks_hoverout(object sender, EventArgs e)
        {
            if (!tasksClicked)
            {
                Bedroom.instance.hoverReset(tasks_lbl);
            }
            else
            {
                Bedroom.instance.hoverChange(tasks_lbl);
            }
        }

        private void achievs_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(achievs_lbl);
        }

        private void achievs_hoverout(object sender, EventArgs e)
        {
            if (!achievsClicked)
            {
                Bedroom.instance.hoverReset(achievs_lbl);
            }
            else
            {
                Bedroom.instance.hoverChange(achievs_lbl);
            }
        }

        private void return_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(return_label);
        }

        private void return_hoverout(object sender, EventArgs e)
        {
            if (!returnClicked)
            {
                Bedroom.instance.hoverReset(return_label);
            }
            else
            {
                Bedroom.instance.hoverChange(return_label);
            }
        }
        #endregion

        #region click menu events
        private void tasks_lbl_Click(object sender, EventArgs e)
        {
            tasksClicked = true;
            achievsClicked = false;
            returnClicked = false;

            Bedroom.instance.hoverChange(tasks_lbl);
            Bedroom.instance.hoverReset(achievs_lbl);
            Bedroom.instance.hoverReset(return_label);

            Tasks tasks = new Tasks();
            tasks.Show();
        }

        private void achievs_lbl_Click(object sender, EventArgs e)
        {
            achievsClicked = true;
            tasksClicked = false;
            returnClicked = false;

            Bedroom.instance.hoverChange(achievs_lbl);
            Bedroom.instance.hoverReset(tasks_lbl);
            Bedroom.instance.hoverReset(return_label);

            Achievements achievs = new Achievements();
            achievs.Show();
        }

        private void return_label_Click(object sender, EventArgs e)
        {
            returnClicked = true;
            tasksClicked = false;
            achievsClicked = false;

            Bedroom.instance.hoverChange(return_label);
            Bedroom.instance.hoverReset(achievs_lbl);
            Bedroom.instance.hoverReset(tasks_lbl);

            //code to return to main menu
            this.Hide();
            this.Close();
            Gameplay_start gameplay_Start = new Gameplay_start();
            gameplay_Start.ShowDialog();
            CECS_bldg.instance.Close();
            Old_Bldg.instance.Close();
            Map.instance.Close();
            Bedroom.instance.Close();
        }
        #endregion

        private void facadeWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && facade_charac.Left > 0)
            {
                facade_charac.Left -= walk;
            }
            if (go_right == true && facade_charac.Left + facade_charac.Width < this.ClientSize.Width)
            {
                facade_charac.Left += walk;
            }
            if (go_up == true && facade_charac.Top > 46)
            {
                facade_charac.Top -= walk;
            }
            if (go_down == true && facade_charac.Top + facade_charac.Height < this.ClientSize.Height)
            {
                facade_charac.Top += walk;
            }

            //to interact with guard
            foreach (Control interact in this.Controls)
            {
                if (interact is PictureBox && (string)interact.Tag == "interact_w_guard")
                {
                    if (facade_charac.Bounds.IntersectsWith(interact.Bounds))
                    {
                        //stop character movement
                        //facadeWalkTimer.Stop();

                        //move character away from collision box
                        facade_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //code here to initiate dialogue:
                        //
                        //

                        if (Gameplay_start.free)
                        {
                            MessageBox.Show("Its Free day!");
                            Map gotomap = new Map();
                            this.Hide();
                            gotomap.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (Closet.GARMENTS_FOR_DAY[Bedroom.instance.DAY_ID, 0] == Closet.Garments_Worn[0, 0] &&
                            Closet.GARMENTS_FOR_DAY[Bedroom.instance.DAY_ID, 1] == Closet.Garments_Worn[0, 1] &&
                            Closet.GARMENTS_FOR_DAY[Bedroom.instance.DAY_ID, 2] == Closet.Garments_Worn[0, 2] &&
                            Closet.GARMENTS_FOR_DAY[Bedroom.instance.DAY_ID, 3] == Closet.Garments_Worn[0, 3])
                            {
                                //temporary code to go to map
                                //if makapasok
                                Map gotomap = new Map();
                                this.Hide();
                                gotomap.ShowDialog();
                                this.Close();
                                //else balik sa bedroom
                            }
                            else
                            {
                                //Guard saying wrong garments for monday

                                facade_charac.Location = new Point(277, 322);
                                MessageBox.Show("Make sure to wear your proper garments for  today!", "Wear Proper Garments!", MessageBoxButtons.OK);

                            }
                        }
                        
                        
                    }
                }
            }

            //to return home
            foreach (Control gohome in this.Controls)
            {
                if (gohome is PictureBox && (string)gohome.Tag == "return_home")
                {
                    if (facade_charac.Bounds.IntersectsWith(gohome.Bounds))
                    {
                        //stop character movement
                        facadeWalkTimer.Stop();
                        DialogResult sure = MessageBox.Show("Are you sure you want to go to bed? Ur garments will revert..", "Warning", MessageBoxButtons.YesNo);
                        if (sure == DialogResult.Yes) { 


                            //switch to closet form
                            this.Hide();
                            
                            Bedroom returned = new Bedroom();
                            returned.CHARAC_CLOTHES = "BED";
                            Closet.Garments_Worn[0, 0] = "";
                            Closet.Garments_Worn[0, 1] = "";
                            Closet.Garments_Worn[0, 2] = "";
                            Closet.Garments_Worn[0, 3] = "";
                            returned.ShowDialog();
                            this.Close();
                        }
                        else {

                            //reset boolean directions
                            go_left = false;
                            go_right = false;
                            go_up = false;
                            go_down = false;


                            //move character away from collision boxdd
                            facadeWalkTimer.Start();
                            facade_charac.Location = new Point(58, 398);
                            MessageBox.Show("Lakad matatag..");
                            
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
                Bedroom.instance.characLeft(facade_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(facade_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(facade_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(facade_charac);
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
