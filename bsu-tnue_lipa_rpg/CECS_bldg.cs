using bsu_tnue_lipa_rpg.CECS_floors_uc;
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
    public partial class CECS_bldg : Form
    {
        public static CECS_bldg instance;
        public CECS_bldg()
        {
            InitializeComponent();
            instance = this;

            if (!CECS_firstflr.INSTANCE.Visible)
            {
                CECS_firstflr.INSTANCE.Show();
                CECS_firstflr.INSTANCE.cecsfirstWalkTimer.Start();
            }
            cecscontainer_panel.Controls.Add(CECS_firstflr.INSTANCE);
            
        }

        bool openMenu = false;
        bool openHint = false;

        #region menu and hint events
        private void menu_pbox_Click(object sender, EventArgs e)
        {

            if (openMenu == false)
            {
                openMenu = true;
                viewmenu_panel.Visible = true;
                viewmenu_panel.BringToFront();

                if (CECS_firstflr.INSTANCE.Visible)
                {
                    CECS_firstflr.INSTANCE.cecsfirstWalkTimer.Stop();
                }
                else if (CECS_secondflr.INSTANCE.Visible)
                {
                    CECS_secondflr.INSTANCE.cecssecondWalkTimer.Stop();
                }
                else if (CECS_thirdflr.INSTANCE.Visible)
                {
                    CECS_thirdflr.INSTANCE.cecsthirdWalkTimer.Stop();
                }
                else if (CECS_fourthflr.INSTANCE.Visible)
                {
                    CECS_fourthflr.INSTANCE.cecsfourthWalkTimer.Stop();
                }
                else
                {
                    CECS_fifthflr.INSTANCE.cecsfifthWalkTimer.Stop();
                }
            }
            else
            {
                openMenu = false;
                viewmenu_panel.Visible = false;


                if (CECS_firstflr.INSTANCE.Visible)
                {
                    CECS_firstflr.INSTANCE.cecsfirstWalkTimer.Start();
                }
                else if (CECS_secondflr.INSTANCE.Visible)
                {
                    CECS_secondflr.INSTANCE.cecssecondWalkTimer.Start();
                }
                else if (CECS_thirdflr.INSTANCE.Visible)
                {
                    CECS_thirdflr.INSTANCE.cecsthirdWalkTimer.Start();
                }
                else if (CECS_fourthflr.INSTANCE.Visible)
                {
                    CECS_fourthflr.INSTANCE.cecsfourthWalkTimer.Start();
                }
                else
                {
                    CECS_fifthflr.INSTANCE.cecsfifthWalkTimer.Start();
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
            Bedroom.instance.hoverChange(tasks_panel, tasks_lbl);
        }

        private void tasks_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(tasks_panel, tasks_lbl);
        }

        private void achievs_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(achievs_panel, achievs_lbl);
        }

        private void achievs_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(achievs_panel, achievs_lbl);
        }

        private void return_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(return_panel, return_label);
        }

        private void return_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(return_panel, return_label);
        }

        #endregion
        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            cecscontainer_panel.Controls.Clear();
            cecscontainer_panel.Controls.Add(uc);
            uc.Focus();
            uc.BringToFront();
        }

        private void flr1_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;
            cecscontainer_panel.BringToFront();

            CECS_firstflr.INSTANCE.Show();
            CECS_firstflr.INSTANCE.cecsfirstWalkTimer.Start();
            addUC(CECS_firstflr.INSTANCE);     
        }

        private void flr2_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;
            cecscontainer_panel.BringToFront();

            CECS_secondflr.INSTANCE.Show();
            CECS_secondflr.INSTANCE.cecssecondWalkTimer.Start();
            addUC(CECS_secondflr.INSTANCE);
        }

        private void flr3_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;
            cecscontainer_panel.BringToFront();

            CECS_thirdflr.INSTANCE.Show();
            CECS_thirdflr.INSTANCE.cecsthirdWalkTimer.Start();
            addUC(CECS_thirdflr.INSTANCE);
        }

        private void flr4_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;
            cecscontainer_panel.BringToFront();

            CECS_fourthflr.INSTANCE.Show();
            CECS_fourthflr.INSTANCE.cecsfourthWalkTimer.Start();
            addUC(CECS_fourthflr.INSTANCE);
        }

        private void flr5_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;
            cecscontainer_panel.BringToFront();

            CECS_fifthflr.INSTANCE.Show();
            CECS_fifthflr.INSTANCE.cecsfifthWalkTimer.Start();
            addUC(CECS_fifthflr.INSTANCE);
        }


    }
}
