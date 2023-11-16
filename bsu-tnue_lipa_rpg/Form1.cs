using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bsu_tnue_lipa_rpg
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            string mysqlConn= "server=127.0.0.1; user=root; database=bsu-tnue_lipa_rpg_database; password=";//cam create a function for this
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlConn);
            try
            {//try to open the sql connection
                mysqlConnection.Open();
                //MessageBox.Show("Success");
            }
            catch (Exception ex)
            {//if uncessecful, will show what error it is and will be stored in the ex var
                MessageBox.Show(ex.Message);//will show the eror
                //mysqlConnection.Close();
                //this.Close();
            }
            finally
            {//after try OR catch is done, this will prosecute
                mysqlConnection.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in logIn = new Log_in();
            logIn.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up signUp = new Sign_up();
            signUp.ShowDialog();
            this.Close();
        }
    }
}
