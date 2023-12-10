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
    
    public partial class Admin_Create : UserControl
    {

        public Admin_Create()
        {
            InitializeComponent();
      
        }

        


        private void home_lbl_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_section adminsectionControl = new Admin_section();
            adminsectionControl.TopLevel = false;
            Controls.Add(adminsectionControl);
            adminsectionControl.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_Read adminReadControl = new Admin_Read();

            Controls.Add(adminReadControl);
            adminReadControl.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_Update adminUpdateControl = new Admin_Update();

            Controls.Add(adminUpdateControl);
            adminUpdateControl.Dock = DockStyle.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Admin_Delete adminDeleteControl = new Admin_Delete();

            Controls.Add(adminDeleteControl);
            adminDeleteControl.Dock = DockStyle.Fill;
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);//for tb

            try//---Try to open the sql connection
            {
                mysqlConnection.Open();
                //Create the tables, and insert the predefined values
                string insertRECORDS = @"
                INSERT INTO 
                students(sr_code,password,in_game_name,first_name,last_name,gender,current_money,charac_id)
                VALUES
                ('22-32542','d','razecc29','John Razec','Agno','Male',560.00,1),
                ('22-35492','ddd','auclinn','Bernadette','Awatin','Female',560.00,2),
                ('22-37394','@cr001k1','crls.brk','Carlos Yajie','Fetizanan','Male',840.00,1),
                ('23-33787','aaaaa','AAguilar','Angelika','Aguila','Female',755.00,2),
                ('22-31258','m213!@#kd','jeyy','Jos','Hua','Male',755.00,1),
                ('22-35120','001ko#4','melvin','Daryl','Alo','Male',755.00,1),
                ('22-38748','ap','april_','Aprill','Aprril','Female',655.00,2),
                ('22-35628','arQuil0','Sheena','She','Na','Female',655.00,1),
                ('22-35610','d','rochelle','Achinza','Rochille','Male',560.00,1),
                ('22-34005','helloworld','Awit','La','Theo','Male',560.00,1);

                INSERT INTO student_items(sr_code,item_id,is_owned) 
                VALUES
                 ('22-32542',1003,true),
                 ('22-32542',1004,true),
                 ('22-32542',1005,true),
                 ('22-32542',1006,true),
                 ('22-32542',1007,true),
                 ('22-32542',1008,true),
                 ('22-32542',1009,true),
                 ('22-32542',1012,true),
                 ('22-32542',1013,true),
                 ('22-32542',1014,true),
                 ('22-32542',1015,true),
                 ('22-32542',1016,true),
                 ('22-32542',1018,true),
 
                 ('22-35492',1001,true),
                 ('22-35492',1002,true),
                 ('22-35492',1005,true),
                 ('22-35492',1006,true),
                 ('22-35492',1007,true),
                 ('22-35492',1008,true),
                 ('22-35492',1009,true),
                 ('22-35492',1010,true),
                 ('22-35492',1011,true),
                 ('22-35492',1014,true),
                 ('22-35492',1015,true),
                 ('22-35492',1017,false),
                 ('22-35492',1018,true),

                 ('22-37394',1003,true),
                 ('22-37394',1004,true),
                 ('22-37394',1005,false),
                 ('22-37394',1006,false),
                 ('22-37394',1007,true),
                 ('22-37394',1008,true),
                 ('22-37394',1009,false),
                 ('22-37394',1012,false),
                 ('22-37394',1013,false),
                 ('22-37394',1014,true),
                 ('22-37394',1015,true),
                 ('22-37394',1016,false),
                 ('22-37394',1018,true),

                ('23-33787',1001,true),
                ('23-33787',1002,true),
                ('23-33787',1005,false),
                ('23-33787',1006,false),
                ('23-33787',1007,true),
                ('23-33787',1008,true),
                ('23-33787',1009,false),
                ('23-33787',1010,false),
                ('23-33787',1011,false),
                ('23-33787',1014,false),
                ('23-33787',1015,false),
                ('23-33787',1017,false),
                ('23-33787',1018,false),

                ('22-31258',1003,true),
                ('22-31258',1004,true),
                ('22-31258',1005,false),
                ('22-31258',1006,false),
                ('22-31258',1007,true),
                ('22-31258',1008,true),
                ('22-31258',1009,false),
                ('22-31258',1012,false),
                ('22-31258',1013,false),
                ('22-31258',1014,false),
                ('22-31258',1015,false),
                ('22-31258',1016,false),
                ('22-31258',1018,false),

                ('22-35120',1003,true),
                ('22-35120',1004,true),
                ('22-35120',1005,false),
                ('22-35120',1006,false),
                ('22-35120',1007,true),
                ('22-35120',1008,true),
                ('22-35120',1009,false),
                ('22-35120',1012,false),
                ('22-35120',1013,false),
                ('22-35120',1014,false),
                ('22-35120',1015,false),
                ('22-35120',1016,false),
                ('22-35120',1018,false),

                ('22-38748',1001,true),
                ('22-38748',1002,true),
                ('22-38748',1005,false),
                ('22-38748',1006,false),
                ('22-38748',1007,true),
                ('22-38748',1008,true),
                ('22-38748',1009,false),
                ('22-38748',1010,false),
                ('22-38748',1011,false),
                ('22-38748',1014,true),
                ('22-38748',1015,true),
                ('22-38748',1017,false),
                ('22-38748',1018,true),

                ('22-35628',1003,true),
                ('22-35628',1004,true),
                ('22-35628',1005,false),
                ('22-35628',1006,false),
                ('22-35628',1007,true),
                ('22-35628',1008,true),
                ('22-35628',1009,false),
                ('22-35628',1012,false),
                ('22-35628',1013,false),
                ('22-35628',1014,true),
                ('22-35628',1015,true),
                ('22-35628',1016,false),
                ('22-35628',1018,true),

                ('22-35610',1003,true),
                ('22-35610',1004,true),
                ('22-35610',1005,true),
                ('22-35610',1006,true),
                ('22-35610',1007,true),
                ('22-35610',1008,true),
                ('22-35610',1009,true),
                ('22-35610',1012,true),
                ('22-35610',1013,true),
                ('22-35610',1014,true),
                ('22-35610',1015,false),
                ('22-35610',1016,true),
                ('22-35610',1018,true),

                ('22-34005',1003,true),
                ('22-34005',1004,true),
                ('22-34005',1005,true),
                ('22-34005',1006,true),
                ('22-34005',1007,true),
                ('22-34005',1008,true),
                ('22-34005',1009,true),
                ('22-34005',1012,true),
                ('22-34005',1013,true),
                ('22-34005',1014,true),
                ('22-34005',1015,true),
                ('22-34005',1016,true),
                ('22-34005',1018,true);

                INSERT INTO 
                  gameplay_records(gameplay_id,sr_code,status,task_id, date_finished)
                VALUES
                  (1,'22-32542',TRUE,1,'2023-11-20'),
                  (2,'22-32542',TRUE,6,'2023-11-20'),
                  (3,'22-32542',TRUE,2,'2023-11-20'),
                  (4,'22-32542',TRUE,3,'2023-11-20'),
                  (5,'22-32542',TRUE,7,'2023-11-20'),
                  (6,'22-32542',TRUE,4,'2023-11-20'),
                  (7,'22-32542',TRUE,5,'2023-11-20'),
                  (8,'22-32542',TRUE,8,'2023-11-20'),
                  (9,'22-32542',TRUE,9,'2023-11-20'),
                  (10,'22-32542',TRUE,10,'2023-11-20'),

                  (11,'22-35492',TRUE,1,'2023-11-21'),
                  (12,'22-35492',TRUE,6,'2023-11-21'),
                  (13,'22-35492',TRUE,2,'2023-11-21'),
                  (14,'22-35492',TRUE,3,'2023-11-21'),
                  (15,'22-35492',TRUE,7,'2023-11-21'),
                  (16,'22-35492',TRUE,4,'2023-11-21'),
                  (17,'22-35492',FALSE,5,'2023-11-21'),

                  (18,'22-37394',TRUE,1,'2023-12-02'),
                  (19,'22-37394',TRUE,6,'2023-12-02'),
                  (20,'22-37394',TRUE,2,'2023-12-02'),
                  (21,'22-37394',FALSE,3,'2023-12-02'),

                  (22,'23-33787',TRUE,1,'2023-12-02'),
                  (23,'23-33787',TRUE,6,'2023-12-03'),
                  (24,'23-33787',FALSE,2,null),

                  (25,'22-31258',TRUE,1,'2023-12-04'),
                  (26,'22-31258',TRUE,6,'2023-12-04'),
                  (27,'22-31258',FALSE,2,null),
  
                  (28,'22-35120',TRUE,1,'2023-12-05'),
                  (29,'22-35120',TRUE,6,'2023-12-10'),
                  (30,'22-35120',FALSE,2,null),

                  (31,'22-38748',TRUE,1,'2023-12-10'),
                  (32,'22-38748',TRUE,6,'2023-12-10'),
                  (33,'22-38748',TRUE,2,'2023-12-10'),
                  (34,'22-38748',TRUE,3,'2023-12-10'),
                  (35,'22-38748',FALSE,7,null),

                  (36,'22-35628',TRUE,1,'2023-12-10'),
                  (37,'22-35628',TRUE,6,'2023-12-10'),
                  (38,'22-35628',TRUE,2,'2023-12-10'),
                  (39,'22-35628',TRUE,3,'2023-12-10'),
                  (40,'22-35628',TRUE,7,'2023-12-10'),
                  (41,'22-35628',FALSE,4,null),

                  (42,'22-35610',TRUE,1,'2023-12-10'),
                  (43,'22-35610',TRUE,6,'2023-12-10'),
                  (44,'22-35610',TRUE,2,'2023-12-10'),
                  (45,'22-35610',TRUE,3,'2023-12-10'),
                  (46,'22-35610',TRUE,7,'2023-12-10'),
                  (47,'22-35610',TRUE,4,'2023-12-10'),
                  (48,'22-35610',FALSE,5,null),

                  (49,'22-34005',TRUE,1,'2023-12-10'),
                  (50,'22-34005',TRUE,6,'2023-12-10'),
                  (51,'22-34005',TRUE,2,'2023-12-10'),
                  (52,'22-34005',TRUE,3,'2023-12-10'),
                  (53,'22-34005',TRUE,7,'2023-12-10'),
                  (54,'22-34005',TRUE,4,'2023-12-10'),
                  (55,'22-34005',TRUE,5,'2023-12-10'),
                  (56,'22-34005',TRUE,8,'2023-12-10'),
                  (57,'22-34005',TRUE,9,'2023-12-10'),
                  (58,'22-34005',TRUE,10,'2023-12-10');";

                MySqlCommand insertRECORDSCMD = new MySqlCommand(insertRECORDS, mysqlConnection);
                insertRECORDSCMD.ExecuteNonQuery();

                MessageBox.Show("Success");

            }
            catch (Exception ex)//---If unsuccessecful, will show what error it is and will be stored in the ex var
            {
                MessageBox.Show(ex.Message, "FAILED..DUPLICATE DATA!");//will show the eror
            }
            finally//This will proceed whatever prosecuted, may it be try OR catch
            {
                mysqlConnection.Close();
            }            
        }
    }
}
