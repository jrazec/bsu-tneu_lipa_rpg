using bsu_tnue_lipa_rpg.Closet_garments_uc;
using MySql.Data.MySqlClient;
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
    public partial class Map : Form
    {
        public static Map instance;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        bool go_up, go_down, go_left, go_right;
        int walk = 8;
        public string[] DG_1 = {
           "Good morning, Red Spartan! \r\nYour first task is to attend on your Database class and proctor will be Sir Tiquio for 7am - 10 am.  In your schedule, your room is at CECS Building, Room 401.",
           "Greetings, Red Spartan! \r\nToday, your mission is to find the Mission, Vision, and Core Values of our campus.",
           "Hello, Red Spartan! \r\nYour proctor for today will be Dr. Balazon from 1pm-3pm. Head to the Computer Laboratory for your Computer Science class",
           "Greetings, Red Spartan! \r\nToday, you want to pass your form 137 and ask for your certified true copy of your card. However where could it be possibly located?",
           "Good morning, Red Spartan! \r\nAfter your PE class, your professor tasked you to go to the clinic and ask for medical papers"

        };
        public string CLUE;
        int index = Bedroom.instance.TASK_ID - 1;
        public Map()
        {
            InitializeComponent();
            instance = this;
            Bedroom.instance.characFront(map_charac);
            dg_map.Text = DG_1[index];
            displayClue();
        }
        bool openMenu = false;
        bool openHint = false;

        #region dialogue
        private void next_pbox_Click(object sender, EventArgs e)
        {
            next_pbox.Visible = false;
            dg_map.Text = CLUE;
            click_lbl.Visible = true;
            click_lbl.Text = "Press to start.";
            enter_lbl.Visible = true;
        }

        private void enter_lbl_Click(object sender, EventArgs e)
        {
            enter_lbl.Visible = false;
            dg_pbox.Visible = false;
            dg_map.Visible = false;
            click_lbl.Visible = false;
            mapWalkTimer.Start();
        }
        #endregion

        #region menu and hint events
        private void menu_pbox_Click(object sender, EventArgs e)
        {
            if (openMenu == false)
            {
                openMenu = true;
                viewmenu_panel.Visible = true;
                viewmenu_panel.BringToFront();
                mapWalkTimer.Stop();
            }
            else
            {
                openMenu = false;
                viewmenu_panel.Visible = false;
                mapWalkTimer.Start();
            }
        }

        private void hint_pbox_Click(object sender, EventArgs e)
        {
            if (openHint == false)
            {
                openHint = true;
                hint_panel.Visible = true;
                hint_panel.BringToFront();
            }
            else
            {
                openHint = false;
                hint_panel.Visible = false;
            }
        }
        #endregion

        #region hover menu events
        private void tasks_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(tasks_panel, tasks_lbl);
        }

        private void tasks_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(tasks_panel, tasks_lbl);
        }

        private void achievs_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(achievs_panel, achievs_lbl);
        }

        private void achievs_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(achievs_panel, achievs_lbl);
        }

        private void return_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(return_panel, return_label);
        }

        private void return_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(return_panel, return_label);
        }
        #endregion

        private void mapWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && map_charac.Left > 149)
            {
                map_charac.Left -= walk;
            }
            if (go_right == true && map_charac.Left + map_charac.Width < this.ClientSize.Width)
            {
                map_charac.Left += walk;
            }
            if (go_up == true && map_charac.Top > 46)
            {
                map_charac.Top -= walk;
            }
            if (go_down == true && map_charac.Top + map_charac.Height < this.ClientSize.Height)
            {
                map_charac.Top += walk;
            }

            //to enter bldgs
            foreach (Control bldg in this.Controls)
            {
                //enter cecs building
                if (bldg is PictureBox && (string)bldg.Tag == "cecs")
                {
                    if (map_charac.Bounds.IntersectsWith(bldg.Bounds))
                    {
                        //stop character movement
                        mapWalkTimer.Stop();

                        //move character away from collision box
                        map_charac.Location = new Point(260, 431);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to CECS form
                        this.Hide();
                        CECS_bldg enter_cecs = new CECS_bldg();
                        enter_cecs.ShowDialog();

                        

                    }
                }

                //enter old building
                if (bldg is PictureBox && (string)bldg.Tag == "ob")
                {
                    if (map_charac.Bounds.IntersectsWith(bldg.Bounds))
                    {
                        //stop character movement
                        mapWalkTimer.Stop();

                        //move character away from collision box
                        map_charac.Location = new Point(925, 234);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //switch to OB form
                        this.Hide();
                        Old_Bldg enter_ob = new Old_Bldg();
                        enter_ob.ShowDialog();
                        

                    }
                }
            }
        }


        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(map_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(map_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(map_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(map_charac);
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
        private void displayClue()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctClues = $@"
                        SELECT students.sr_code, day_tasks.day_task_clue AS clue
                        FROM students 
                        INNER JOIN gameplay_records
                        ON gameplay_records.sr_code=students.sr_code
                        INNER JOIN tasks
                        ON gameplay_records.task_id=tasks.task_id
						INNER JOIN day_tasks
                        ON tasks.day_task_id=day_tasks.day_task_id
                        WHERE students.sr_code='{Form1.STUDENT_USER_SR_CODE}' 
                        ORDER BY students.sr_code,day_tasks.day_task_id DESC
                        LIMIT 1;";
            try
            {
                mysqlConnection.Open();
                MySqlCommand slctCluesCmd = new MySqlCommand(slctClues, mysqlConnection);

                using (MySqlDataReader reader = slctCluesCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CLUE = reader["clue"].ToString();
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
        }
    }
}
