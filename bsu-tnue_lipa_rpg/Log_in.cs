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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            checkAccount();
        }
        private void checkAccount()
        {//this will query if the account is existing, then will return name
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);
            string srCode = sr_code_tbox.Text;
            string password = password_tbox.Text;

            string slctSrCodePassword = $@"
                SELECT sr_code, password
                FROM students
                WHERE sr_code = '{srCode}' AND password = '{password}'";

            try
            {
                mysqlConnection.Open();
                MySqlDataAdapter slctSrPassCmd = new MySqlDataAdapter(slctSrCodePassword, mysqlConnection);

                DataTable dt = new DataTable();
                slctSrPassCmd.Fill(dt);

                //Try to find a better solution here para macheck ung values ng row
                //If there is a way to check the value of dt.Row 
                if (dt.Rows.Count == 1)//if makikita ung sr code nya na nag iisa naman
                {
                    Form1.STUDENT_USER_SR_CODE = srCode;
                    login_btn.Text = Form1.STUDENT_USER_SR_CODE;
                    MessageBox.Show("Log-in Success");
                    this.Hide();
                    Gameplay_start gStart = new Gameplay_start();
                    gStart.ShowDialog();
                    this.Close();
                }
                else//if walang magpopop up na query, ito lalabas
                {
                    MessageBox.Show("Invalid Log-in Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure you want to exit the program?", "Warning", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
