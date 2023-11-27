using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.Closet_garments_uc
{
    public partial class shoes : UserControl
    {
        public static shoes instance;
        public shoes()
        {
            InitializeComponent();
            instance = this;
        }

        private void shoes1_pbox_Click(object sender, EventArgs e)
        {
            shoes1_pbox.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
