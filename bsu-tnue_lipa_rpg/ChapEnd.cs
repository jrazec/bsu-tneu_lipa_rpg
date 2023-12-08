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

namespace bsu_tnue_lipa_rpg.Closet_garments_uc
{
    public partial class Chapter_End : Form
    {
        public double REWARD = 0;
        public double add;
        public Chapter_End()
        {
            InitializeComponent();
            selectRewards();
        }

        private void proceed_pbox_Click(object sender, EventArgs e)
        {
            //Save timestamp
            //Save date
            //Save total time
            //Create another gameplay record
            //Ex. From task 1 going to task 2
            add = (REWARD + Bedroom.instance.CURRENT_MONEY);
            DialogResult sure = MessageBox.Show("Proceed to next day..", "Warning", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                updateGameplayRecords();
                this.Hide();
                Bedroom bd = new Bedroom();
                bd.ShowDialog();
                this.Close();
            }
        }


        public void selectRewards()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);
            string slctReward = $@"
                 SELECT tasks.reward AS rwd
                 FROM tasks 
                 INNER JOIN day_tasks
                 ON tasks.day_task_id=day_tasks.day_task_id
                 WHERE day_tasks.day_task_id={Bedroom.instance.DAY_ID};";
            try
            {
                mysqlConnection.Open();
                MySqlCommand slctRewardCmd = new MySqlCommand(slctReward, mysqlConnection);
                using (MySqlDataReader reader = slctRewardCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        REWARD += Convert.ToDouble(reader["rwd"]);
                    }
                }
                label1.Text = REWARD.ToString();

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

        //Ung  sa achievements ay kung ano ung task na status ay true, it is achieved na
        public void updateGameplayRecords()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            try
            {
                mysqlConnection.Open();

                if(Bedroom.instance.DAY_ID == 1)//Monday will accomplish two tasks
                {
                    string updateStudentRecord = $@"
                    UPDATE gameplay_records
                    SET status=true
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}' AND task_id=1;

                    INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                    VALUES ('{Form1.STUDENT_USER_SR_CODE}',6,CURRENT_DATE,true);
                
                    UPDATE students
                    SET current_money={add}
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';

                    INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                    VALUES ('{Form1.STUDENT_USER_SR_CODE}',2,CURRENT_DATE,false);";
                    MySqlCommand updateSRCmd = new MySqlCommand(updateStudentRecord, mysqlConnection);
                    updateSRCmd.ExecuteNonQuery();
                }
                else if (Bedroom.instance.DAY_ID == 2)//Tuesday will accomplish only one tasks
                {
                    string updateStudentRecord = $@"
                    UPDATE gameplay_records
                    SET status=true
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}' AND task_id=2;
                
                    UPDATE students
                    SET current_money={add}
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}'; 

                    INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                    VALUES ('{Form1.STUDENT_USER_SR_CODE}',3,CURRENT_DATE,false);";
                    MySqlCommand updateSRCmd = new MySqlCommand(updateStudentRecord, mysqlConnection);
                    updateSRCmd.ExecuteNonQuery();
                }
                else if (Bedroom.instance.DAY_ID == 3)//Wednesday will accomplish two tasks
                {
                    string updateStudentRecord = $@"
                    UPDATE gameplay_records
                    SET status=true
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}' AND task_id=3;

                    INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                    VALUES ('{Form1.STUDENT_USER_SR_CODE}',7,CURRENT_DATE,true);
                
                    UPDATE students
                    SET current_money={add}
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';

                    INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                    VALUES ('{Form1.STUDENT_USER_SR_CODE}',4,CURRENT_DATE,false);";
                    MySqlCommand updateSRCmd = new MySqlCommand(updateStudentRecord, mysqlConnection);
                    updateSRCmd.ExecuteNonQuery();
                }
                else if (Bedroom.instance.DAY_ID == 4)//Thursday will accomplish one task
                {
                    string updateStudentRecord = $@"
                    UPDATE gameplay_records
                    SET status=true
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}' AND task_id=4;
                
                    UPDATE students
                    SET current_money={add}
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';

                    INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                    VALUES ('{Form1.STUDENT_USER_SR_CODE}',5,CURRENT_DATE,false);";
                    MySqlCommand updateSRCmd = new MySqlCommand(updateStudentRecord, mysqlConnection);
                    updateSRCmd.ExecuteNonQuery();
                }
                else if (Bedroom.instance.DAY_ID == 5)//Friday will accomplish two tasks
                {
                    string updateStudentRecord = $@"
                    UPDATE gameplay_records
                    SET status=true
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}' AND task_id=5;

                    INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                    VALUES ('{Form1.STUDENT_USER_SR_CODE}',8,CURRENT_DATE,true);
                
                    UPDATE students
                    SET current_money={add}
                    WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';";
                    MySqlCommand updateSRCmd = new MySqlCommand(updateStudentRecord, mysqlConnection);
                    updateSRCmd.ExecuteNonQuery();

                    Gameplay_start.free = true;
                }
                else
                {
                    
                }

                #region Scractch Code : Stash
                /*
                string updateRecords = $@"
                UPDATE gameplay_records
                SET status=true
                WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}' AND task_id={Bedroom.instance.DAY_ID};       
                
                UPDATE students
                SET current_money={add}
                WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';

                INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',{(Bedroom.instance.DAY_ID + 1)},CURRENT_DATE,false); ";

                string updateRecords5 = $@"
                INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',5,CURRENT_DATE,false);
                UPDATE students
                SET current_money={add}
                WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';";
                string updateTask6 = $@"
                INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',6,CURRENT_DATE,true);";
                string updateTask7 = $@"
               INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',7,CURRENT_DATE,true);";
                string updateTask8 = $@"
               INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',8,CURRENT_DATE,true);;";
                string updateTask9 = $@"
                INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',9,CURRENT_DATE,true);";//All task
                string updateTask10 = $@"
                INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',10,CURRENT_DATE,true);";//All Garments to be added in closet

                                if (Bedroom.instance.DAY_ID < 5)
                {
                    if(Bedroom.instance.DAY_ID == 1)
                    {
                        MySqlCommand updateTask6Cmd = new MySqlCommand(updateTask6, mysqlConnection);
                        updateTask6Cmd.ExecuteNonQuery();
                    }
                    else if (Bedroom.instance.DAY_ID == 3)
                    {
                        MySqlCommand updateTask7Cmd = new MySqlCommand(updateTask7, mysqlConnection);
                        updateTask7Cmd.ExecuteNonQuery();
                    }

                    MySqlCommand updateRecordsCmd = new MySqlCommand(updateRecords, mysqlConnection);
                    updateRecordsCmd.ExecuteNonQuery();
                }
                else if(Bedroom.instance.DAY_ID == 5)
                {
                    MySqlCommand updateTask8Cmd = new MySqlCommand(updateTask8, mysqlConnection);
                    updateTask8Cmd.ExecuteNonQuery();
                    MySqlCommand updateTask9Cmd = new MySqlCommand(updateTask9, mysqlConnection);
                    updateTask9Cmd.ExecuteNonQuery();

                    MySqlCommand updateRecordsCmd = new MySqlCommand(updateRecords5, mysqlConnection);
                    updateRecordsCmd.ExecuteNonQuery();
                }
                else
                {

                }
                */
                #endregion
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
