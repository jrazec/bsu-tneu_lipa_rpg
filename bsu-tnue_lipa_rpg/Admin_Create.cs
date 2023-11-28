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
    
    public partial class Admin_Create : UserControl
    {

        public Admin_Create()
        {
            InitializeComponent();
            home_lbl.Click += home_lbl_Click;
            label2.Click += label2_Click;
            label3.Click += label3_Click;
            label4.Click += label4_Click;
        }

        


        private void home_lbl_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_section adminsectionControl = new Admin_section();
            adminsectionControl.TopLevel = false;
            Controls.Add(adminsectionControl);
            adminsectionControl.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_Read adminReadControl = new Admin_Read();

            Controls.Add(adminReadControl);
            adminReadControl.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_Update adminUpdateControl = new Admin_Update();

            Controls.Add(adminUpdateControl);
            adminUpdateControl.Dock = DockStyle.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_Delete adminDeleteControl = new Admin_Delete();

            Controls.Add(adminDeleteControl);
            adminDeleteControl.Dock = DockStyle.Fill;
        }
    }
}
