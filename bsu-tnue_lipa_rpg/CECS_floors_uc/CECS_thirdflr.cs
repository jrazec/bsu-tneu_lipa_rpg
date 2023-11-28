using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.CECS_floors_uc
{
    public partial class CECS_thirdflr : UserControl
    {
        public static CECS_thirdflr instance;
        public CECS_thirdflr()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
