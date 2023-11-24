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

        private void backtoroom_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bedroom bedroom = new Bedroom();
            bedroom.ShowDialog();
            this.Close();
        }
    }
}
