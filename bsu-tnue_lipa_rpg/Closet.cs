using bsu_tnue_lipa_rpg.Closet_garments_uc;
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
    public partial class Closet : Form
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

        //Initialized them at first inorder to create the instance firsthand
        top top_uc = new top();
        bottom bot_uc = new bottom();
        neck neck_uc = new neck();
        shoes shoes_uc = new shoes();
        public Closet()
        {
            InitializeComponent();
            addUC(top_uc);
        }
        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            garments_panel.Controls.Clear();
            garments_panel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void backtoroom_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bedroom.instance.Show();//to load the recent form
            Bedroom.instance.bedroomWalkTimer.Start();//to access the bedroom timer;made this public in designer.cs
            this.Close();
        }

        private void top_pbox_Click(object sender, EventArgs e)
        {
            top_uc = top.instance;
            addUC(top_uc);
        }

        private void pants_pbox_Click(object sender, EventArgs e)
        {
            bot_uc = bottom.instance;
            addUC(bot_uc);
        }

        private void necklace_pbox_Click(object sender, EventArgs e)
        {
            neck_uc = neck.instance;
            addUC(neck_uc);
        }

        private void shoes_pbox_Click(object sender, EventArgs e)
        {
           shoes_uc = shoes.instance;
            addUC(shoes_uc);
        }
    }
}
