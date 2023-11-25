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
        
        public Closet()
        {
            InitializeComponent();
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
            top top_uc = new top();
            addUC(top_uc);
        }

        private void pants_pbox_Click(object sender, EventArgs e)
        {
            bottom bot_uc = new bottom();
            addUC(bot_uc);
        }

        private void necklace_pbox_Click(object sender, EventArgs e)
        {
            neck neck_uc = new neck();
            addUC(neck_uc);
        }

        private void shoes_pbox_Click(object sender, EventArgs e)
        {
            shoes shoes_uc = new shoes();
            addUC(shoes_uc);
        }
    }
}
