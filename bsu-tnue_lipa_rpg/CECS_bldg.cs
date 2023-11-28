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
        CECS_firstflr cecs1 = new CECS_firstflr();
        CECS_secondflr cecs2 = new CECS_secondflr();
        CECS_thirdflr cecs3 = new CECS_thirdflr();
        CECS_fourthflr cecs4 = new CECS_fourthflr();
        CECS_fifthflr cecs5 = new CECS_fifthflr();
        public CECS_bldg()
        {
            InitializeComponent();
            instance = this;
            addUC(cecs1);
        }
        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            cecscontainer_panel.Controls.Clear();
            cecscontainer_panel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void flr1_pbox_Click(object sender, EventArgs e)
        {
            //to be fixed
            cecscontainer_panel.Visible = true;
            
            cecs1 = CECS_firstflr.instance;
            cecs1.Show();
            cecs1.cecsfirstWalkTimer.Start();
            addUC(cecs1);

            flr1_pbox.Enabled = false;
            flr2_pbox.Enabled = false;
            flr3_pbox.Enabled = false;
            flr4_pbox.Enabled = false;
            flr5_pbox.Enabled = false;
        }

        private void flr2_pbox_Click(object sender, EventArgs e)
        {
            cecscontainer_panel.Visible = true;

            cecs2 = CECS_secondflr.instance;
            cecs2.Show();

            addUC(cecs2);

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
