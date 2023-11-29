using MySql.Data.MySqlClient;
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
        public string CHARAC_CLOTHES;
        public string DAY;
        public int DAY_ID;
        public double CURRENT_MONEY;

        public static Bedroom instance;
        bool go_up, go_down, go_left, go_right;
        int walk = 20;

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
        public Bedroom()
        {

            InitializeComponent();
            instance = this;
            Closet.instance = new Closet();
            checkCharac();
            checkMoney();
            checkDay();

            characFront(bedroom_charac);

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
                        Closet.instance.ShowDialog();

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
                characLeft(bedroom_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                go_right = true;
                characRight(bedroom_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                e.Handled = true;
                go_up = true;
                characBack(bedroom_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                e.Handled = true;
                go_down = true;
                characFront(bedroom_charac);
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
        public void characFront(PictureBox bedroom_charac)
        {

            if (CHARAC_ID == 1)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_front;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.male_uni_front;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.male_org_front;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.male_pe_front;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_front;
                }
            }
            else if (CHARAC_ID == 2)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_front;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.female_uni_front;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.female_org_front;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.female_pe_front;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_front;
                }
            }
        }

        public void characBack(PictureBox bedroom_charac)
        {
            if (CHARAC_ID == 1)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_back;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.male_uni_back;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.male_org_back;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.male_pe_back;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_back;
                }
            }
            else if (CHARAC_ID == 2)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_back;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.female_uni_back;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.female_org_back;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.female_pe_back;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_back;
                }
            }
        }

        public void characLeft(PictureBox bedroom_charac)
        {
            if (CHARAC_ID == 1)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_left;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.male_uni_left;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.male_org_left;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.male_pe_left;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_left;
                }
            }
            else if (CHARAC_ID == 2)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_left;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.female_uni_left;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.female_org_left;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.female_pe_left;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_left;
                }
            }
        }

        public void characRight(PictureBox bedroom_charac)
        {
            if (CHARAC_ID == 1)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_right;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.male_uni_right;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.male_org_right;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.male_pe_right;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.male_casual_right;
                }
            }
            else if (CHARAC_ID == 2)
            {
                if (CHARAC_CLOTHES == "CASUAL")
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_right;
                }
                else if (CHARAC_CLOTHES == "UNI")
                {
                    bedroom_charac.Image = Properties.Resources.female_uni_right;
                }
                else if (CHARAC_CLOTHES == "ORG")
                {
                    bedroom_charac.Image = Properties.Resources.female_org_right;
                }
                else if (CHARAC_CLOTHES == "PE")
                {
                    bedroom_charac.Image = Properties.Resources.female_pe_right;
                }
                else//Default Character garment
                {
                    bedroom_charac.Image = Properties.Resources.female_casual_right;
                }
            }
        }

        public void checkCharac()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctCharacID = $@"
                SELECT charac_id
                FROM students
                WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}'";

            try
            {
                mysqlConnection.Open();
                MySqlCommand sltcCharacIDCmd = new MySqlCommand(slctCharacID, mysqlConnection);

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
        }

        public void checkDay()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctDayName = $@"
                SELECT day_tasks.day_name AS day, day_tasks.day_task_id as ID
                FROM day_tasks
                INNER JOIN tasks
                ON tasks.day_task_id=day_tasks.day_task_id
                INNER JOIN gameplay_records
                ON gameplay_records.task_id=tasks.task_id
                INNER JOIN students
                ON gameplay_records.sr_code=students.sr_code
                WHERE students.sr_code = '{Form1.STUDENT_USER_SR_CODE}'
                ORDER BY tasks.task_id DESC
                LIMIT 1";

            try
            {
                mysqlConnection.Open();
                MySqlCommand slctDayNameCmd = new MySqlCommand(slctDayName, mysqlConnection);

                using (MySqlDataReader reader = slctDayNameCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DAY = (string)reader["day"];
                        DAY_ID = (int)reader["ID"];
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
            day_lbl.Text = DAY;
        }

        public void checkMoney()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctCurrMoney = $@"
                SELECT gameplay_records.current_money AS money
                FROM gameplay_records 
                INNER JOIN students
                ON gameplay_records.sr_code=students.sr_code
                WHERE students.sr_code = '{Form1.STUDENT_USER_SR_CODE}'
                ORDER BY gameplay_records.task_id DESC
                LIMIT 1;";
            //SHOULD BE LATEST UNG MONEY NA MAKUKUHA, siguro limit by one tas desc order

            try
            {
                mysqlConnection.Open();
                MySqlCommand slctCurrMoneyCmd = new MySqlCommand(slctCurrMoney, mysqlConnection);

                using (MySqlDataReader reader = slctCurrMoneyCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CURRENT_MONEY = Convert.ToDouble(reader["money"]);
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
            currency_lbl.Text = CURRENT_MONEY.ToString("C");
        }

        public void checkTask()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctCurrMoney = $@"
                SELECT gameplay_records.task_id AS task
                FROM tasks 
                INNER JOIN gameplay_records
                ON gameplay_records.task_id=tasks.task_id
                INNER JOIN students
                ON gameplay_records.sr_code=students.sr_code
                WHERE students.sr_code = '{Form1.STUDENT_USER_SR_CODE}'
                ORDER BY gameplay_records.task_id DESC
                LIMIT 1;";
            //SHOULD BE LATEST UNG MONEY NA MAKUKUHA, siguro limit by one tas desc order

            try
            {
                mysqlConnection.Open();
                MySqlCommand slctCurrMoneyCmd = new MySqlCommand(slctCurrMoney, mysqlConnection);

                using (MySqlDataReader reader = slctCurrMoneyCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CURRENT_MONEY = Convert.ToDouble(reader["money"]);
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
            currency_lbl.Text = CURRENT_MONEY.ToString("C");
        }
    }
}
