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

        public Admin_section()
        {
           InitializeComponent();   
            create_lbl.Click += create_lbl_Click;
            read_lbl.Click += read_lbl_Click;
            update_lbl.Click += label3_Click;
            delete_lbl.Click += label4_Click;
            home_lbl.Click += home_lbl_Click;
            Admin_Home ahome = new Admin_Home();

            panel4.Controls.Add(ahome);
            ahome.Dock = DockStyle.Fill;
            ahome.Show();
        }

        

        private void create_lbl_Click(object sender, EventArgs e)
        {
            Admin_Create adminCreateControl = new Admin_Create();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminCreateControl);
            adminCreateControl.Dock = DockStyle.Fill;
            adminCreateControl.Show();


            panel2.BackColor = Color.White;
            home_lbl.BackColor = Color.White;
            home_lbl.ForeColor = Color.Black;
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.BackColor = Color.White;

            panel6.BackColor = Color.White;
            read_lbl.BackColor = Color.White;
            read_lbl.ForeColor = Color.Black;
            pictureBox3.Image = Properties.Resources.search;
            pictureBox3.BackColor = Color.White;

            panel7.BackColor = Color.White;
            update_lbl.BackColor = Color.White;
            update_lbl.ForeColor = Color.Black;
            pictureBox4.Image = Properties.Resources.cloud_upload_alt;
            pictureBox4.BackColor = Color.White;

            panel9.BackColor = Color.White;
            delete_lbl.BackColor = Color.White;
            delete_lbl.ForeColor = Color.Black;
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.BackColor = Color.White;

            panel5.BackColor = Color.Maroon;
            create_lbl.BackColor = Color.Maroon;
            create_lbl.ForeColor = Color.White;
            create_pbox.Image = Properties.Resources.select1;
            create_pbox.BackColor = Color.Maroon;

        }

        private void read_lbl_Click(object sender, EventArgs e)
        {
            Admin_Read adminReadControl = new Admin_Read();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminReadControl);
            adminReadControl.Dock = DockStyle.Fill;
            adminReadControl.Show();

            panel2.BackColor = Color.White;
            home_lbl.BackColor = Color.White;
            home_lbl.ForeColor = Color.Black;
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.BackColor = Color.White;

            panel5.BackColor = Color.White;
            create_lbl.BackColor = Color.White;
            create_lbl.ForeColor = Color.Black;
            create_pbox.Image = Properties.Resources.select;
            create_pbox.BackColor = Color.White;

            panel7.BackColor = Color.White;
            update_lbl.BackColor = Color.White;
            update_lbl.ForeColor = Color.Black;
            pictureBox4.Image = Properties.Resources.cloud_upload_alt;
            pictureBox4.BackColor = Color.White;

            panel9.BackColor = Color.White;
            delete_lbl.BackColor = Color.White;
            delete_lbl.ForeColor = Color.Black;
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.BackColor = Color.White;

            panel6.BackColor = Color.Maroon;
            read_lbl.BackColor = Color.Maroon;
            read_lbl.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.search1;
            pictureBox3.BackColor = Color.Maroon;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Admin_Update adminUpdateControl = new Admin_Update();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminUpdateControl);
            adminUpdateControl.Dock = DockStyle.Fill;
            adminUpdateControl.Show();

            panel5.BackColor = Color.White;
            create_lbl.BackColor = Color.White;
            create_lbl.ForeColor = Color.Black;
            create_pbox.Image = Properties.Resources.select;
            create_pbox.BackColor = Color.White;

            panel6.BackColor = Color.White;
            read_lbl.BackColor = Color.White;
            read_lbl.ForeColor = Color.Black;
            pictureBox3.Image = Properties.Resources.search;
            pictureBox3.BackColor = Color.White;

            panel9.BackColor = Color.White;
            delete_lbl.BackColor = Color.White;
            delete_lbl.ForeColor = Color.Black;
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.BackColor = Color.White;

            panel2.BackColor = Color.White;
            home_lbl.BackColor = Color.White;
            home_lbl.ForeColor = Color.Black;
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.BackColor = Color.White;

            panel7.BackColor = Color.Maroon;
            update_lbl.BackColor = Color.Maroon;
            update_lbl.ForeColor = Color.White;
            pictureBox4.Image = Properties.Resources.cloud_upload_alt1;
            pictureBox4.BackColor = Color.Maroon;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Delete adminDeleteControl = new Admin_Delete();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminDeleteControl);
            adminDeleteControl.Dock = DockStyle.Fill;
            adminDeleteControl.Show();

            panel2.BackColor = Color.White;
            home_lbl.BackColor = Color.White;
            home_lbl.ForeColor = Color.Black;
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.BackColor = Color.White;

            panel7.BackColor = Color.White;
            update_lbl.BackColor = Color.White;
            update_lbl.ForeColor = Color.Black;
            pictureBox4.Image = Properties.Resources.cloud_upload_alt;
            pictureBox4.BackColor = Color.White;

            panel5.BackColor = Color.White;
            create_lbl.BackColor = Color.White;
            create_lbl.ForeColor = Color.Black;
            create_pbox.Image = Properties.Resources.select;
            create_pbox.BackColor = Color.White;

            panel6.BackColor = Color.White;
            read_lbl.BackColor = Color.White;
            read_lbl.ForeColor = Color.Black;
            pictureBox3.Image = Properties.Resources.search;
            pictureBox3.BackColor = Color.White;

            panel9.BackColor = Color.Maroon;
            delete_lbl.BackColor = Color.Maroon;
            delete_lbl.ForeColor = Color.White;
            pictureBox5.Image = Properties.Resources.trash1;
            pictureBox5.BackColor = Color.Maroon;
        }

        private void home_lbl_Click(object sender, EventArgs e)
        {
            Admin_Home adminHomeControl = new Admin_Home();

            panel4.Controls.Clear();
            panel4.Controls.Add(adminHomeControl);
            adminHomeControl.Dock = DockStyle.Fill;
            adminHomeControl.Show();

            panel9.BackColor = Color.White;
            delete_lbl.BackColor = Color.White;
            delete_lbl.ForeColor = Color.Black;
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.BackColor = Color.White;

            panel7.BackColor = Color.White;
            update_lbl.BackColor = Color.White;
            update_lbl.ForeColor = Color.Black;
            pictureBox4.Image = Properties.Resources.cloud_upload_alt;
            pictureBox4.BackColor = Color.White;

            panel5.BackColor = Color.White;
            create_lbl.BackColor = Color.White;
            create_lbl.ForeColor = Color.Black;
            create_pbox.Image = Properties.Resources.select;
            create_pbox.BackColor = Color.White;

            panel6.BackColor = Color.White;
            read_lbl.BackColor = Color.White;
            read_lbl.ForeColor = Color.Black;
            pictureBox3.Image = Properties.Resources.search;
            pictureBox3.BackColor = Color.White;

            panel2.BackColor = Color.Maroon;
            home_lbl.BackColor = Color.Maroon;
            home_lbl.ForeColor = Color.White;
            pictureBox1.Image = Properties.Resources.home1;
            pictureBox1.BackColor = Color.Maroon;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Do you want to go back?", "Warning", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                this.Hide();
                Form1 main = new Form1();
                main.ShowDialog();
                this.Close();
            }
        }
    }
}
