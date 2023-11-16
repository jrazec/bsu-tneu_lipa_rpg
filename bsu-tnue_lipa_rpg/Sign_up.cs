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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String srCode, fName, lName, pass, gender, passValidator;

            if(String.IsNullOrEmpty(Crt_sr_code_tbox.Text))
            {
                MessageBox.Show("nice");
            }
        }
    }
}
