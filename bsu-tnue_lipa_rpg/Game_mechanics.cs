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
    public partial class Game_mechanics : Form
    {
        public Game_mechanics()
        {
            InitializeComponent();
            //make transparent bg for label
            t5_pbox.Controls.Add(label);
            t5_pbox.Location = new Point(39, 12);
            t5_pbox.BackColor = Color.Transparent;
        }

        private void t1_pbox_Click(object sender, EventArgs e)
        {
            t1_pbox.Visible = false;
            t2_pbox.Visible = true;
            t3_pbox.Visible = false;
            t4_pbox.Visible = false;
        }

        private void t2_pbox_Click(object sender, EventArgs e)
        {
            t1_pbox.Visible = false;
            t2_pbox.Visible = false;
            t3_pbox.Visible = true;
            t4_pbox.Visible = false;
        }

        private void t3_pbox_Click(object sender, EventArgs e)
        {
            t1_pbox.Visible = false;
            t2_pbox.Visible =false;
            t3_pbox.Visible = false;
            t4_pbox.Visible = true;
        }

        private void t4_pbox_Click(object sender, EventArgs e)
        {
            t1_pbox.Visible = false;
            t2_pbox.Visible = false;
            t3_pbox.Visible = false;
            t4_pbox.Visible = false;
            t5_pbox.Visible = true;
            label.Visible = true;
            label.BringToFront();
            proceed_btn.Visible = true;
        }

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Character_sel cSel = new Character_sel();
            cSel.ShowDialog();
            this.Close();
        }
    }
}
