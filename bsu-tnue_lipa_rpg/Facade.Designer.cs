namespace bsu_tnue_lipa_rpg
{
    partial class Facade
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
            this.hint_pbox = new System.Windows.Forms.PictureBox();
            this.currency_lbl = new System.Windows.Forms.Label();
            this.day_lbl = new System.Windows.Forms.Label();
            this.menu_pbox = new System.Windows.Forms.PictureBox();
            this.guard_pbox = new System.Windows.Forms.PictureBox();
            this.facade_charac = new System.Windows.Forms.PictureBox();
            this.interactcollision_pbox = new System.Windows.Forms.PictureBox();
            this.returncollision_pbox = new System.Windows.Forms.PictureBox();
            this.facadeWalkTimer = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.guard_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facade_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interactcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).BeginInit();
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
            this.panel1.Controls.Add(this.hint_pbox);
            this.panel1.Controls.Add(this.currency_lbl);
            this.panel1.Controls.Add(this.day_lbl);
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
            this.hint_lbl.TabIndex = 8;
            this.hint_lbl.Text = "Hint";
            // 
            // hint_pbox
            // 
            this.hint_pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hint_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.hint_icon;
            this.hint_pbox.Location = new System.Drawing.Point(978, 9);
            this.hint_pbox.Name = "hint_pbox";
            this.hint_pbox.Size = new System.Drawing.Size(44, 34);
            this.hint_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hint_pbox.TabIndex = 7;
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
            this.currency_lbl.Size = new System.Drawing.Size(0, 34);
            this.currency_lbl.TabIndex = 6;
            // 
            // day_lbl
            // 
            this.day_lbl.AutoSize = true;
            this.day_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.day_lbl.Location = new System.Drawing.Point(147, 9);
            this.day_lbl.Name = "day_lbl";
            this.day_lbl.Size = new System.Drawing.Size(99, 34);
            this.day_lbl.TabIndex = 5;
            this.day_lbl.Text = "Monday";
            // 
            // menu_pbox
            // 
            this.menu_pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.menu_icon;
            this.menu_pbox.Location = new System.Drawing.Point(10, 8);
            this.menu_pbox.Name = "menu_pbox";
            this.menu_pbox.Size = new System.Drawing.Size(44, 34);
            this.menu_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_pbox.TabIndex = 5;
            this.menu_pbox.TabStop = false;
            this.menu_pbox.Click += new System.EventHandler(this.menu_pbox_Click);
            // 
            // guard_pbox
            // 
            this.guard_pbox.BackColor = System.Drawing.Color.Transparent;
            this.guard_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Guard;
            this.guard_pbox.Location = new System.Drawing.Point(673, 146);
            this.guard_pbox.Name = "guard_pbox";
            this.guard_pbox.Size = new System.Drawing.Size(149, 229);
            this.guard_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guard_pbox.TabIndex = 1;
            this.guard_pbox.TabStop = false;
            // 
            // facade_charac
            // 
            this.facade_charac.BackColor = System.Drawing.Color.Transparent;
            this.facade_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.male_uni_back;
            this.facade_charac.Location = new System.Drawing.Point(449, 398);
            this.facade_charac.Name = "facade_charac";
            this.facade_charac.Size = new System.Drawing.Size(128, 229);
            this.facade_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facade_charac.TabIndex = 2;
            this.facade_charac.TabStop = false;
            // 
            // interactcollision_pbox
            // 
            this.interactcollision_pbox.BackColor = System.Drawing.Color.Transparent;
            this.interactcollision_pbox.Location = new System.Drawing.Point(463, 146);
            this.interactcollision_pbox.Name = "interactcollision_pbox";
            this.interactcollision_pbox.Size = new System.Drawing.Size(189, 28);
            this.interactcollision_pbox.TabIndex = 3;
            this.interactcollision_pbox.TabStop = false;
            this.interactcollision_pbox.Tag = "interact_w_guard";
            // 
            // returncollision_pbox
            // 
            this.returncollision_pbox.BackColor = System.Drawing.Color.Transparent;
            this.returncollision_pbox.Location = new System.Drawing.Point(0, 454);
            this.returncollision_pbox.Name = "returncollision_pbox";
            this.returncollision_pbox.Size = new System.Drawing.Size(16, 149);
            this.returncollision_pbox.TabIndex = 4;
            this.returncollision_pbox.TabStop = false;
            this.returncollision_pbox.Tag = "return_home";
            // 
            // facadeWalkTimer
            // 
            this.facadeWalkTimer.Enabled = true;
            this.facadeWalkTimer.Interval = 40;
            this.facadeWalkTimer.Tick += new System.EventHandler(this.facadeWalkTimer_Tick);
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
            this.viewmenu_panel.TabIndex = 16;
            this.viewmenu_panel.Visible = false;
            // 
            // return_label
            // 
            this.return_label.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_label.Location = new System.Drawing.Point(0, 333);
            this.return_label.Name = "return_label";
            this.return_label.Size = new System.Drawing.Size(208, 59);
            this.return_label.TabIndex = 26;
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
            this.achievs_lbl.TabIndex = 25;
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
            this.tasks_lbl.TabIndex = 24;
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
            this.hint_panel.TabIndex = 17;
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
            this.hinttext_lbl.Text = "Try to pass through the guard.";
            this.hinttext_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Facade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.facade;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.hint_panel);
            this.Controls.Add(this.viewmenu_panel);
            this.Controls.Add(this.returncollision_pbox);
            this.Controls.Add(this.interactcollision_pbox);
            this.Controls.Add(this.facade_charac);
            this.Controls.Add(this.guard_pbox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hint_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guard_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facade_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interactcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).EndInit();
            this.viewmenu_panel.ResumeLayout(false);
            this.viewmenu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.profile_panel.ResumeLayout(false);
            this.hint_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox guard_pbox;
        private System.Windows.Forms.PictureBox facade_charac;
        private System.Windows.Forms.PictureBox interactcollision_pbox;
        private System.Windows.Forms.PictureBox returncollision_pbox;
        private System.Windows.Forms.Timer facadeWalkTimer;
        private System.Windows.Forms.PictureBox menu_pbox;
        private System.Windows.Forms.Label day_lbl;
        private System.Windows.Forms.Label currency_lbl;
        private System.Windows.Forms.Label hint_lbl;
        private System.Windows.Forms.PictureBox hint_pbox;
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