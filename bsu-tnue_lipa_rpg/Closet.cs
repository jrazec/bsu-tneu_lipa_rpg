using bsu_tnue_lipa_rpg.Closet_garments_uc;
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
    public partial class Closet : Form
    {
        #region FIX : PictureBox Flickering!
        //THIS SOLVED THE PROBLEM HUUHUH FINALYY!!!!!!!!!!
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        #endregion

        //Initialized them at first inorder to create the instance firsthand
        top top_uc = new top();
        bottom bot_uc = new bottom();
        neck neck_uc = new neck();
        shoes shoes_uc = new shoes();

        //Array to prevent user from mix & matching unmatched garments
        public string[,] 
            GARMENTS = {
                        //0         1       2       3
                        {"top",    "bot",  "neck","shoes"},//serves as attributes     
                        {"uni-top","uni-bot","id","gen-shoes"},//For monday       - 1   
                        {"uni-top","uni-bot","id","gen-shoes"},//For tuesday      - 2
                        {"org-top","org-bot","id","gen-shoes"},//For wednesday    - 3   
                        {"uni-top","uni-bot","id","gen-shoes"},//For thursday     - 4 
                        {"pe-top", "pe-bot", "id","gen-shoes"},//For friday       - 5
                        };
        public string[,] Garments_Worn;

        public string[][] ITEMS;
        public Closet()
        {
            InitializeComponent();
            addUC(top_uc);
        }
        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            garments_panel.Controls.Clear();
            garments_panel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void backtoroom_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bedroom.instance.Show();//to load the recent form
            Bedroom.instance.bedroomWalkTimer.Start();//to access the bedroom timer;made this public in designer.cs
            this.Close();
        }

        private void top_pbox_Click(object sender, EventArgs e)
        {
            top_uc = top.instance;
            addUC(top_uc);
        }

        private void pants_pbox_Click(object sender, EventArgs e)
        {
            bot_uc = bottom.instance;
            addUC(bot_uc);
        }

        private void necklace_pbox_Click(object sender, EventArgs e)
        {
            neck_uc = neck.instance;
            addUC(neck_uc);
        }

        private void shoes_pbox_Click(object sender, EventArgs e)
        {
           shoes_uc = shoes.instance;
            addUC(shoes_uc);
        }
/*
        private void displayItemNames()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctItemNames = $@"
                ";

            try
            {
                mysqlConnection.Open();
                MySqlCommand slctItemNamesCmd = new MySqlCommand(slctItemNames, mysqlConnection);

                using (MySqlDataReader reader = slctItemNamesCmd.ExecuteReader())
                {
                    int i = 0;
                    int j = 0;
                    while (reader.Read())
                    {
                        ITEMS[i][j] = (string)reader["item"];
                        if(i == 4)
                        {
                            items
                        }
                    }
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
            top.instance.top1_lbl.Text = ITEMS[0][0];
        }
    }

        private void displayItemDesc()
        {

        }
*/
    }
}
