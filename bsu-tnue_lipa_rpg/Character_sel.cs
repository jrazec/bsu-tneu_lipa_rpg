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
    public partial class Character_sel : Form
    {
        public Character_sel()
        {
            InitializeComponent();
            dg1_pbox.Controls.Add(dg_clicknxt_lbl);
            dg1_pbox.Controls.Add(dg_chracter_sel1);
            dg1_pbox.Location = new Point(0, 0);
            dg1_pbox.BackColor = Color.Transparent;
        }





        private void Character_sel_Load(object sender, EventArgs e)
        {

        }
    }
}
