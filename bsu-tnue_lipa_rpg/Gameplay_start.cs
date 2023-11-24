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
    public partial class Gameplay_start : Form
    {
        public Gameplay_start()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure log out your account?", "Log-out", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                Form1.STUDENT_USER_SR_CODE = "";
                this.Hide();
                Log_in logIn = new Log_in();
                logIn.ShowDialog();
                this.Close();
            }
            
            
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctGmplyRec = $@"
                SELECT gameplay_records.status
                FROM gameplay_records
                WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}' AND task_id =1;"
            ;//Unsure here yet
             //Basta I want to check here if there is a record na the user already started a task inorder
             //for the player to not daan the tutorial/character selection part

            try
            {
                mysqlConnection.Open();
                MySqlDataAdapter slctGmplyRecCmd = new MySqlDataAdapter(slctGmplyRec, mysqlConnection);

                DataTable dt = new DataTable();
                slctGmplyRecCmd.Fill(dt);

                if (dt.Rows.Count == 1)//if makikita ung gameplay record na task # 1 nya na nag iisa naman
                {
                    this.Hide();
                    Bedroom bd = new Bedroom();
                    bd.ShowDialog();
                    this.Close();
                }
                else//if walang magpopop up na query, ito lalabas
                {
                    Game_mechanics gMech = new Game_mechanics();
                    gMech.ShowDialog();
                    this.Close();
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
