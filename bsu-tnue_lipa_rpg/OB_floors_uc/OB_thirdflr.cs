using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    public partial class OB_thirdflr : UserControl
    {
        public static OB_thirdflr instance;
        public OB_thirdflr()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
