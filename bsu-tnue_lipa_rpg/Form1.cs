using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//Add Setup button

namespace bsu_tnue_lipa_rpg
{
    public partial class Form1 : Form
    {
        const string dBase = "bsu_lipa_rpg_database";//database that you will connect
        //---------Created a delgate void function inorder to allow the callback function to be stored in a variable as wel as used in a parameter
        public delegate void callback();
        private string fMysqlConn = $"server=127.0.0.1; user=root;password=";//FOR FIRST TIME DATABASE CREATION

        public static string mysqlConn = $"server=127.0.0.1; user=root; database={dBase}; password=";//For general use for CRUD operations
        private void setUpDatabase_Tables()//will only use in this forms once
        {
            MySqlConnection FmysqlConnection = new MySqlConnection(fMysqlConn);//for db

            MySqlConnection mysqlConnection = new MySqlConnection(mysqlConn);//for tb
            
            try//---Try to open the sql connection
            {
                FmysqlConnection.Open();
                string createDatabase = $"CREATE DATABASE IF NOT EXISTS {dBase};";
                MySqlCommand crtDatabaseCmd = new MySqlCommand(createDatabase, FmysqlConnection);
                crtDatabaseCmd.ExecuteNonQuery();

                mysqlConnection.Open(); 
                string createTables = @"
                                CREATE TABLE IF NOT EXISTS characters(
                                    charac_id INT PRIMARY KEY,
                                    charac_name VARCHAR(30),
	                                charac_type VARCHAR(20),
                                    charac_desc TEXT
                                );

                                CREATE TABLE IF NOT EXISTS students(
                                    sr_code VARCHAR(8) PRIMARY KEY,
                                    password VARCHAR(30) NOT NULL,
                                    in_game_name VARCHAR(20) NOT NULL,
                                    first_name VARCHAR(50) NOT NULL,
                                    last_name VARCHAR(50) NOT NULL,
                                    gender VARCHAR(20)
                                );

                                CREATE TABLE IF NOT EXISTS student_characters(
                                    charac_id INT REFERENCES characters(charac_id),
                                    sr_code VARCHAR(8) REFERENCES students(sr_code)
                                );

                                CREATE TABLE IF NOT EXISTS items(
                                    item_id INT PRIMARY KEY,
                                    item_name VARCHAR(40),
                                    item_price NUMERIC(6,2),
                                    item_class VARCHAR(20),
	                                item_desc TEXT
                                );

                                CREATE TABLE IF NOT EXISTS student_items (
                                    student_item_id INT PRIMARY KEY,
                                    sr_code VARCHAR(8) REFERENCES students(sr_code),
                                    item_id INT REFERENCES items(item_id)
                                );

                                CREATE TABLE IF NOT EXISTS day_tasks(
                                    day_task_id INT PRIMARY KEY,
                                    day_name VARCHAR(10),
	                                day_garment_type VARCHAR(30),
                                    day_task_hint TEXT,
                                    day_task_clue TEXT
                                );

                                CREATE TABLE IF NOT EXISTS achievements(
                                    achievement_id INT PRIMARY KEY,
                                    ach_name VARCHAR(50),
                                    ach_desc TEXT
                                );

                                CREATE TABLE IF NOT EXISTS tasks(
                                    task_id INT PRIMARY KEY,
                                    task_name VARCHAR(50),
                                    reward NUMERIC(6,2),
	                                status BOOLEAN,
                                    day_task_id INT REFERENCES day_tasks(day_task_id),
                                    achievement_id INT REFERENCES achievements(achievement_id)
                                );

                                CREATE TABLE IF NOT EXISTS gameplay_records (
                                    gameplay_id INT PRIMARY KEY,
                                    date_finished DATE,
                                    total_time_spent TIME,
                                    current_money NUMERIC(7,2),
                                    status BOOLEAN,
                                    sr_code VARCHAR(8) REFERENCES students(sr_code),
                                    task_id INT REFERENCES tasks(task_id)
                                );";
               
                MySqlCommand crtTablesCmd = new MySqlCommand(createTables, mysqlConnection);
                crtTablesCmd.ExecuteNonQuery();

                MessageBox.Show("Success");
                set_up_btn.Enabled = false;
            }
            catch (Exception ex)//---If unsuccessecful, will show what error it is and will be stored in the ex var
            {
                MessageBox.Show(ex.Message);//will show the eror
            }
            finally//This will proceed whatever prosecuted, may it be try OR catch
            {
                FmysqlConnection.Close();
                mysqlConnection.Close();
            }
            
        }
        //public static void openMySqlConnection(){//function here}; //// done
        //create a button na pagkiclick sa una ay kecreate ng database, lagay warning pag walang xampp make syure to donwlaod xampp
        //create a button na pagkanagsign up si user ay matic na rin creation ng predefined data 
        //public static void insertInto(){};//
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in logIn = new Log_in();
            logIn.ShowDialog();
            this.Close();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up signUp = new Sign_up();
            signUp.ShowDialog();
            this.Close();
        }

        private void set_up_btn_Click(object sender, EventArgs e)
        {
            setUpDatabase_Tables();
        }
    }
}
