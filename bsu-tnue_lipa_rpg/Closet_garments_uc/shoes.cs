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
                Closet.Garments_Worn[0, 3] = "";
                Closet.instance.shoes_pbox.Image = Properties.Resources.shoes_icon;
            }
            Closet.instance.label4.Text = Closet.Garments_Worn[0, 3];
        }

        private void shoes1_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buyItems(Form1.STUDENT_USER_SR_CODE, Closet.instance.ITEM_ID[3, 0]);
            Closet.instance.displayItemDesc();
        }

    }
    
}
