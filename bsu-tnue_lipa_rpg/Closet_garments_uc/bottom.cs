﻿using System;
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
            Bedroom.instance.checkCharac();
            if (Bedroom.instance.CHARAC_ID == 1)
            {
                bottom1_pbox.Image = Properties.Resources.College_Pants;
                bottom2_pbox.Image = Properties.Resources.Denim_Pants;
                bottom3_pbox.Image = Properties.Resources.PE_Jogging_Pant;
                bottom4_pbox.Image = Properties.Resources.Civilian_Bottom_2;
            }
            else
            {
                bottom1_pbox.Image = Properties.Resources.College_Skirt;
                bottom2_pbox.Image = Properties.Resources.Denim_Pants;
                bottom3_pbox.Image = Properties.Resources.PE_Jogging_Pant;
                bottom4_pbox.Image = Properties.Resources.Civilian_Bottom_1;
            }
        }
        public bool bot1_sel = false;
        public bool bot2_sel = false;
        public bool bot3_sel = false;
        public bool bot4_sel = false;
        private void bottom1_pbox_Click(object sender, EventArgs e)
        {
            if (bot1_sel == false)
            {
                bot1_sel = true;
                bot2_sel = false;
                bot3_sel = false;
                bot4_sel = false;
                bottom1_pbox.BorderStyle = BorderStyle.FixedSingle;
                bottom2_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom3_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom4_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "uni-bot";
            }
            else
            {
                bot1_sel = false;
                bottom1_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "";
            }
            Closet.instance.label2.Text = Closet.Garments_Worn[0, 1];
       
        }

        private void bottom2_pbox_Click(object sender, EventArgs e)
        {
            if (bot2_sel == false)
            {
                bot2_sel = true;
                bot1_sel = false;
                bot3_sel = false;
                bot4_sel = false;
                bottom2_pbox.BorderStyle = BorderStyle.FixedSingle;
                bottom3_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom1_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom4_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "org-bot";
            }
            else
            {
                bot2_sel = false;
                bottom2_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "";
            }
            Closet.instance.label2.Text = Closet.Garments_Worn[0, 1];
        }

        private void bottom3_pbox_Click(object sender, EventArgs e)
        {
            if (bot3_sel == false)
            {
                bot3_sel = true;
                bot1_sel = false;
                bot2_sel = false;
                bot4_sel = false;
                bottom3_pbox.BorderStyle = BorderStyle.FixedSingle;
                bottom1_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom2_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom4_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "pe-bot";
            }
            else
            {
                bot3_sel = false;
                bottom3_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "";
            }
            Closet.instance.label2.Text = Closet.Garments_Worn[0, 1];
        }
        
        private void bottom4_pbox_Click(object sender, EventArgs e)
        {
            if (bot4_sel == false)
            {
                bot4_sel = true;
                bot1_sel = false;
                bot2_sel = false;
                bot3_sel = false;
                bottom4_pbox.BorderStyle = BorderStyle.FixedSingle;
                bottom1_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom2_pbox.BorderStyle = BorderStyle.Fixed3D;
                bottom3_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "cas-bot";
            }
            else
            {
                bot4_sel = false;
                bottom4_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 1] = "";
            }
            Closet.instance.label2.Text = Closet.Garments_Worn[0, 1];
        }
    }
}
