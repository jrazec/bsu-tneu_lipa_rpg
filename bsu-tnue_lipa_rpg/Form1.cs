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
        public Form1()
        {
            InitializeComponent();
            string mysqlConn= "server=127.0.0.1; user=root; database=bsu-tnue_lipa_rpg_database; password=";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlConn);
            try
            {
                mysqlConnection.Open();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//will show the eror
            }
            finally
            {
                mysqlConnection.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_in logInWindow = new Log_in();
            this.Hide();
            logInWindow.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up signUpWindow = new Sign_up();
            this.Hide();
            signUpWindow.Show();
        }
    }
}
