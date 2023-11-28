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
    }
}
