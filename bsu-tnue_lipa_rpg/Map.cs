using bsu_tnue_lipa_rpg.CECS_floors_uc;
using bsu_tnue_lipa_rpg.Closet_garments_uc;
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
        int index = Bedroom.instance.TASK_ID - 1;
        public Map()
        {
            InitializeComponent();
            instance = this;
            Bedroom.instance.characFront(map_charac);
            dg_map.Text = DG_1[index];
            displayClue();
            enableNPCs();
        }

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

                OB_secondflr.INSTANCE.success_registrar.Enabled = false;
                OB_secondflr.INSTANCE.success_registrar.Visible = false;
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

                OB_secondflr.INSTANCE.success_registrar.Enabled = false;
                OB_secondflr.INSTANCE.success_registrar.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;
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

                OB_secondflr.INSTANCE.success_registrar.Enabled = false;
                OB_secondflr.INSTANCE.success_registrar.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;
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

                OB_secondflr.INSTANCE.success_registrar.Enabled = false;
                OB_secondflr.INSTANCE.success_registrar.Visible = false;
                OB_secondflr.INSTANCE.door1_panel.Visible = false;
                OB_secondflr.INSTANCE.door2_panel.Visible = false;
                OB_secondflr.INSTANCE.door3_panel.Visible = false;
            }
            else if(Bedroom.instance.DAY_ID == 5)
            { //Clinic
                OB_secondflr.INSTANCE.success_registrar.Enabled = true;
                OB_secondflr.INSTANCE.success_registrar.Visible = true;
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

            }
        }
    }
}