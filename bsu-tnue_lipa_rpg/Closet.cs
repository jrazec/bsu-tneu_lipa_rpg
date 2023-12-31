﻿using bsu_tnue_lipa_rpg.Closet_garments_uc;
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
        public const int ALLITEMCOUNT = 13;
        public int itemCount;
        public bool taskStat;
        public static Closet instance;
        /*
         Dito ilalagay ung achievement na nabili na lahat ni player ung lahat ng garments
         */



        //Initialized them at first inorder to create the instance firsthand
        top top_uc = new top();
        bottom bot_uc = new bottom();
        neck neck_uc = new neck();
        shoes shoes_uc = new shoes();

        //Array to check if the player wears the correct garments for the day
        public static string[,]
            GARMENTS_FOR_DAY = {
                        //0         1       2       3
                        {"top",    "bot",  "neck","shoes"},//serves as attributes     
                        {"uni-top","uni-bot","id","gen-shoes"},//For monday       - 1   
                        {"uni-top","uni-bot","id","gen-shoes"},//For tuesday      - 2
                        {"org-top","org-bot","id","w-shoes"},//For wednesday    - 3   
                        {"uni-top","uni-bot","id","gen-shoes"},//For thursday     - 4 
                        {"pe-top", "pe-bot", "id","w-shoes"}//For friday        - 5
                        };
        //i = day_id & j = item_class


        //Array to prevent user from mix & matching unmatched garments
        public static string[,]
            GARMENTS_MATCH = {
                        //0           1            2      3    
                        {"uni-top","uni-bot","gen-shoes","id"},//For uni      - 0   
                        {"org-top","org-bot","w-shoes","id"},//For org        - 1
                        {"cas-top","cas-bot","cas-shoes","id"},//For casual   - 2   
                        {"pe-top" ,"pe-bot" ,"w-shoes","id"}//For pe          - 3 
                        };

        public static string[,] Garments_Worn = new string[1, 4];

        //i = category, j = records
        public string[,] ITEMS = new string[4, 15];// this is HOW TO DECLARE MULTIDIMENSIONAL ARRAY!?
        public int[,] ITEM_ID = new int[4, 15];
        public string[,] ITEM_DESC = new string[4, 15];
        public double[,] ITEM_PRICE = new double[4, 15];
        public bool[,] ITEM_OWN = new bool[4, 15];
        public Closet()
        {
            InitializeComponent();
            addUC(top_uc);
            displayItemNames();
            displayItemDesc();
            day_lbl.Text = Bedroom.instance.DAY;
            instance = this;
            
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
            //THIS IS PANGDRESS SA CHARAC ONCE THE PLAYER LEFT THE CLOSET

            //IF THE PLAYER WORN THE CORRECT PAIRED GARMENTS
            if ((GARMENTS_MATCH[0, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[0, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[0, 2] == Garments_Worn[0, 3] && GARMENTS_MATCH[0, 3] == Garments_Worn[0, 2]) ||
                (GARMENTS_MATCH[1, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[1, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[1, 2] == Garments_Worn[0, 3] && GARMENTS_MATCH[1, 3] == Garments_Worn[0, 2]) ||
                (GARMENTS_MATCH[2, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[2, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[2, 2] == Garments_Worn[0, 3] && GARMENTS_MATCH[2, 3] == Garments_Worn[0, 2]) ||
                (GARMENTS_MATCH[3, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[3, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[3, 2] == Garments_Worn[0, 3] && GARMENTS_MATCH[3, 3] == Garments_Worn[0, 2])   )
            {


                if ((GARMENTS_MATCH[0, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[0, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[0, 2] == Garments_Worn[0, 3]))
                {
                    Bedroom.instance.CHARAC_CLOTHES = "UNI";
                }
                else if ((GARMENTS_MATCH[1, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[1, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[1, 2] == Garments_Worn[0, 3]))
                {
                    Bedroom.instance.CHARAC_CLOTHES = "ORG";
                }
                else if ((GARMENTS_MATCH[2, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[2, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[2, 2] == Garments_Worn[0, 3]))
                {
                    Bedroom.instance.CHARAC_CLOTHES = "CASUAL";
                }
                else if ((GARMENTS_MATCH[3, 0] == Garments_Worn[0, 0] && GARMENTS_MATCH[3, 1] == Garments_Worn[0, 1] && GARMENTS_MATCH[3, 2] == Garments_Worn[0, 3]))
                {
                    Bedroom.instance.CHARAC_CLOTHES = "PE";
                }
                else
                {
                    Bedroom.instance.CHARAC_CLOTHES = "CASUAL";
                }

                Bedroom.instance.checkMoney();
                Bedroom.instance.characBack(Bedroom.instance.bedroom_charac);
                this.Hide();
                Bedroom.instance.Show();//to load the recent form
                Bedroom.instance.bedroomWalkTimer.Start();//to access the bedroom timer;made this public in designer.cs
                this.Close();
            }

            //IF THE PLAYER DIDNT WEAR THE CORRECT GARMENTS
            else
            {
                //IF THE PLAYER DOENST WEAR ANY OF THESE GARMENTS
                if (Garments_Worn[0, 0] == null || Garments_Worn[0, 1] == null || Garments_Worn[0, 2] == null || Garments_Worn[0, 3] == null ||
                    Garments_Worn[0, 0] == ""   || Garments_Worn[0, 1] == ""   || Garments_Worn[0, 2] == ""   || Garments_Worn[0, 3] == ""     )
                {
                    MessageBox.Show("Wear your garments!");
                }
                //IF THE PLAYER MIX & MATCH UNPAIRED GARMENTS
                else
                {
                    MessageBox.Show("Don't mix & match garments! This isn't Mcdo");
                }
            }

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

        private void displayItemNames()
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
                mysqlConnection.Open();
                MySqlCommand slctItemNamesCmd = new MySqlCommand(slctItemNames, mysqlConnection);

                using (MySqlDataReader reader = slctItemNamesCmd.ExecuteReader())
                {
                    int TOP = 0;
                    int BOT = 0;
                    int NECK = 0;
                    int SHOES = 0;

                    while (reader.Read())
                    {
                        if ((string)reader["class"] == "Top")
                        {
                            ITEMS[0, TOP] = (string)reader["name"];
                            ITEM_ID[0, TOP]= (int)reader["id"];
                            TOP++;
                        }
                        else if ((string)reader["class"] == "Bottom")
                        {
                            ITEMS[1, BOT] = (string)reader["name"];
                            ITEM_ID[1, BOT] = (int)reader["id"];
                            BOT++;
                        }
                        else if ((string)reader["class"] == "Neck")
                        {
                            ITEMS[2, NECK] = (string)reader["name"];
                            ITEM_ID[2, NECK] = (int)reader["id"];
                            NECK++;
                        }
                        else if ((string)reader["class"] == "Shoes")
                        {
                            ITEMS[3, SHOES] = (string)reader["name"];
                            ITEM_ID[3, SHOES] = (int)reader["id"];
                            SHOES++;
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
            top.instance.top1_lbl.Text = ITEMS[0, 0];
            top.instance.top2_lbl.Text = ITEMS[0, 1];
            top.instance.top3_lbl.Text = ITEMS[0, 2];
            top.instance.top4_lbl.Text = ITEMS[0, 3];
            bottom.instance.bot1_lbl.Text = ITEMS[1, 0];
            bottom.instance.bot2_lbl.Text = ITEMS[1, 1];
            bottom.instance.bot3_lbl.Text = ITEMS[1, 2];
            bottom.instance.bot4_lbl.Text = ITEMS[1, 3];
            neck.instance.neck1_lbl.Text = ITEMS[2, 0];
            neck.instance.neck2_lbl.Text = ITEMS[2, 1];
            shoes.instance.shoes1_lbl.Text = ITEMS[3, 0];
            shoes.instance.shoes2_lbl.Text = ITEMS[3, 1];
            shoes.instance.shoes3_lbl.Text = ITEMS[3, 2];
        }


        public void displayItemDesc()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctItemDesc = $@"
                            SELECT items.item_desc AS dsc,items.item_class AS class,student_items.is_owned AS own, items.item_price AS price
                            FROM items 
                            INNER JOIN student_items
                            ON student_items.item_id=items.item_id
                            INNER JOIN students
                            ON student_items.sr_code=students.sr_code
                            WHERE students.sr_code = '{Form1.STUDENT_USER_SR_CODE}'
                            ORDER BY class,items.item_name;";

            string slctItemCount = $@"
                SELECT COUNT(student_items.student_item_id) AS itmCount
                FROM student_items
                WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}'
                AND is_owned=true;";

            try
            {
                mysqlConnection.Open();
                MySqlCommand slctItemDescCmd = new MySqlCommand(slctItemDesc, mysqlConnection);

                using (MySqlDataReader reader = slctItemDescCmd.ExecuteReader())
                {
                    int TOP = 0;
                    int BOT = 0;
                    int NECK = 0;
                    int SHOES = 0;
                    while (reader.Read())
                    {
                        if ((string)reader["class"] == "Top")
                        {
                            if ((bool)reader["own"])
                            {
                                ITEM_DESC[0, TOP] = (string)reader["dsc"];
                                if (TOP == 0)
                                {
                                    top.instance.top1_pbox.Enabled = true;
                                }
                                else if (TOP == 1)
                                {
                                    top.instance.top2_pbox.Enabled = true;
                                }
                                else if (TOP == 2)
                                {
                                    top.instance.top3_pbox.Enabled = true;
                                }
                                else if (TOP == 3)
                                {
                                    top.instance.top4_pbox.Enabled = true;
                                }
                            }
                            else
                            {
                                ITEM_DESC[0, TOP] = "Unlock";
                                if(TOP == 0)
                                {
                                    top.instance.top1_pbox.Enabled = false;
                                }else if (TOP == 1)
                                {
                                    top.instance.top2_pbox.Enabled = false;
                                }else if (TOP == 2)
                                {
                                    top.instance.top3_pbox.Enabled = false;
                                }
                                else if(TOP == 3)
                                {
                                    top.instance.top4_pbox.Enabled = false;
                                }
                            }
                            ITEM_PRICE[0, TOP] = Convert.ToDouble(reader["price"]);
                            ITEM_OWN[0, TOP] = (bool)reader["own"];
                            TOP++;
                        }
                        else if ((string)reader["class"] == "Bottom")
                        {
                            if ((bool)reader["own"])
                            {
                                ITEM_DESC[1, BOT] = (string)reader["dsc"];
                                if (BOT == 0)
                                {
                                    bottom.instance.bottom1_pbox.Enabled = true;
                                }
                                else if (BOT == 1)
                                {
                                    bottom.instance.bottom2_pbox.Enabled = true;
                                }
                                else if (BOT == 2)
                                {
                                    bottom.instance.bottom3_pbox.Enabled = true;
                                }
                                else if (BOT == 3)
                                {
                                    bottom.instance.bottom4_pbox.Enabled = true;
                                }
                            }
                            else
                            {
                                ITEM_DESC[1, BOT] = "Unlock";
                                if (BOT == 0)
                                {
                                    bottom.instance.bottom1_pbox.Enabled = false;
                                }
                                else if (BOT == 1)
                                {
                                    bottom.instance.bottom2_pbox.Enabled = false;
                                }
                                else if (BOT == 2)
                                {
                                    bottom.instance.bottom3_pbox.Enabled = false;
                                }
                                else if(BOT == 3)
                                {
                                    bottom.instance.bottom4_pbox.Enabled = false;
                                }
                            }
                            ITEM_PRICE[1, BOT] = Convert.ToDouble(reader["price"]);
                            ITEM_OWN[1, BOT] = (bool)reader["own"];
                            BOT++;
                        }
                        else if ((string)reader["class"] == "Neck")
                        {
                            if ((bool)reader["own"])
                            {
                                ITEM_DESC[2, NECK] = (string)reader["dsc"];
                                if (NECK == 0)
                                {
                                    neck.instance.neck1_pbox.Enabled = true;
                                }
                                else if (NECK == 1)
                                {
                                    neck.instance.neck2_pbox.Enabled = true;
                                }
                            }
                            else
                            {
                                ITEM_DESC[2, NECK] = "Unlock";
                                if (NECK == 0)
                                {
                                    neck.instance.neck1_pbox.Enabled = false;
                                }
                                else if (NECK == 1)
                                {
                                    neck.instance.neck2_pbox.Enabled = false;
                                }
                            }
                            ITEM_PRICE[2, NECK] = Convert.ToDouble(reader["price"]);
                            ITEM_OWN[2, NECK] = (bool)reader["own"];
                            NECK++;
                        }
                        else if ((string)reader["class"] == "Shoes")
                        {
                            if ((bool)reader["own"])
                            {
                                ITEM_DESC[3, SHOES] = (string)reader["dsc"];
                                if (SHOES == 0)
                                {
                                    shoes.instance.shoes1_pbox.Enabled = true;
                                }
                                else if (SHOES == 1)
                                {
                                    shoes.instance.shoes2_pbox.Enabled = true;
                                }
                                else if (SHOES == 2)
                                {
                                    shoes.instance.shoes3_pbox.Enabled = true;
                                }
                            }
                            else
                            {
                                ITEM_DESC[3, SHOES] = "Unlock";
                                if (SHOES == 0)
                                {
                                    shoes.instance.shoes1_pbox.Enabled = false;
                                }
                                else if (SHOES == 1)
                                {
                                    shoes.instance.shoes2_pbox.Enabled = false;
                                }
                                else if (SHOES == 2)
                                {
                                    shoes.instance.shoes3_pbox.Enabled = false;
                                }
                            }
                            ITEM_PRICE[3, SHOES] = Convert.ToDouble(reader["price"]);
                            ITEM_OWN[3, SHOES] = (bool)reader["own"];
                            SHOES++;
                        }
                    }
                }
                top.instance.top1_desc.Text = ITEM_DESC[0, 0];
                top.instance.top2_desc.Text = ITEM_DESC[0, 1];
                top.instance.top3_desc.Text = ITEM_DESC[0, 2];
                top.instance.top4_desc.Text = ITEM_DESC[0, 3];
                bottom.instance.bot1_desc.Text = ITEM_DESC[1, 0];
                bottom.instance.bot2_desc.Text = ITEM_DESC[1, 1];
                bottom.instance.bot3_desc.Text = ITEM_DESC[1, 2];
                bottom.instance.bot4_desc.Text = ITEM_DESC[1, 3];
                neck.instance.neck1_desc.Text = ITEM_DESC[2, 0];
                neck.instance.neck2_desc.Text = ITEM_DESC[2, 1];
                shoes.instance.shoes1_desc.Text = ITEM_DESC[3, 0];
                shoes.instance.shoes2_desc.Text = ITEM_DESC[3, 1];
                shoes.instance.shoes3_desc.Text = ITEM_DESC[3, 2];

                MySqlCommand slctItemCountCmd = new MySqlCommand(slctItemCount, mysqlConnection);

                using (MySqlDataReader reader = slctItemCountCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        itemCount = Convert.ToInt32(reader["itmCount"]);
                    }
                }
                if(ALLITEMCOUNT == itemCount)
                {
                    top.instance.top1_desc.Enabled = false;
                    top.instance.top2_desc.Enabled = false;
                    top.instance.top3_desc.Enabled = false;
                    top.instance.top4_desc.Enabled = false;
                    bottom.instance.bot1_desc.Enabled = false;
                    bottom.instance.bot2_desc.Enabled = false;
                    bottom.instance.bot3_desc.Enabled = false;
                    bottom.instance.bot4_desc.Enabled = false;
                    neck.instance.neck1_desc.Enabled = false;
                    neck.instance.neck2_desc.Enabled = false;
                    shoes.instance.shoes1_desc.Enabled = false;
                    shoes.instance.shoes2_desc.Enabled = false;
                    shoes.instance.shoes3_desc.Enabled = false;
                    insertAchs();
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

        public void insertAchs()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctGamplayRecords = $@"
                SELECT gameplay_records.status AS sts
                FROM gameplay_records
                WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}'
                AND task_id=10;";
            string insertAchievements = $@"
                INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',9,CURRENT_DATE,true);
                INSERT INTO gameplay_records(sr_code,task_id,date_finished,status)
                VALUES ('{Form1.STUDENT_USER_SR_CODE}',10,CURRENT_DATE,true);";

            try
            {
                mysqlConnection.Open();

                MySqlCommand slctGamplayRecordsCmd = new MySqlCommand(slctGamplayRecords, mysqlConnection);

                using (MySqlDataReader reader = slctGamplayRecordsCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        taskStat = (bool)reader["sts"];
                    }
                }
                if (!taskStat)
                {
                    MySqlCommand insertAchievementsCmd = new MySqlCommand(insertAchievements, mysqlConnection);
                    insertAchievementsCmd.ExecuteNonQuery();
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

        public void buyItems(string sr, int id)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);//for tb

            try//---Try to open the sql connection
            {
                mysqlConnection.Open();
                string updtStudItem = $"UPDATE student_items SET is_owned=true WHERE sr_code = '{sr}' AND item_id = {id};";
                MySqlCommand updtStudItemCmd = new MySqlCommand(updtStudItem, mysqlConnection);
                updtStudItemCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mysqlConnection.Close(); }
        }

        public void refundItems(string sr, int id)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);//for tb

            try//---Try to open the sql connection
            {
                mysqlConnection.Open();
                string updtStudItem = $"UPDATE student_items SET is_owned=false WHERE sr_code = '{sr}' AND item_id = {id};";
                MySqlCommand updtStudItemCmd = new MySqlCommand(updtStudItem, mysqlConnection);
                updtStudItemCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mysqlConnection.Close(); }
        }

        public void add_minusMoney(double money)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);//for tb
            

            try//---Try to open the sql connection
            {
                mysqlConnection.Open();
                string updtCurrMon = $"UPDATE students SET current_money={money} WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}';";
                MySqlCommand updtCurrMonCmd = new MySqlCommand(updtCurrMon, mysqlConnection);
                updtCurrMonCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mysqlConnection.Close(); }
        }
        public void buy_refundItems(double[,] ITEM_PRICE,string[,] ITEMS,int i, int j,Form1.callback callback)
        {
            //IF NOT OWN
            if (!ITEM_OWN[i, j])
            {
                DialogResult buy = MessageBox.Show($"This item cost: {ITEM_PRICE[i, j]:C}", "Buying", MessageBoxButtons.YesNo);
                if (buy == DialogResult.Yes)
                {
                    if (Bedroom.instance.CURRENT_MONEY < ITEM_PRICE[i, j])
                    {
                        MessageBox.Show("Not Enough Pera :'<", "Awweeee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        double money = Bedroom.instance.CURRENT_MONEY;
                        money = money - ITEM_PRICE[i, j];
                        add_minusMoney(money);
                        buyItems(Form1.STUDENT_USER_SR_CODE, ITEM_ID[i, j]);
                        MessageBox.Show($"You may now wear {ITEMS[i, j]}", "Success!");
                        Bedroom.instance.checkMoney();
                        displayItemDesc();

                    }
                }
            }
            //IF OWN
            else
            {
                DialogResult buy = MessageBox.Show($"Are you sure you want to refund: {ITEM_PRICE[i, j]:C}", "Warning", MessageBoxButtons.YesNo);
                if (buy == DialogResult.Yes)
                {
                        callback();//Ill use this for arrow functionsss
                        double money = Bedroom.instance.CURRENT_MONEY;
                        money = money + ITEM_PRICE[i, j];
                        add_minusMoney(money);
                        refundItems(Form1.STUDENT_USER_SR_CODE, ITEM_ID[i, j]);
                        MessageBox.Show($"{ITEMS[i, j]} Cannot be worn..", "Refunded");
                        Bedroom.instance.checkMoney();
                        displayItemDesc();
                    }
                }
        }
    }
}
