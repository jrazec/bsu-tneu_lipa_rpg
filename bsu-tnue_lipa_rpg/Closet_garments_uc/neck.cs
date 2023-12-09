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

        public static neck instance;
        public neck()
        {
            InitializeComponent();
            instance = this;
        }
        public bool neck1_sel = false;
        public bool neck2_sel = false;
        private void neck1_pbox_Click(object sender, EventArgs e)
        {
            if (neck1_sel == false)
            {
                neck1_sel = true;
                neck2_sel = false;
                neck1_pbox.BorderStyle = BorderStyle.Fixed3D;
                neck1_pbox.BackColor = Color.DarkGray;

                neck2_pbox.BorderStyle = BorderStyle.None;
                neck2_pbox.BackColor = Color.Transparent;

                Closet.Garments_Worn[0, 2] = "gold-neck";
                Closet.instance.necklace_pbox.Image = Properties.Resources.Necklace_Unisex;
            }
            else
            {
                neck1_sel = false;
                neck1_pbox.BorderStyle = BorderStyle.None;
                neck1_pbox.BackColor = Color.Transparent;
                emptyIcon();
            }
            Closet.instance.label3.Text = Closet.Garments_Worn[0, 2];
        }

        private void neck2_pbox_Click(object sender, EventArgs e)
        {
            if (neck2_sel == false)
            {
                neck2_sel = true;
                neck1_sel = false;
                neck2_pbox.BorderStyle = BorderStyle.Fixed3D;
                neck2_pbox.BackColor = Color.DarkGray;

                neck1_pbox.BorderStyle = BorderStyle.None;
                neck1_pbox.BackColor = Color.Transparent;

                Closet.Garments_Worn[0, 2] = "id";
                Closet.instance.necklace_pbox.Image = Properties.Resources.School_ID_Lace;
            }
            else
            {
                neck2_sel = false;
                neck2_pbox.BorderStyle = BorderStyle.None;
                neck2_pbox.BackColor = Color.Transparent;
                emptyIcon();
            }
            Closet.instance.label3.Text = Closet.Garments_Worn[0, 2];
        }

        private void neck1_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 2, 0, () => {
                if (neck1_sel) {
                    emptyIcon();
                    neck1_sel = false;
                    neck1_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });

        }

        private void neck2_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 2, 1, () => {
                if (neck2_sel) {
                    emptyIcon();
                    neck2_sel = false;
                    neck2_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });

        }

        private void emptyIcon()
        {
            Closet.Garments_Worn[0, 2] = "";
            Closet.instance.necklace_pbox.Image = Properties.Resources.neck_icon;
        }
    }
}
