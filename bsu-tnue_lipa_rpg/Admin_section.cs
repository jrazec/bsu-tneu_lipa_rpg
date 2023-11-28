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
            home_lbl.Click += home_lbl_Click;

          
        }

     

        private void create_lbl_Click(object sender, EventArgs e)
        {
            Admin_Create adminCreateControl = new Admin_Create();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminCreateControl);
            adminCreateControl.Dock = DockStyle.Fill;
            adminCreateControl.Show();

        }

        private void read_lbl_Click(object sender, EventArgs e)
        {
            Admin_Read adminReadControl = new Admin_Read();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminReadControl);
            adminReadControl.Dock = DockStyle.Fill;
            adminReadControl.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Admin_Update adminUpdateControl = new Admin_Update();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminUpdateControl);
            adminUpdateControl.Dock = DockStyle.Fill;
            adminUpdateControl.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Delete adminDeleteControl = new Admin_Delete();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminDeleteControl);
            adminDeleteControl.Dock = DockStyle.Fill;
            adminDeleteControl.Show();
        }

        private void home_lbl_Click(object sender, EventArgs e)
        {
            Admin_Home adminHomeControl = new Admin_Home();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminHomeControl);
            adminHomeControl.Dock = DockStyle.Fill;
            adminHomeControl.Show();
         
        }
    }
}
