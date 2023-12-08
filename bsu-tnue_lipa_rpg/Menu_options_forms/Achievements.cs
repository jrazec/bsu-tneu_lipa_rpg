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

namespace bsu_tnue_lipa_rpg.Menu_options_forms
{
    public partial class Achievements : Form
    {
        public Achievements()
        {
            InitializeComponent();
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.Enabled = false;
            }
            else if (Facade.instance.Visible)
            {
                Facade.instance.Enabled = false;
            }
            else if (Map.instance.Visible)
            {
                Map.instance.Enabled = false;
            }
            else if (CECS_bldg.instance.Visible)
            {
                CECS_bldg.instance.Enabled = false;
            }
            else if (Old_Bldg.instance.Visible)
            {
                Old_Bldg.instance.Enabled = false;
            }
        }
        private void displayAchievs()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctItemNames = $@"
                        SELECT items.item_name AS name,items.item_class AS class, items.item_id AS id
                        FROM items 
                        INNER JOIN student_items
                        ON student_items.item_id=items.item_id
                        INNER JOIN students
                        ON student_items.sr_code=students.sr_code
                        WHERE students.sr_code = '{Form1.STUDENT_USER_SR_CODE}'
                        ORDER BY class,name;";
            try
            {

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
        private void close_btn_Click(object sender, EventArgs e)
        {
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Bedroom.instance.achievs_lbl);
                Bedroom.instance.Enabled = true;
            }

            else if (Facade.instance.Visible)
            {
                Facade.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Facade.instance.achievs_lbl);
                Facade.instance.Enabled = true;
            }

            else if (Map.instance.Visible)
            {
                Map.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Map.instance.achievs_lbl);
                Map.instance.Enabled = true;
            }


            else if (CECS_bldg.instance.Visible)
            {
                CECS_bldg.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(CECS_bldg.instance.achievs_lbl);
                CECS_bldg.instance.Enabled = true;
            }

            else if (Old_Bldg.instance.Visible)
            {
                Old_Bldg.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Old_Bldg.instance.achievs_lbl);
                Old_Bldg.instance.Enabled = true;
            }

            this.Close();
        }
    }
}
