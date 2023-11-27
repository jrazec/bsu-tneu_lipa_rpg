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
    public partial class neck : UserControl
    {
        #region FIX : PictureBox Flickering!
        //THIS SOLVED THE PROBLEM HUUHUH FINALYY!!!!!!!!!!
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        #endregion
        public neck()
        {
            InitializeComponent();
        }

        private void neck1_pbox_Click(object sender, EventArgs e)
        {
            neck1_pbox.BorderStyle = BorderStyle.FixedSingle;
            neck2_pbox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void neck2_pbox_Click(object sender, EventArgs e)
        {
            neck2_pbox.BorderStyle = BorderStyle.FixedSingle;
            neck1_pbox.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
