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
    public partial class Admin_section : Form
    {
        public Admin_section()
        {
            InitializeComponent();
            create_lbl.Click += create_lbl_Click;
        }

        private void create_lbl_Click(object sender, EventArgs e)
        {
            Admin_Create adminCreateForm = new Admin_Create();
            adminCreateForm.Show();
        }
    }
}
