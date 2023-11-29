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

        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            obcontainer_panel.Controls.Clear();
            obcontainer_panel.Controls.Add(uc);
            uc.Focus();
            uc.BringToFront();
        }
    }
}
