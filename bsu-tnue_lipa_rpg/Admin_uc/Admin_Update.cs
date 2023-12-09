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
    public partial class Admin_Update : UserControl
    {
        public bool found;
        public Admin_Update()
        {
            InitializeComponent();
            
        }

        private void up_search_btn_Click(object sender, EventArgs e)
        {
            checkPlayer();
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (found)
            {
                if(sr_txt.Text != null || pass_txt.Text != null || fn_txt.Text != null || ln_txt.Text != null || gender_txt.Text != null ||
                    sr_txt.Text != "" || pass_txt.Text != "" || fn_txt.Text != "" || ln_txt.Text != "" || gender_txt.Text != "")
                {
                    updateRecords();
                    MessageBox.Show($"Update Successful!");
                }
                else
                {
                    MessageBox.Show("Enter valid values!");
                }
            }
            else
            {
                MessageBox.Show("Find the user's sr code first!");
            }
        }


        private void checkPlayer()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctSr = $@"
                SELECT sr_code
                FROM students
                WHERE sr_code='{sr_txt.Text}'";
            //

            try
            {
                mysqlConnection.Open();
                MySqlCommand slctSrCmd = new MySqlCommand(slctSr, mysqlConnection);

                using (MySqlDataReader reader = slctSrCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if (found)
                {
                    MessageBox.Show($"{sr_txt.Text} is found! You can now update his/her records.");
                }
                else
                {
                    MessageBox.Show($"{sr_txt.Text} not found..");
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

        private void updateRecords()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string updateRecords = $@"
                UPDATE students
                SET first_name='{fn_txt.Text}',last_name='{ln_txt.Text}',in_game_name='{ign_txt.Text}',gender='{gender_txt.Text}',password='{pass_txt.Text}'
                WHERE sr_code='{sr_txt.Text}'";
            //

            try
            {
                mysqlConnection.Open();
                MySqlCommand updtRecordsCmd = new MySqlCommand(updateRecords, mysqlConnection);
                updtRecordsCmd.ExecuteNonQuery();
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
