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
        }
        public bool shoes1_sel = false;
        private void shoes1_pbox_Click(object sender, EventArgs e)
        {
            if (shoes1_sel == false)
            {
                shoes1_sel = true;
                shoes1_pbox.BorderStyle = BorderStyle.FixedSingle;
                Closet.Garments_Worn[0, 3] = "gen-shoes";
                Closet.instance.shoes_pbox.Image = Properties.Resources.Shoes;
            }
            else
            {
                shoes1_sel = false;
                shoes1_pbox.BorderStyle = BorderStyle.Fixed3D;
                emptyIcon();
            }
            Closet.instance.label4.Text = Closet.Garments_Worn[0, 3];
        }

        private void shoes1_desc_Click(object sender, EventArgs e)
        {
            //Closet.instance.label4.Text = Closet.instance.ITEM_PRICE[3, 0].ToString();
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 3, 0, () => {
                emptyIcon();
                shoes1_sel = false;
                shoes1_pbox.BorderStyle = BorderStyle.Fixed3D;
            });
        }
        private void emptyIcon()
        {
            Closet.Garments_Worn[0, 3] = "";
            Closet.instance.shoes_pbox.Image = Properties.Resources.shoes_icon;
        }

    }
    
}
