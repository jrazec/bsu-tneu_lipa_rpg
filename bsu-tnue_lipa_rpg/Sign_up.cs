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
            String srCode = Crt_sr_code_tbox.Text;
            String fName = Crt_first_name_tbox.Text;
            String lName = Crt_last_name_tbox.Text;
            String gender = Crt_gender_tbox.Text;
            String pass = Crt_password_tbox.Text;
            String passValidator = password_validator_tbox.Text;

            if(String.IsNullOrEmpty(srCode) || String.IsNullOrEmpty(fName) || String.IsNullOrEmpty(lName) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(passValidator))
            {//try catch part
                MessageBox.Show("Enter values to empty!");
            }
            else
            {

            }
        }
    }
}
