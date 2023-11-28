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
        CECS_firstflr cecs1 = new CECS_firstflr();
        public CECS_bldg()
        {
            InitializeComponent();
            addUC(cecs1);
        }
        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            cecscontainer_panel.Controls.Clear();
            cecscontainer_panel.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
