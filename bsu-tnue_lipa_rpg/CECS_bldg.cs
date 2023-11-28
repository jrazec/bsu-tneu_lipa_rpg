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
            cecscontainer_panel.Visible = true;
            
            cecs1 = CECS_firstflr.instance;
            CECS_firstflr.instance.Show();
            CECS_firstflr.instance.cecsfirstWalkTimer.Start();
            addUC(cecs1);

            flr1_pbox.Enabled = false;
            flr2_pbox.Enabled = false;
            flr3_pbox.Enabled = false;
            flr4_pbox.Enabled = false;
            flr5_pbox.Enabled = false;
        }
    }
}
