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

namespace bsu_tnue_lipa_rpg.Menu_options_forms
{
    public partial class Achievements : Form
    {
        public string[] ACH_NAME = new string[10];
        public string[] ACH_DESC = new string[10];
        public Achievements()
        {
            InitializeComponent();
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.Enabled = false;
            }
            else if (Facade.instance.Visible)
            {
                Facade.instance.Enabled = false;
            }
            else if (Map.instance.Visible)
            {
                Map.instance.Enabled = false;
            }
            else if (CECS_bldg.instance.Visible)
            {
                CECS_bldg.instance.Enabled = false;
            }
            else if (Old_Bldg.instance.Visible)
            {
                Old_Bldg.instance.Enabled = false;
            }
            displayAchievs();
        }
        private void displayAchievs()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctAchievNames = $@"
                        SELECT achievements.ach_name AS ach, achievements.ach_desc AS dsc
                        FROM achievements
                        INNER JOIN tasks
                        ON tasks.achievement_id = achievements.achievement_id
                        INNER JOIN gameplay_records
                        ON gameplay_records.task_id = tasks.task_id
                        INNER JOIN students
                        ON gameplay_records.sr_code = students.sr_code
                        WHERE students.sr_code = '{Form1.STUDENT_USER_SR_CODE}'
                        AND gameplay_records.status=true;" ;
            try
            {
                mysqlConnection.Open();
                MySqlCommand slctAchievNamesCmd = new MySqlCommand(slctAchievNames, mysqlConnection);

                using (MySqlDataReader reader = slctAchievNamesCmd.ExecuteReader())
                {
                    int i = 0;
                    int j = 0;
                    while (reader.Read())
                    {
                        if (reader["ach"].ToString() != "")
                        {
                            ACH_NAME[i] = (string)reader["ach"];
                            i++;
                        }
                        if (reader["dsc"].ToString() != "")
                        {
                            ACH_DESC[j] = (string)reader["dsc"];
                            j++;
                        }
                           
                        
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
            a1.Text = ACH_NAME[0];
            a2.Text = ACH_NAME[1];
            a3.Text = ACH_NAME[2];
            a4.Text = ACH_NAME[3];
            a5.Text = ACH_NAME[4];
            a6.Text = ACH_NAME[5];
            a7.Text = ACH_NAME[6];
            a8.Text = ACH_NAME[7];
            a9.Text = ACH_NAME[8];
            a10.Text = ACH_NAME[9];

            d1.Text = ACH_DESC[0];
            d2.Text = ACH_DESC[1];
            d3.Text = ACH_DESC[2];
            d4.Text = ACH_DESC[3];
            d5.Text = ACH_DESC[4];
            d6.Text = ACH_DESC[5];
            d7.Text = ACH_DESC[6];
            d8.Text = ACH_DESC[7];
            d9.Text = ACH_DESC[8];
            d10.Text = ACH_DESC[9];
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Bedroom.instance.achievs_lbl);
                Bedroom.instance.Enabled = true;
            }

            else if (Facade.instance.Visible)
            {
                Facade.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Facade.instance.achievs_lbl);
                Facade.instance.Enabled = true;
            }

            else if (Map.instance.Visible)
            {
                Map.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Map.instance.achievs_lbl);
                Map.instance.Enabled = true;
            }


            else if (CECS_bldg.instance.Visible)
            {
                CECS_bldg.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(CECS_bldg.instance.achievs_lbl);
                CECS_bldg.instance.Enabled = true;
            }

            else if (Old_Bldg.instance.Visible)
            {
                Old_Bldg.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Old_Bldg.instance.achievs_lbl);
                Old_Bldg.instance.Enabled = true;
            }

            this.Close();
        }

        private void Achievements_Load(object sender, EventArgs e)
        {

        }

    }
}
