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
    public partial class top : UserControl
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
        public top()
        {
            InitializeComponent();
        }

        private void top1_pbox_Click(object sender, EventArgs e)
        {
            top1_pbox.BorderStyle = BorderStyle.FixedSingle;
            top2_pbox.BorderStyle = BorderStyle.Fixed3D;
            top3_pbox.BorderStyle = BorderStyle.Fixed3D;
            top4_pbox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void top2_pbox_Click(object sender, EventArgs e)
        {
            top2_pbox.BorderStyle = BorderStyle.FixedSingle;
            top1_pbox.BorderStyle = BorderStyle.Fixed3D;
            top3_pbox.BorderStyle = BorderStyle.Fixed3D;
            top4_pbox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void top3_pbox_Click(object sender, EventArgs e)
        {
            top3_pbox.BorderStyle = BorderStyle.FixedSingle;
            top2_pbox.BorderStyle = BorderStyle.Fixed3D;
            top1_pbox.BorderStyle = BorderStyle.Fixed3D;
            top4_pbox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void top4_pbox_Click(object sender, EventArgs e)
        {
            top4_pbox.BorderStyle = BorderStyle.FixedSingle;
            top2_pbox.BorderStyle = BorderStyle.Fixed3D;
            top3_pbox.BorderStyle = BorderStyle.Fixed3D;
            top1_pbox.BorderStyle = BorderStyle.Fixed3D;

        }
    }
}
