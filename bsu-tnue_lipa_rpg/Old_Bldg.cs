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
        OB_firstflr ob1 = new OB_firstflr();
        
        public Old_Bldg()
        {
            InitializeComponent();
            instance = this;
            addUC(ob1);
        }

        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            obcontainer_panel.Controls.Clear();
            obcontainer_panel.Controls.Add(uc);
            uc.BringToFront();
        }

        
    }
}
