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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String srCode = Crt_sr_code_tbox.Text;
            String fName = Crt_first_name_tbox.Text;
            String lName = Crt_last_name_tbox.Text;
            String gender = Crt_gender_tbox.Text;
            String pass = Crt_password_tbox.Text;
            String passValidator = password_validator_tbox.Text;

            if(String.IsNullOrEmpty(srCode) || String.IsNullOrEmpty(fName) || String.IsNullOrEmpty(lName) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(passValidator))
            {//try catch part; if one of the values above is empty, then the following action wont prosecute or be saved in the database
                MessageBox.Show("Enter valid values!");
                
            }
            else
            {
                if (pass == passValidator)
                {//used this to make sure that the user is sure of his/her password
                    MySqlConnection mySqlConnection = new MySqlConnection(Form1.mysqlConn);
                    //---This will register the students input to the students table, along with it will be the predefined data
                    // and records.
                    try
                    { 
                        mySqlConnection.Open();
                        string insertStudent = $@"INSERT INTO students(sr_code,password,gender,first_name,last_name) 
                                              VALUES('{srCode}','{pass}','{gender}','{fName}','{lName}');";
                        MySqlCommand insStudRecCmd = new MySqlCommand(insertStudent, mySqlConnection);
                        insStudRecCmd.ExecuteNonQuery();
                        MessageBox.Show("Account Saved.");
                        this.Hide();
                        Log_in logIn = new Log_in();
                        logIn.ShowDialog();
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Passwords Don't Match. Make sure to type the same password");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Crt_first_name_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_validator_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Crt_gender_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure you want to exit the program?", "Warning", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
