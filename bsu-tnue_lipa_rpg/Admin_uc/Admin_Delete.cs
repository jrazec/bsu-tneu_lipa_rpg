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
    public partial class Admin_Delete : UserControl
    {
        public Admin_Delete()
        {
            InitializeComponent();
            
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);//for tb

            try//---Try to open the sql connection
            {
                mysqlConnection.Open();
                //Create the tables, and insert the predefined values
                string deleteRecord = @"
                DELETE FROM students;
                DELETE FROM student_items;
                DELETE FROM gameplay_records;";

                MySqlCommand deleteRecordCmd = new MySqlCommand(deleteRecord, mysqlConnection);
                deleteRecordCmd.ExecuteNonQuery();

                MessageBox.Show("Success");

            }
            catch (Exception ex)//---If unsuccessecful, will show what error it is and will be stored in the ex var
            {
                MessageBox.Show(ex.Message, "Failed...");//will show the eror
            }
            finally//This will proceed whatever prosecuted, may it be try OR catch
            {
                mysqlConnection.Close();
            }
        }
    }
}
