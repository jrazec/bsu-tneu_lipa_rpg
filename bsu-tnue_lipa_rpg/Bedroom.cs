﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bsu_tnue_lipa_rpg
{

   
    public partial class Bedroom : Form
    {
        public int CHARAC_ID;

        public static Bedroom instance;
        bool go_up, go_down, go_left, go_right;
        int walk = 20;

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
        public Bedroom()
        {

            InitializeComponent();
            instance = this;

            checkCharac();
            characCasualFront();

        }
        bool openSched = false;

        
        private void next_pbox_Click(object sender, EventArgs e)
        {
            view_lbl.Visible = false;
            sched_pbox.Visible = false; // to make sure it is clsoed.
            next_pbox.Visible = false;
            dg_bedroom.Text = @"Before you head out, remember to dress appropriately. Today's schedule includes prescribed garments and you'll need to 
choose the right ones.";
            click_lbl.Visible = true;
            click_lbl.Text = "Press to start.";
            enter_lbl.Visible = true;
            
        }
        

        private void view_lbl_Click(object sender, EventArgs e)
        {
            click_lbl.Visible = true;
            next_pbox.Visible = true;

            if (openSched == false)
            {
                openSched = true;
                sched_pbox.Visible = true;
                sched_pbox.BringToFront();
                view_lbl.Text = "HIDE";
            }
            else
            {
                openSched = false;
                sched_pbox.Visible = false;
                sched_pbox.SendToBack();
                view_lbl.Text = "VIEW";
            }
        }

        private void enter_lbl_Click(object sender, EventArgs e)
        {
            enter_lbl.Visible = false;
            dg_pbox.Visible = false;
            dg_bedroom.Visible = false;
            click_lbl.Visible = false;
            bedroomWalkTimer.Start();
        }

        private void menu_pbox_Click(object sender, EventArgs e)
        {

        }
        
        //initiate character movement in the bedroom
        private void bedroomWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && bedroom_charac.Left > 149)
            {
                bedroom_charac.Left -= walk;
            }
            if (go_right == true && bedroom_charac.Left < 897)
            {
                bedroom_charac.Left += walk;
            }
            if (go_up == true && bedroom_charac.Top > 46)
            {
                bedroom_charac.Top -= walk;
            }
            if (go_down == true && bedroom_charac.Top + bedroom_charac.Height < this.ClientSize.Height)
            {
                bedroom_charac.Top += walk;
            }

            //to open closet
            foreach (Control closet in this.Controls)
            {
                if (closet is PictureBox && (string)closet.Tag == "closet_open")
                {
                    if (bedroom_charac.Bounds.IntersectsWith(closet.Bounds))
                    {
                        //stop character movement
                        bedroomWalkTimer.Stop();

                        //move character away from collision box
                        bedroom_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to closet form
                        this.Hide();
                        Closet opened_closet = new Closet();
                        opened_closet.ShowDialog();

                    }
                }
            }

            //to go out
            foreach (Control door in this.Controls)
            {
                if (door is PictureBox && (string)door.Tag == "go_outside")
                {
                    if (bedroom_charac.Bounds.IntersectsWith(door.Bounds))
                    {
                        //stop character movement
                        bedroomWalkTimer.Stop();

                        //move character away from collision box
                        bedroom_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to closet form
                        this.Hide();
                        Facade to_facade = new Facade();
                        to_facade.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        //navigation button events
        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                e.Handled = true;
                go_left = true;
                characCasualLeft();
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                go_right = true;
                characCasualRight();
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                e.Handled = true;
                go_up = true;
                characCasualBack();
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                e.Handled = true;
                go_down = true;
                characCasualFront();
            }
        }

        private void key_is_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = false;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = false;
            }     
        }
        private void characCasualFront()
        {
            if(CHARAC_ID == 1)
            {
                bedroom_charac.Image = Properties.Resources.male_casual_front;
            }
            else if(CHARAC_ID == 2)
            {
                bedroom_charac.Image = Properties.Resources.female_casual_front;
            }    
        }

        private void characCasualBack()
        {
            if (CHARAC_ID == 1)
            {
                bedroom_charac.Image = Properties.Resources.male_casual_back;
            }
            else if (CHARAC_ID == 2)
            {
                bedroom_charac.Image = Properties.Resources.female_casual_back;
            }
        }

        private void characCasualLeft()
        {
            if (CHARAC_ID == 1)
            {
                bedroom_charac.Image = Properties.Resources.male_casual_left;
            }
            else if (CHARAC_ID == 2)
            {
                bedroom_charac.Image = Properties.Resources.female_casual_left;
            }
        }

        private void characCasualRight()
        {
            if (CHARAC_ID == 1)
            {
                bedroom_charac.Image = Properties.Resources.male_casual_right;
            }
            else if (CHARAC_ID == 2)
            {
                bedroom_charac.Image = Properties.Resources.female_casual_right;
            }
        }

        private void checkCharac()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctCharacID = $@"
                SELECT charac_id
                FROM students
                WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}'";

            try
            {
                mysqlConnection.Open();
                MySqlCommand sltcCharacIDCmd = new MySqlCommand(slctCharacID,mysqlConnection); 

                using (MySqlDataReader reader = sltcCharacIDCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CHARAC_ID = Convert.ToInt32(reader["charac_id"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysqlConnection.Close();
            }
            //to be removed
            day_lbl.Text = CHARAC_ID.ToString();
        }


    }
}