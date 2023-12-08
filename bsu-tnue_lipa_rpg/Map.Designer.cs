namespace bsu_tnue_lipa_rpg
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hint_lbl = new System.Windows.Forms.Label();
            this.day_lbl = new System.Windows.Forms.Label();
            this.hint_pbox = new System.Windows.Forms.PictureBox();
            this.currency_lbl = new System.Windows.Forms.Label();
            this.menu_pbox = new System.Windows.Forms.PictureBox();
            this.map_charac = new System.Windows.Forms.PictureBox();
            this.mapWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.cecscollision_pbox = new System.Windows.Forms.PictureBox();
            this.obcollision_pbox = new System.Windows.Forms.PictureBox();
            this.dg_pbox = new System.Windows.Forms.PictureBox();
            this.dg_map = new System.Windows.Forms.Label();
            this.next_pbox = new System.Windows.Forms.PictureBox();
            this.click_lbl = new System.Windows.Forms.Label();
            this.enter_lbl = new System.Windows.Forms.Label();
            this.viewmenu_panel = new System.Windows.Forms.Panel();
            this.return_label = new System.Windows.Forms.Label();
            this.achievs_lbl = new System.Windows.Forms.Label();
            this.tasks_lbl = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.ign_lbl = new System.Windows.Forms.Label();
            this.hint_panel = new System.Windows.Forms.Panel();
            this.hinttext_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hint_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecscollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_pbox)).BeginInit();
            this.viewmenu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.profile_panel.SuspendLayout();
            this.hint_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.hint_lbl);
            this.panel1.Controls.Add(this.day_lbl);
            this.panel1.Controls.Add(this.hint_pbox);
            this.panel1.Controls.Add(this.currency_lbl);
            this.panel1.Controls.Add(this.menu_pbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 50);
            this.panel1.TabIndex = 0;
            // 
            // hint_lbl
            // 
            this.hint_lbl.AutoSize = true;
            this.hint_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hint_lbl.Location = new System.Drawing.Point(1019, 9);
            this.hint_lbl.Name = "hint_lbl";
            this.hint_lbl.Size = new System.Drawing.Size(58, 34);
            this.hint_lbl.TabIndex = 19;
            this.hint_lbl.Text = "Hint";
            // 
            // day_lbl
            // 
            this.day_lbl.AutoSize = true;
            this.day_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.day_lbl.Location = new System.Drawing.Point(147, 9);
            this.day_lbl.Name = "day_lbl";
            this.day_lbl.Size = new System.Drawing.Size(99, 34);
            this.day_lbl.TabIndex = 15;
            this.day_lbl.Text = "Monday";
            // 
            // hint_pbox
            // 
            this.hint_pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hint_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.hint_icon;
            this.hint_pbox.Location = new System.Drawing.Point(978, 9);
            this.hint_pbox.Name = "hint_pbox";
            this.hint_pbox.Size = new System.Drawing.Size(44, 34);
            this.hint_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hint_pbox.TabIndex = 18;
            this.hint_pbox.TabStop = false;
            this.hint_pbox.Click += new System.EventHandler(this.hint_pbox_Click);
            // 
            // currency_lbl
            // 
            this.currency_lbl.AutoSize = true;
            this.currency_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currency_lbl.Location = new System.Drawing.Point(776, 9);
            this.currency_lbl.Name = "currency_lbl";
            this.currency_lbl.Size = new System.Drawing.Size(83, 34);
            this.currency_lbl.TabIndex = 16;
            this.currency_lbl.Text = "₱ 0.00";
            // 
            // menu_pbox
            // 
            this.menu_pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.menu_icon;
            this.menu_pbox.Location = new System.Drawing.Point(10, 8);
            this.menu_pbox.Name = "menu_pbox";
            this.menu_pbox.Size = new System.Drawing.Size(44, 34);
            this.menu_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_pbox.TabIndex = 17;
            this.menu_pbox.TabStop = false;
            this.menu_pbox.Click += new System.EventHandler(this.menu_pbox_Click);
            // 
            // map_charac
            // 
            this.map_charac.BackColor = System.Drawing.Color.Transparent;
            this.map_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.male_uni_front;
            this.map_charac.Location = new System.Drawing.Point(493, 426);
            this.map_charac.Name = "map_charac";
            this.map_charac.Size = new System.Drawing.Size(46, 66);
            this.map_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map_charac.TabIndex = 1;
            this.map_charac.TabStop = false;
            // 
            // mapWalkTimer
            // 
            this.mapWalkTimer.Interval = 75;
            this.mapWalkTimer.Tick += new System.EventHandler(this.mapWalkTimer_Tick);
            // 
            // cecscollision_pbox
            // 
            this.cecscollision_pbox.Location = new System.Drawing.Point(159, 370);
            this.cecscollision_pbox.Name = "cecscollision_pbox";
            this.cecscollision_pbox.Size = new System.Drawing.Size(48, 213);
            this.cecscollision_pbox.TabIndex = 2;
            this.cecscollision_pbox.TabStop = false;
            this.cecscollision_pbox.Tag = "cecs";
            // 
            // obcollision_pbox
            // 
            this.obcollision_pbox.Location = new System.Drawing.Point(977, 212);
            this.obcollision_pbox.Name = "obcollision_pbox";
            this.obcollision_pbox.Size = new System.Drawing.Size(48, 125);
            this.obcollision_pbox.TabIndex = 3;
            this.obcollision_pbox.TabStop = false;
            this.obcollision_pbox.Tag = "ob";
            // 
            // dg_pbox
            // 
            this.dg_pbox.BackColor = System.Drawing.Color.Transparent;
            this.dg_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.dialogue_base;
            this.dg_pbox.Location = new System.Drawing.Point(133, 470);
            this.dg_pbox.Name = "dg_pbox";
            this.dg_pbox.Size = new System.Drawing.Size(903, 194);
            this.dg_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dg_pbox.TabIndex = 4;
            this.dg_pbox.TabStop = false;
            // 
            // dg_map
            // 
            this.dg_map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dg_map.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_map.ForeColor = System.Drawing.Color.White;
            this.dg_map.Location = new System.Drawing.Point(171, 521);
            this.dg_map.Name = "dg_map";
            this.dg_map.Size = new System.Drawing.Size(827, 97);
            this.dg_map.TabIndex = 6;
            this.dg_map.Text = "Good morning, Red Spartan! \r\nYour first task today is to attend your Database cla" +
    "ss.  Your proctor will be Sir Tiquio for 7am - 10 am.  In your schedule, your ro" +
    "om is at CECS Building, Room 401.";
            // 
            // next_pbox
            // 
            this.next_pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_pbox.Location = new System.Drawing.Point(971, 595);
            this.next_pbox.Name = "next_pbox";
            this.next_pbox.Size = new System.Drawing.Size(33, 32);
            this.next_pbox.TabIndex = 10;
            this.next_pbox.TabStop = false;
            this.next_pbox.Click += new System.EventHandler(this.next_pbox_Click);
            // 
            // click_lbl
            // 
            this.click_lbl.AutoSize = true;
            this.click_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.click_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_lbl.ForeColor = System.Drawing.Color.White;
            this.click_lbl.Location = new System.Drawing.Point(863, 603);
            this.click_lbl.Name = "click_lbl";
            this.click_lbl.Size = new System.Drawing.Size(124, 24);
            this.click_lbl.TabIndex = 11;
            this.click_lbl.Text = "Click to proceed..";
            // 
            // enter_lbl
            // 
            this.enter_lbl.AutoSize = true;
            this.enter_lbl.BackColor = System.Drawing.Color.Maroon;
            this.enter_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_lbl.ForeColor = System.Drawing.Color.White;
            this.enter_lbl.Location = new System.Drawing.Point(947, 599);
            this.enter_lbl.Name = "enter_lbl";
            this.enter_lbl.Size = new System.Drawing.Size(59, 28);
            this.enter_lbl.TabIndex = 14;
            this.enter_lbl.Text = "ENTER";
            this.enter_lbl.Visible = false;
            this.enter_lbl.Click += new System.EventHandler(this.enter_lbl_Click);
            // 
            // viewmenu_panel
            // 
            this.viewmenu_panel.BackColor = System.Drawing.Color.White;
            this.viewmenu_panel.Controls.Add(this.return_label);
            this.viewmenu_panel.Controls.Add(this.achievs_lbl);
            this.viewmenu_panel.Controls.Add(this.tasks_lbl);
            this.viewmenu_panel.Controls.Add(this.pictureBox6);
            this.viewmenu_panel.Controls.Add(this.label5);
            this.viewmenu_panel.Controls.Add(this.profile_panel);
            this.viewmenu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewmenu_panel.Location = new System.Drawing.Point(0, 50);
            this.viewmenu_panel.Name = "viewmenu_panel";
            this.viewmenu_panel.Size = new System.Drawing.Size(208, 589);
            this.viewmenu_panel.TabIndex = 17;
            this.viewmenu_panel.Visible = false;
            // 
            // return_label
            // 
            this.return_label.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_label.Location = new System.Drawing.Point(0, 333);
            this.return_label.Name = "return_label";
            this.return_label.Size = new System.Drawing.Size(208, 59);
            this.return_label.TabIndex = 29;
            this.return_label.Text = "Main Menu";
            this.return_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.return_label.Click += new System.EventHandler(this.return_label_Click);
            this.return_label.MouseEnter += new System.EventHandler(this.return_hoverin);
            this.return_label.MouseLeave += new System.EventHandler(this.return_hoverout);
            // 
            // achievs_lbl
            // 
            this.achievs_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievs_lbl.Location = new System.Drawing.Point(0, 255);
            this.achievs_lbl.Name = "achievs_lbl";
            this.achievs_lbl.Size = new System.Drawing.Size(208, 59);
            this.achievs_lbl.TabIndex = 28;
            this.achievs_lbl.Text = "Achievements";
            this.achievs_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.achievs_lbl.Click += new System.EventHandler(this.achievs_lbl_Click);
            this.achievs_lbl.MouseEnter += new System.EventHandler(this.achievs_hoverin);
            this.achievs_lbl.MouseLeave += new System.EventHandler(this.achievs_hoverout);
            // 
            // tasks_lbl
            // 
            this.tasks_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_lbl.Location = new System.Drawing.Point(0, 178);
            this.tasks_lbl.Name = "tasks_lbl";
            this.tasks_lbl.Size = new System.Drawing.Size(208, 59);
            this.tasks_lbl.TabIndex = 27;
            this.tasks_lbl.Text = "Tasks";
            this.tasks_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tasks_lbl.Click += new System.EventHandler(this.tasks_lbl_Click);
            this.tasks_lbl.MouseEnter += new System.EventHandler(this.tasks_hoverin);
            this.tasks_lbl.MouseLeave += new System.EventHandler(this.tasks_hoverout);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox6.Image = global::bsu_tnue_lipa_rpg.Properties.Resources._111_01;
            this.pictureBox6.Location = new System.Drawing.Point(18, 555);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(55, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "RazBerYie";
            // 
            // profile_panel
            // 
            this.profile_panel.BackColor = System.Drawing.Color.Maroon;
            this.profile_panel.Controls.Add(this.ign_lbl);
            this.profile_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_panel.Location = new System.Drawing.Point(0, 0);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(208, 127);
            this.profile_panel.TabIndex = 16;
            // 
            // ign_lbl
            // 
            this.ign_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ign_lbl.ForeColor = System.Drawing.Color.White;
            this.ign_lbl.Location = new System.Drawing.Point(12, 23);
            this.ign_lbl.Name = "ign_lbl";
            this.ign_lbl.Size = new System.Drawing.Size(182, 68);
            this.ign_lbl.TabIndex = 0;
            this.ign_lbl.Text = "Hello, [IGN]\r\n\r\n[fullname] | [sr-code]";
            this.ign_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hint_panel
            // 
            this.hint_panel.Controls.Add(this.hinttext_lbl);
            this.hint_panel.Location = new System.Drawing.Point(784, 50);
            this.hint_panel.Name = "hint_panel";
            this.hint_panel.Size = new System.Drawing.Size(366, 104);
            this.hint_panel.TabIndex = 18;
            this.hint_panel.Visible = false;
            // 
            // hinttext_lbl
            // 
            this.hinttext_lbl.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinttext_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.hinttext_lbl.Location = new System.Drawing.Point(14, 12);
            this.hinttext_lbl.Name = "hinttext_lbl";
            this.hinttext_lbl.Size = new System.Drawing.Size(341, 79);
            this.hinttext_lbl.TabIndex = 0;
            this.hinttext_lbl.Text = "Hint goes here...";
            this.hinttext_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.map_art;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.hint_panel);
            this.Controls.Add(this.viewmenu_panel);
            this.Controls.Add(this.map_charac);
            this.Controls.Add(this.enter_lbl);
            this.Controls.Add(this.next_pbox);
            this.Controls.Add(this.click_lbl);
            this.Controls.Add(this.dg_map);
            this.Controls.Add(this.dg_pbox);
            this.Controls.Add(this.obcollision_pbox);
            this.Controls.Add(this.cecscollision_pbox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hint_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecscollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_pbox)).EndInit();
            this.viewmenu_panel.ResumeLayout(false);
            this.viewmenu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.profile_panel.ResumeLayout(false);
            this.hint_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox map_charac;
        public System.Windows.Forms.Timer mapWalkTimer;
        private System.Windows.Forms.PictureBox cecscollision_pbox;
        private System.Windows.Forms.PictureBox obcollision_pbox;
        private System.Windows.Forms.PictureBox dg_pbox;
        public System.Windows.Forms.Label dg_map;
        public System.Windows.Forms.PictureBox next_pbox;
        public System.Windows.Forms.Label click_lbl;
        public System.Windows.Forms.Label enter_lbl;
        public System.Windows.Forms.Label hint_lbl;
        public System.Windows.Forms.Label day_lbl;
        public System.Windows.Forms.PictureBox hint_pbox;
        public System.Windows.Forms.Label currency_lbl;
        private System.Windows.Forms.PictureBox menu_pbox;
        private System.Windows.Forms.Panel viewmenu_panel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.Label ign_lbl;
        private System.Windows.Forms.Panel hint_panel;
        private System.Windows.Forms.Label hinttext_lbl;
        public System.Windows.Forms.Label return_label;
        public System.Windows.Forms.Label achievs_lbl;
        public System.Windows.Forms.Label tasks_lbl;
    }
}