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
    public partial class CECS_fourthflr : UserControl
    {
        public static CECS_fourthflr instance;
        public CECS_fourthflr()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
