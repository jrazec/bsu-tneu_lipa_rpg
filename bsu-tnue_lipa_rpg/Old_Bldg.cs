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
            Bedroom.instance.hoverReset(tasks_lbl);
        }

        private void achievs_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(achievs_lbl);
        }

        private void achievs_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(achievs_lbl);
        }

        private void return_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(return_label);
        }

        private void return_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(return_label);
        }
        #endregion


    }
}
