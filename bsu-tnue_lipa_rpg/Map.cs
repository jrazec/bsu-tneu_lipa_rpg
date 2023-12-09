using bsu_tnue_lipa_rpg.CECS_floors_uc;
using bsu_tnue_lipa_rpg.Closet_garments_uc;
using bsu_tnue_lipa_rpg.Menu_options_forms;
using bsu_tnue_lipa_rpg.OB_floors_uc;
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
        public string HINT;
        int index = Bedroom.instance.DAY_ID - 1;

        public Map()
        {
            InitializeComponent();
            Bedroom.instance.characFront(map_charac);
            checkClue_Hint();
            if (Gameplay_start.free)
            {
                dg_map.Visible = false;
                dg_pbox.Visible = false;
                enter_lbl.Visible = false;
                next_pbox.Visible = false;
                click_lbl.Visible = false;
                mapWalkTimer.Start();
                hinttext_lbl.Text = "Roam Around, its your free roam day!!";
            }
            else
            {
                hinttext_lbl.Text = HINT;
                dg_map.Text = DG_1[index];
            }
            day_lbl.Text = Bedroom.instance.DAY;

            enableNPCs();
            instance = this;
            currency_lbl.Text = Bedroom.instance.CURRENT_MONEY.ToString("C");// IDK why may warning :<

            //To Make the labels transparent
            dg_map.BackColor = Color.FromArgb(179, 0, 0, 0);
            click_lbl.BackColor = Color.FromArgb(179, 0, 0, 0);
            next_pbox.BackColor = Color.FromArgb(179, 0, 0, 0);

            ign_lbl.Text = $@"Hello, {Bedroom.instance.ign}

{Bedroom.instance.firstName + " " + Bedroom.instance.lastName} | {Form1.STUDENT_USER_SR_CODE}";
        }
        bool openMenu = false;
        bool openHint = false;
       
        public bool tasksClicked = false;
        public bool achievsClicked = false;
        public bool returnClicked = false;
        
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
            Bedroom.instance.hoverChange(tasks_lbl);
        }

        private void tasks_hoverout(object sender, EventArgs e)
        {
            if (!tasksClicked)
            {
                Bedroom.instance.hoverReset(tasks_lbl);
            }
            else
            {
                Bedroom.instance.hoverChange(tasks_lbl);
            }
        }

        private void achievs_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(achievs_lbl);
        }

        private void achievs_hoverout(object sender, EventArgs e)
        {
            if (!achievsClicked)
            {
                Bedroom.instance.hoverReset(achievs_lbl);
            }
            else
            {
                Bedroom.instance.hoverChange(achievs_lbl);
            }
        }

        private void return_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(return_label);
        }

        private void return_hoverout(object sender, EventArgs e)
        {
            if (!returnClicked)
            {
                Bedroom.instance.hoverReset(return_label);
            }
            else
            {
                Bedroom.instance.hoverChange(return_label);
            }
        }
        #endregion

        #region menu click events
        private void tasks_lbl_Click(object sender, EventArgs e)
        {
            tasksClicked = true;
            achievsClicked = false;
            returnClicked = false;

            Bedroom.instance.hoverChange(tasks_lbl);
            Bedroom.instance.hoverReset(achievs_lbl);
            Bedroom.instance.hoverReset(return_label);

            Tasks tasks = new Tasks();
            tasks.Show();
        }

        private void achievs_lbl_Click(object sender, EventArgs e)
        {
            achievsClicked = true;
            tasksClicked = false;
            returnClicked = false;

            Bedroom.instance.hoverChange(achievs_lbl);
            Bedroom.instance.hoverReset(tasks_lbl);
            Bedroom.instance.hoverReset(return_label);

            Achievements achievs = new Achievements();
            achievs.Show();
        }

        private void return_label_Click(object sender, EventArgs e)
        {
            returnClicked = true;
            tasksClicked = false;
            achievsClicked = false;

            Bedroom.instance.hoverChange(return_label);
            Bedroom.instance.hoverReset(achievs_lbl);
            Bedroom.instance.hoverReset(tasks_lbl);

            //code to return to main menu
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
        private void checkClue_Hint()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctClues = $@"
                        SELECT students.sr_code, day_tasks.day_task_clue AS clue, day_tasks.day_task_hint AS hnt
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
                        HINT = reader["hnt"].ToString();
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

        public void enableNPCs()
        {
            if (Bedroom.instance.DAY_ID == 1)
            { //Sir Daryll
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Enabled = true;
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Visible = true;

                //DISABLING & HIDING OTHER NPC's TO MAKE SURE THEY WONT APPEAR 
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Enabled = false;
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Visible = false;

                CECS_fifthflr.INSTANCE.drbalazon_pbox.Enabled = false;
                CECS_fifthflr.INSTANCE.drbalazon_pbox.Visible = false;

                CECS_firstflr.INSTANCE.atty_pbox.Enabled = false;
                CECS_firstflr.INSTANCE.atty_pbox.Visible = false;

                OB_secondflr.INSTANCE.success_med.Enabled = false;
                OB_secondflr.INSTANCE.success_med.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;
            }
            else if (Bedroom.instance.DAY_ID == 2)
            { //Engr Jonnah
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Enabled = true;
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Visible = true;

                //DISABLING & HIDING OTHER NPC's TO MAKE SURE THEY WONT APPEAR 
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Enabled = false;
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Visible = false;

                CECS_fifthflr.INSTANCE.drbalazon_pbox.Enabled = false;
                CECS_fifthflr.INSTANCE.drbalazon_pbox.Visible = false;

                CECS_firstflr.INSTANCE.atty_pbox.Enabled = false;
                CECS_firstflr.INSTANCE.atty_pbox.Visible = false;

                OB_secondflr.INSTANCE.success_med.Enabled = false;
                OB_secondflr.INSTANCE.success_med.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;

                #region JUST CLOSING ENTITIES
                CECS_fourthflr.INSTANCE.sir_dg.Visible = false;
                CECS_fourthflr.INSTANCE.door1_panel.Visible = false;
                CECS_fourthflr.INSTANCE.door2_panel.Visible = false;
                CECS_fourthflr.INSTANCE.door3_panel.Visible = false;
                CECS_fourthflr.INSTANCE.success_door.Enabled = false;
                CECS_fourthflr.INSTANCE.success_door.Visible = false;
                CECS_fourthflr.INSTANCE.padayon_btn.Visible = false;
                CECS_fourthflr.INSTANCE.dg_pbox.Visible = false;
                CECS_fourthflr.INSTANCE.click_lbl.Visible = false;
                CECS_fourthflr.INSTANCE.cecsfourthWalkTimer.Enabled = true;
                CECS_fourthflr.INSTANCE.cecsfourthWalkTimer.Start();
                #endregion
            }
            else if (Bedroom.instance.DAY_ID == 3)
            { //Dr. Balazon
                CECS_fifthflr.INSTANCE.drbalazon_pbox.Enabled = true;
                CECS_fifthflr.INSTANCE.drbalazon_pbox.Visible = true;

                //DISABLING & HIDING OTHER NPC's TO MAKE SURE THEY WONT APPEAR 
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Enabled = false;
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Visible = false;

                OB_fifthflr.INSTANCE.engrjonnah_pbox.Enabled = false;
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Visible = false;

                CECS_firstflr.INSTANCE.atty_pbox.Enabled = false;
                CECS_firstflr.INSTANCE.atty_pbox.Visible = false;

                OB_secondflr.INSTANCE.success_med.Enabled = false;
                OB_secondflr.INSTANCE.success_med.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;

                #region JUST CLOSING ENTITIES
                OB_fifthflr.INSTANCE.engr_dg.Visible = false;
                OB_fifthflr.INSTANCE.door1_panel.Visible = false;
                OB_fifthflr.INSTANCE.door2_panel.Visible = false;
                OB_fifthflr.INSTANCE.door3_panel.Visible = false;
                OB_fifthflr.INSTANCE.padayon_btn.Visible = false;
                OB_fifthflr.INSTANCE.success_door.Enabled = false;
                OB_fifthflr.INSTANCE.success_door.Visible = false;
                OB_fifthflr.INSTANCE.dg_pbox.Visible = false;
                OB_fifthflr.INSTANCE.click_lbl.Visible = false;
                OB_fifthflr.INSTANCE.obfifthWalkTimer.Enabled = true;
                OB_fifthflr.INSTANCE.obfifthWalkTimer.Start();
                #endregion

            }
            else if (Bedroom.instance.DAY_ID == 4)
            { //Atty. De Silva 
                CECS_firstflr.INSTANCE.atty_pbox.Enabled = true;
                CECS_firstflr.INSTANCE.atty_pbox.Visible = true;

                //DISABLING & HIDING OTHER NPC's TO MAKE SURE THEY WONT APPEAR 
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Enabled = false;
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Visible = false;

                CECS_fifthflr.INSTANCE.drbalazon_pbox.Enabled = false;
                CECS_fifthflr.INSTANCE.drbalazon_pbox.Visible = false;

                OB_fifthflr.INSTANCE.engrjonnah_pbox.Enabled = false;
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Visible = false;

                OB_secondflr.INSTANCE.success_med.Enabled = false;
                OB_secondflr.INSTANCE.success_med.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;

                #region JUST CLOSING ENTITIES
                CECS_fifthflr.INSTANCE.dr_dg.Visible = false;
                CECS_fifthflr.INSTANCE.door1_panel.Visible = false;
                CECS_fifthflr.INSTANCE.door2_panel.Visible = false;
                CECS_fifthflr.INSTANCE.success_door.Enabled = false;
                CECS_fifthflr.INSTANCE.success_door.Visible = false;
                CECS_fifthflr.INSTANCE.door3_panel.Visible = false;
                CECS_fifthflr.INSTANCE.padayon_btn.Visible = false;
                CECS_fifthflr.INSTANCE.dg_pbox.Visible = false;
                CECS_fifthflr.INSTANCE.click_lbl.Visible = false;
                CECS_fifthflr.INSTANCE.cecsfifthWalkTimer.Enabled = true;
                CECS_fifthflr.INSTANCE.cecsfifthWalkTimer.Start();
                #endregion
            }
            else if(Bedroom.instance.DAY_ID == 5)
            { //Clinic
                OB_secondflr.INSTANCE.success_med.Enabled = true;
                OB_secondflr.INSTANCE.success_med.Visible = true;
                OB_secondflr.INSTANCE.door1_panel.Visible = true;
                OB_secondflr.INSTANCE.door2_panel.Visible = true;
                OB_secondflr.INSTANCE.door3_panel.Visible = true;

                //DISABLING & HIDING OTHER NPC's TO MAKE SURE THEY WONT APPEAR 
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Enabled = false;
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Visible = false;

                CECS_fifthflr.INSTANCE.drbalazon_pbox.Enabled = false;
                CECS_fifthflr.INSTANCE.drbalazon_pbox.Visible = false;

                OB_fifthflr.INSTANCE.engrjonnah_pbox.Enabled = false;
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Visible = false;

                CECS_firstflr.INSTANCE.atty_pbox.Enabled = false;
                CECS_firstflr.INSTANCE.atty_pbox.Visible = false;

                #region JUST CLOSING ENTITIES
                CECS_firstflr.INSTANCE.atty_dg.Visible = false;
                CECS_firstflr.INSTANCE.door1_panel.Visible = false;
                CECS_firstflr.INSTANCE.door2_panel.Visible = false;
                CECS_firstflr.INSTANCE.door3_panel.Visible = false;
                CECS_firstflr.INSTANCE.success_registrar.Enabled = false;
                CECS_firstflr.INSTANCE.success_registrar.Visible = false;
                CECS_firstflr.INSTANCE.dg_pbox.Visible = false;
                CECS_firstflr.INSTANCE.click_lbl.Visible = false;
                CECS_firstflr.INSTANCE.cecsfirstWalkTimer.Enabled = true;
                CECS_firstflr.INSTANCE.cecsfirstWalkTimer.Start();
                #endregion 
            }
            else
            {
                //DISABLING & HIDING OTHER NPC's TO MAKE SURE THEY WONT APPEAR 
                OB_secondflr.INSTANCE.success_med.Enabled = false;
                OB_secondflr.INSTANCE.success_med.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;

                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Enabled = false;
                CECS_fourthflr.INSTANCE.sirtiquio_pbox.Visible = false;

                CECS_fifthflr.INSTANCE.drbalazon_pbox.Enabled = false;
                CECS_fifthflr.INSTANCE.drbalazon_pbox.Visible = false;

                OB_fifthflr.INSTANCE.engrjonnah_pbox.Enabled = false;
                OB_fifthflr.INSTANCE.engrjonnah_pbox.Visible = false;

                CECS_firstflr.INSTANCE.atty_pbox.Enabled = false;
                CECS_firstflr.INSTANCE.atty_pbox.Visible = false;
            }
        }

        
    }
}