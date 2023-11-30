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
    public partial class shoes : UserControl
    {
        public static shoes instance;
        public shoes()
        {
            InitializeComponent();
            instance = this;
            if (Bedroom.instance.CHARAC_ID == 1)
            {
                shoes1_pbox.Image = Properties.Resources.Bluenelas;
                shoes2_pbox.Image = Properties.Resources.Shoes;
                shoes3_pbox.Image = Properties.Resources.White_Shoes;
            }
            else
            {
                shoes1_pbox.Image = Properties.Resources.Pinknelas;
                shoes2_pbox.Image = Properties.Resources.Shoes;
                shoes3_pbox.Image = Properties.Resources.White_Shoes;
            }
        }
        public bool shoes1_sel = false;
        public bool shoes2_sel = false;
        public bool shoes3_sel = false;
        private void shoes1_pbox_Click(object sender, EventArgs e)
        {
            if (shoes1_sel == false)
            {
                shoes1_sel = true;
                shoes2_sel = false;
                shoes3_sel = false;
                shoes1_pbox.BorderStyle = BorderStyle.FixedSingle;
                shoes2_pbox.BorderStyle = BorderStyle.Fixed3D;
                shoes3_pbox.BorderStyle = BorderStyle.Fixed3D;
                if (Bedroom.instance.CHARAC_ID == 1)
                {
                    Closet.Garments_Worn[0, 3] = "cas-shoes";
                    Closet.instance.shoes_pbox.Image = Properties.Resources.Bluenelas;
                }
                else
                {
                    Closet.Garments_Worn[0, 3] = "cas-shoes";
                    Closet.instance.shoes_pbox.Image = Properties.Resources.Pinknelas;
                }
            }
            else
            {
                shoes1_sel = false;
                shoes1_pbox.BorderStyle = BorderStyle.Fixed3D;
                emptyIcon();
            }
            Closet.instance.label4.Text = Closet.Garments_Worn[0, 3];
        }

        private void shoes2_pbox_Click(object sender, EventArgs e)
        {
            if (shoes2_sel == false)
            {
                shoes2_sel = true;
                shoes1_sel = false;
                shoes3_sel = false;
                shoes2_pbox.BorderStyle = BorderStyle.FixedSingle;
                shoes1_pbox.BorderStyle = BorderStyle.Fixed3D;
                shoes3_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 3] = "gen-shoes";
                Closet.instance.shoes_pbox.Image = Properties.Resources.Shoes;
            }
            else
            {
                shoes2_sel = false;
                shoes2_pbox.BorderStyle = BorderStyle.Fixed3D;
                emptyIcon();
            }
            Closet.instance.label4.Text = Closet.Garments_Worn[0, 3];
        }

        private void shoes3_pbox_Click(object sender, EventArgs e)
        {
            if (shoes3_sel == false)
            {
                shoes3_sel = true;
                shoes1_sel = false;
                shoes2_sel = false;
                shoes3_pbox.BorderStyle = BorderStyle.FixedSingle;
                shoes1_pbox.BorderStyle = BorderStyle.Fixed3D;
                shoes2_pbox.BorderStyle = BorderStyle.Fixed3D;
                Closet.Garments_Worn[0, 3] = "w-shoes";
                Closet.instance.shoes_pbox.Image = Properties.Resources.White_Shoes;
            }
            else
            {
                shoes3_sel = false;
                shoes3_pbox.BorderStyle = BorderStyle.Fixed3D;
                emptyIcon();
            }
            Closet.instance.label4.Text = Closet.Garments_Worn[0, 3];
        }
    

        private void shoes1_desc_Click(object sender, EventArgs e)
        {
            //Closet.instance.label4.Text = Closet.instance.ITEM_PRICE[3, 0].ToString();
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 3, 0, () => {
                if (shoes1_sel) {
                    emptyIcon();
                    shoes1_sel = false;
                    shoes1_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });
        }
        private void shoes2_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 3, 1, () => {
                 if (shoes2_sel) {
                    emptyIcon();
                    shoes2_sel = false;
                    shoes2_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });
        }

        private void shoes3_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 3, 2, () => {
               if (shoes3_sel) {
                    emptyIcon();
                    shoes3_sel = false;
                    shoes3_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });
        }


        private void emptyIcon()
        {
            Closet.Garments_Worn[0, 3] = "";
            Closet.instance.shoes_pbox.Image = Properties.Resources.shoes_icon;
        }

    }
    
}
