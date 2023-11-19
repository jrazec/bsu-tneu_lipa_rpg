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
        
        public static string mysqlConn = $"server=127.0.0.1; user=root; database={dBase}; password=";//For general use for CRUD operations
        private string fMysqlConn = $"server=127.0.0.1; user=root;password=";//FOR FIRST TIME DATABASE CREATION
       
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void loginAcc_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in logIn = new Log_in();
            logIn.ShowDialog();
            this.Close();
        }

        private void signupAcc_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up signUp = new Sign_up();
            signUp.ShowDialog();
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void set_up_btn_Click(object sender, EventArgs e)
        {
            setUpDatabase_Tables();
        }

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
                //Create the tables, and insert the predefined values
                string crtTables_insValues = @"
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
                    );
                    
                    INSERT INTO
                        characters(charac_id,charac_name,charac_type,charac_desc)
                    VALUES
                        (1,'Yuh Gie','Boy','Yuh Gie is one of the artist who colored the characters, entities and created layouts. He is known for his unyielding commitment to realism artworks.'),
                        (2,'Baddey','Girl','Baddey is one of the artist who created, drew, and colored the maps, characters, and building designs. She is known for her skills in digital art and excelling to academics.');

                    INSERT INTO 
                        items(item_id,item_name,item_price,item_desc,item_class)
                    VALUES
                        (1001,'College Blouse',380.00,'School Uniform for Girls','Top'),
                        (1002,'College Skirt',230.00,'School Uniform for Girls','Bottom'),
                        (1003,'College Barong',365.00,'School Uniform for Boys','Top'),
                        (1004,'College Pants',360.00,'School Uniform for Boys','Bottom'),
                        (1005,'PE T-Shirt',175.00,'PE School Uniform for Any Gender','Top'),
                        (1006,'PE Jogging Pants',270.00,'PE School Uniform for Any Gender','Bottom'),
                        (1007,'School ID Lace',75.00,'Part of School Uniform for ID','Neck'),
                        (1008,'Shoes',10.00,'A beautiful black shoes!','Shoes'),
                        (1009,'Necklace Unisex',5.00,'Estetik Starter Pack','Neck'),
                        (1010,'Civilian Top-G',70.00,'Estetik Starter Pack for Girls Crop Top','Top'),
                        (1011,'Civilian Bottom-G',70.00,'Estetik Starter Pack for Girls Short Shorts','Bottom'),
                        (1012,'Civilian Top-B',70.00,'Estetik Starter Pack for Boys Sando','Top'),
                        (1013,'Civilian Bottom-B',70.00,'Estetik Starter Pack for Boys Short','Bottom'),
                        (1014,'CICS Org Shirt',500.00,'A casual organizational shirt of AICSS this s.y. 2022-2023 for Any Gender','Top'),
                        (1015,'Denim Pants',150.00,'Normal Unisex Pants','Bottom');

                    INSERT INTO
                        day_tasks(day_task_id,day_name,day_task_clue,day_task_hint,day_garment_type)
                    VALUES
                        (1,'Monday','Did you know that in room number, the Hundreds(100) indicate the floor, and the Ones(1) indicate the sequence','Hint: Go to the CECS building in the left side, navigate through the 4th floor in elevator then find your room.','Normal Day'),
                        (2,'Tuesday','May these old treasures be considered as such, yet hold the highest esteem and regard of the university.','Hint: Head to the Old Building, specifically in the highest floor and find someone to speak with. Seek and you shall see!','Normal Day'),
                        (3,'Wednesday','Did you know that in the elevator part of our school that is the Entrance and the Exit is front face of building. Use the proper entrance and exit, whether you are on the Ground or fifth floor.','Hint: Head to the Left Building or CECS office in the first floor in the “nth” section!','Wash Day'),
                        (4,'Thursday','As a first year, it is hard to navigate the offices but asking is not that hard right?','Hint: Go and ask him, he will tell you where exactly it is located','Normal Day'),
                        (5,'Friday','In the room for healing, where health stuffs are made, seek the answer where the Old echoes and Above the Ground unfolds.' ,'Hint: Head to the Old Building, and above the ground goes in the second floor where you shall find the clinic!','PE Day');

                    INSERT INTO
                        achievements(achievement_id,ach_name,ach_desc)
                    VALUES
                        (1,'First Step Journey','Successfully initiated your first day in the university.' ),
                        (2,'Midweek Explorer','Embraced the freedom of a casual Wednesday.' ),
                        (3,'Week‘s Triumph','Completed a rewarding week‘s journey.' ),
                        (4,'Monday Seeker','Expertly navigated and sought the rooms of CECS Building.' ),
                        (5,'Tuesday Wayfarer','Navigated, located, and accomplished the task to find the 3 Golden Treasures and the Library in the OLD Building.' ),
                        (6,'Wednesday Finder','Mastered the art of navigating and seeking the rooms of CECS Building.' ),
                        (7,'Thursday Trailblazer','Successfully asked, located, and navigated the registrar‘s office.' ),
                        (8,'Friday Code Cracker','Unraveled the secrets and cracked the code to find the Clinic in OLD Building.' ),
                        (9,'A True Red Spartan, Indeed!','Successfully accomplished all tasks!!!' ),
                        (10,'Garments Collector','Buy all the garments available in the closet section' );

                    INSERT INTO 
                        tasks(task_id,task_name,reward,day_task_id,achievement_id)
                    VALUES
                        (1,'Your First day Starts Now.',500.00,1,1),
                        (2,'Wednesday is a Free Day.',500.00,2,2),
                        (3,'Embark on a rewarding week‘s journey.',500.00,5,3),
                        (4,'Seek Day, Monday!',200.00,1,4),
                        (5,'Navigate, Locate, and Ask this Tuesday Ahu!',200.00,2,5),
                        (6,'Seek Day, Wednesday!',200.00,3,6),
                        (7,'Ask, Locate, and Navigate this Thursday Ahu!',200.00,4,7),
                        (8,'Crack the code, cuz its Friday!',200.00,5,8),
                        (9,'Complete all tasks',1000.00,5,9),
                        (10,'Unlock all Garments',1000.00,null,10);";

                MySqlCommand crtTbl_insValCmd = new MySqlCommand(crtTables_insValues, mysqlConnection);
                crtTbl_insValCmd.ExecuteNonQuery();

                MessageBox.Show("Success");
                set_up_btn.Enabled = false;
            }
            catch (Exception ex)//---If unsuccessecful, will show what error it is and will be stored in the ex var
            {
                MessageBox.Show(ex.Message,"Make Sure to Start the Actions Button in XAMPP");//will show the eror
            }
            finally//This will proceed whatever prosecuted, may it be try OR catch
            {
                FmysqlConnection.Close();
                mysqlConnection.Close();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
