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
    public partial class bottom : UserControl
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

        public static bottom instance;
        public bottom()
        {
            InitializeComponent();
            instance = this;
        }

        private void bottom1_pbox_Click(object sender, EventArgs e)
        {
            bottom1_pbox.BorderStyle = BorderStyle.FixedSingle;
            bottom2_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom3_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom4_pbox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bottom2_pbox_Click(object sender, EventArgs e)
        {
            bottom2_pbox.BorderStyle = BorderStyle.FixedSingle;
            bottom1_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom3_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom4_pbox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bottom3_pbox_Click(object sender, EventArgs e)
        {
            bottom3_pbox.BorderStyle = BorderStyle.FixedSingle;
            bottom2_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom1_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom4_pbox.BorderStyle = BorderStyle.Fixed3D;
        }
        
        private void bottom4_pbox_Click(object sender, EventArgs e)
        {
            bottom4_pbox.BorderStyle = BorderStyle.FixedSingle;
            bottom2_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom3_pbox.BorderStyle = BorderStyle.Fixed3D;
            bottom1_pbox.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
