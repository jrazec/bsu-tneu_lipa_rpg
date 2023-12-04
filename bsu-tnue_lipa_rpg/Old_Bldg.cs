using bsu_tnue_lipa_rpg.Menu_options_forms;
using bsu_tnue_lipa_rpg.OB_floors_uc;
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
    public partial class Old_Bldg : Form
    {
        public static Old_Bldg instance;        
        public Old_Bldg()
        {
            InitializeComponent();
            instance = this;
            if (!OB_firstflr.INSTANCE.Visible)
            {
                OB_firstflr.INSTANCE.Show();
                OB_firstflr.INSTANCE.obfirstWalkTimer.Start();
            }
            obcontainer_panel.Controls.Add(OB_firstflr.INSTANCE);
        }

        bool openMenu = false;
        bool openHint = false;

        public bool tasksClicked = false;
        public bool achievsClicked = false;
        public bool returnClicked = false;

        #region menu and hint events
        private void menu_pbox_Click(object sender, EventArgs e)
        {
            if (openMenu == false)
            {
                openMenu = true;
                viewmenu_panel.Visible = true;
                viewmenu_panel.BringToFront();

                if (OB_firstflr.INSTANCE.Visible)
                {
                    OB_firstflr.INSTANCE.obfirstWalkTimer.Stop();
                }
                else if (OB_secondflr.INSTANCE.Visible)
                {
                    OB_secondflr.INSTANCE.obsecondWalkTimer.Stop();
                }
                else if (OB_thirdflr.INSTANCE.Visible)
                {
                    OB_thirdflr.INSTANCE.obthirdWalkTimer.Stop();
                }
                else if (OB_fourthflr.INSTANCE.Visible)
                {
                    OB_fourthflr.INSTANCE.obfourthWalkTimer.Stop();
                }
                else
                {
                    OB_fifthflr.INSTANCE.obfifthWalkTimer.Stop();
                }
            }
            else
            {
                openMenu = false;
                viewmenu_panel.Visible = false;


                if (OB_firstflr.INSTANCE.Visible)
                {
                    OB_firstflr.INSTANCE.obfirstWalkTimer.Start();
                }
                else if (OB_secondflr.INSTANCE.Visible)
                {
                    OB_secondflr.INSTANCE.obsecondWalkTimer.Start();
                }
                else if (OB_thirdflr.INSTANCE.Visible)
                {
                    OB_thirdflr.INSTANCE.obthirdWalkTimer.Start();
                }
                else if (OB_fourthflr.INSTANCE.Visible)
                {
                    OB_fourthflr.INSTANCE.obfourthWalkTimer.Start();
                }
                else
                {
                    OB_fifthflr.INSTANCE.obfifthWalkTimer.Start();
                }
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

        #region
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
        }
        #endregion
    }
}
