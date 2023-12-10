using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Admin_Read : UserControl
    {
        public string slctStudents = $@"SELECT first_name AS `FIRST NAME`, last_name AS SURNAME, in_game_name AS IGN,gender AS GENDER FROM students;";
        public string slctAchs = $@"SELECT students.sr_code AS `SR CODE`,students.in_game_name AS IGN, COUNT(achievements.achievement_id) AS `ACHIEVEMENTS #`
                                    FROM students
                                    INNER JOIN gameplay_records
                                    ON gameplay_records.sr_code=students.sr_code
                                    INNER JOIN tasks
                                    ON gameplay_records.task_id=tasks.task_id
                                    INNER JOIN achievements
                                    ON tasks.achievement_id=achievements.achievement_id
                                    WHERE gameplay_records.status=true
                                    GROUP BY `SR CODE`,IGN;";
        public string slctGamRec = $@"SELECT students.sr_code AS `SR CODE`, students.in_game_name AS IGN, tasks.task_name AS `TASK NAME`,gameplay_records.date_finished AS `FINISHED AT`
                                        FROM students
                                        INNER JOIN gameplay_records
                                        ON gameplay_records.sr_code=students.sr_code
                                        INNER JOIN tasks
                                        ON gameplay_records.task_id=tasks.task_id
                                        ORDER BY gameplay_records.date_finished;";
        public Admin_Read()
        {
            InitializeComponent();
           
        }
        
        private void checkRecords(string query)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            try
            {
                mysqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = mysqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bd = new BindingSource();
                bd.DataSource = dt;
                dgrid.DataSource = bd;
                dgrid.Visible = true;
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

        private void students_btn_Click(object sender, EventArgs e)
        {
            checkRecords(slctStudents);
        }

        private void achie_btn_Click(object sender, EventArgs e)
        {
            checkRecords(slctAchs);
        }

        private void gmplay_btn_Click(object sender, EventArgs e)
        {
            checkRecords(slctGamRec);
        }
    }
}
