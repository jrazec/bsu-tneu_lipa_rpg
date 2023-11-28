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
            read_lbl.Click += read_lbl_Click;
            update_lbl.Click += label3_Click;
            delete_lbl.Click += label4_Click;
        }

        private void create_lbl_Click(object sender, EventArgs e)
        {
            Controls.Clear();

           
            Admin_Create adminCreateControl = new Admin_Create();

          
            Controls.Add(adminCreateControl);
            adminCreateControl.Dock = DockStyle.Fill;
        }

        private void read_lbl_Click(object sender, EventArgs e)
        {

            Controls.Clear();

            // Create an instance of the Admin_Read user control
            Admin_Read adminReadControl = new Admin_Read();

            // Add the Admin_Read user control to the form's controls
            Controls.Add(adminReadControl);
            adminReadControl.Dock = DockStyle.Fill;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            // Create an instance of the Admin_Update user control
            Admin_Update adminUpdateControl = new Admin_Update();

            // Add the Admin_Update user control to the form's controls
            Controls.Add(adminUpdateControl);
            adminUpdateControl.Dock = DockStyle.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            // Create an instance of the Admin_Delete user control
            Admin_Delete adminDeleteControl = new Admin_Delete();

            // Add the Admin_Delete user control to the form's controls
            Controls.Add(adminDeleteControl);
            adminDeleteControl.Dock = DockStyle.Fill;
        }
    }
}
