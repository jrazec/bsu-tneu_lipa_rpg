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
    public partial class OB_firstflr : UserControl
    {
        public static OB_firstflr instance;
        public OB_firstflr()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
