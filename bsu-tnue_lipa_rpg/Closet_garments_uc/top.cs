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

        public static top instance;
        public top()
        {
            InitializeComponent();
            instance = this;
            Bedroom.instance.checkCharac();
            if (Bedroom.instance.CHARAC_ID == 1)
            {
                top1_pbox.Image = Properties.Resources.CICS_Org_Shirt;
                top2_pbox.Image = Properties.Resources.College_Barong;
                top3_pbox.Image = Properties.Resources.PE_T_Shirt;
                top4_pbox.Image = Properties.Resources.Civilian_Top_2;
            }
            else
            {
                top1_pbox.Image = Properties.Resources.CICS_Org_Shirt;
                top2_pbox.Image = Properties.Resources.College_Blouse;
                top3_pbox.Image = Properties.Resources.Civilian_Top_1;
                top4_pbox.Image = Properties.Resources.PE_T_Shirt;
            }
        }
        public bool top1_sel = false;
        public bool top2_sel = false;
        public bool top3_sel = false;
        public bool top4_sel = false;
        private void top1_pbox_Click(object sender, EventArgs e)
        {
            if(top1_sel == false)
            {
                top1_sel = true;
                top2_sel = false;
                top3_sel = false;
                top4_sel = false;
                top1_pbox.BorderStyle = BorderStyle.FixedSingle;
                top2_pbox.BorderStyle = BorderStyle.Fixed3D;
                top3_pbox.BorderStyle = BorderStyle.Fixed3D;
                top4_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 0] = "org-top";
                
            }
            else
            {
                top1_sel = false;
                top1_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 0] = "";
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }

        private void top2_pbox_Click(object sender, EventArgs e)
        {
            if (top2_sel == false)
            {
                top2_sel = true;
                top1_sel = false;
                top3_sel = false;
                top4_sel = false;
                top2_pbox.BorderStyle = BorderStyle.FixedSingle;
                top1_pbox.BorderStyle = BorderStyle.Fixed3D;
                top3_pbox.BorderStyle = BorderStyle.Fixed3D;
                top4_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 0] = "uni-top";
            }
            else
            {
                top2_sel = false;
                top2_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 0] = "";
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }

        private void top3_pbox_Click(object sender, EventArgs e)
        {
            if (top3_sel == false)
            {
                top3_sel = true;
                top1_sel = false;
                top2_sel = false;
                top4_sel = false;
                top3_pbox.BorderStyle = BorderStyle.FixedSingle;
                top2_pbox.BorderStyle = BorderStyle.Fixed3D;
                top1_pbox.BorderStyle = BorderStyle.Fixed3D;
                top4_pbox.BorderStyle = BorderStyle.Fixed3D;
                if(Bedroom.instance.CHARAC_ID == 1)
                {
                    Closet.Garments_Worn[0, 0] = "pe-top";
                }
                else
                {
                    Closet.Garments_Worn[0, 0] = "cas-top";
                }
            }
            else
            {
                top3_sel = false;
                top3_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 0] = "";
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }

        private void top4_pbox_Click(object sender, EventArgs e)
        {
            if (top4_sel == false)
            {
                top4_sel = true;
                top1_sel = false;
                top2_sel = false;
                top3_sel = false;
                top4_pbox.BorderStyle = BorderStyle.FixedSingle;
                top2_pbox.BorderStyle = BorderStyle.Fixed3D;
                top3_pbox.BorderStyle = BorderStyle.Fixed3D;
                top1_pbox.BorderStyle = BorderStyle.Fixed3D;
                if (Bedroom.instance.CHARAC_ID == 1)
                {
                    Closet.Garments_Worn[0, 0] = "cas-top";
                }
                else
                {
                    Closet.Garments_Worn[0, 0] = "pe-top";
                }
            }
            else
            {
                top4_sel = false;
                top4_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 0] = "";
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }
    }
}
