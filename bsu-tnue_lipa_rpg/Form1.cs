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
                MessageBox.Show("Ni open mo na sya dili na error!! nakuha mo man ui!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Dili sya success :< kasi pinatai mo man ung xamp ui!");//will show the eror
            }
            finally
            {
                mysqlConnection.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
