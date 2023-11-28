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
        
        CECS_thirdflr cecs3 = new CECS_thirdflr();
        CECS_fourthflr cecs4 = new CECS_fourthflr();
        CECS_fifthflr cecs5 = new CECS_fifthflr();
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

            cecs3 = CECS_thirdflr.instance;
            cecs3.Show();

            addUC(cecs3);
        }

        private void flr4_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;

            cecs4 = CECS_fourthflr.instance;
            cecs4.Show();

            addUC(cecs4);
        }

        private void flr5_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;

            cecs5 = CECS_fifthflr.instance;
            cecs5.Show();

            addUC(cecs5);
        }
    }
}
