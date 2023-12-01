namespace bsu_tnue_lipa_rpg
{
    partial class Bedroom
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
            this.doorcollision_pbox = new System.Windows.Forms.PictureBox();
            this.dg_pbox = new System.Windows.Forms.PictureBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.hint_lbl = new System.Windows.Forms.Label();
            this.hint_pbox = new System.Windows.Forms.PictureBox();
            this.menu_pbox = new System.Windows.Forms.PictureBox();
            this.currency_lbl = new System.Windows.Forms.Label();
            this.day_lbl = new System.Windows.Forms.Label();
            this.dg_bedroom = new System.Windows.Forms.Label();
            this.click_lbl = new System.Windows.Forms.Label();
            this.next_pbox = new System.Windows.Forms.PictureBox();
            this.view_lbl = new System.Windows.Forms.Label();
            this.enter_lbl = new System.Windows.Forms.Label();
            this.bedroomWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.sched_pbox = new System.Windows.Forms.PictureBox();
            this.closetcollision_pbox = new System.Windows.Forms.PictureBox();
            this.bedroom_charac = new System.Windows.Forms.PictureBox();
            this.hint_panel = new System.Windows.Forms.Panel();
            this.hinttext_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doorcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hint_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sched_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closetcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom_charac)).BeginInit();
            this.hint_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // doorcollision_pbox
            // 
            this.doorcollision_pbox.Location = new System.Drawing.Point(1001, 500);
            this.doorcollision_pbox.Name = "doorcollision_pbox";
            this.doorcollision_pbox.Size = new System.Drawing.Size(11, 108);
            this.doorcollision_pbox.TabIndex = 3;
            this.doorcollision_pbox.TabStop = false;
            this.doorcollision_pbox.Tag = "go_outside";
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
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Maroon;
            this.menu_panel.Controls.Add(this.hint_lbl);
            this.menu_panel.Controls.Add(this.hint_pbox);
            this.menu_panel.Controls.Add(this.menu_pbox);
            this.menu_panel.Controls.Add(this.currency_lbl);
            this.menu_panel.Controls.Add(this.day_lbl);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1151, 50);
            this.menu_panel.TabIndex = 0;
            // 
            // hint_lbl
            // 
            this.hint_lbl.AutoSize = true;
            this.hint_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hint_lbl.Location = new System.Drawing.Point(1019, 9);
            this.hint_lbl.Name = "hint_lbl";
            this.hint_lbl.Size = new System.Drawing.Size(58, 34);
            this.hint_lbl.TabIndex = 4;
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
            this.hint_pbox.TabIndex = 3;
            this.hint_pbox.TabStop = false;
            this.hint_pbox.Click += new System.EventHandler(this.hint_pbox_Click);
            // 
            // menu_pbox
            // 
            this.menu_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.menu_icon;
            this.menu_pbox.Location = new System.Drawing.Point(10, 8);
            this.menu_pbox.Name = "menu_pbox";
            this.menu_pbox.Size = new System.Drawing.Size(44, 34);
            this.menu_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_pbox.TabIndex = 2;
            this.menu_pbox.TabStop = false;
            this.menu_pbox.Click += new System.EventHandler(this.menu_pbox_Click);
            // 
            // currency_lbl
            // 
            this.currency_lbl.AutoSize = true;
            this.currency_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currency_lbl.Location = new System.Drawing.Point(776, 9);
            this.currency_lbl.Name = "currency_lbl";
            this.currency_lbl.Size = new System.Drawing.Size(83, 34);
            this.currency_lbl.TabIndex = 1;
            this.currency_lbl.Text = "₱ 0.00";
            // 
            // day_lbl
            // 
            this.day_lbl.AutoSize = true;
            this.day_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.day_lbl.Location = new System.Drawing.Point(147, 9);
            this.day_lbl.Name = "day_lbl";
            this.day_lbl.Size = new System.Drawing.Size(99, 34);
            this.day_lbl.TabIndex = 0;
            this.day_lbl.Text = "Monday";
            // 
            // dg_bedroom
            // 
            this.dg_bedroom.AutoSize = true;
            this.dg_bedroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dg_bedroom.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_bedroom.ForeColor = System.Drawing.Color.White;
            this.dg_bedroom.Location = new System.Drawing.Point(174, 539);
            this.dg_bedroom.Name = "dg_bedroom";
            this.dg_bedroom.Size = new System.Drawing.Size(504, 28);
            this.dg_bedroom.TabIndex = 5;
            this.dg_bedroom.Text = "Good morning, Red Spartan! Let\'s check your schedule for today.";
            // 
            // click_lbl
            // 
            this.click_lbl.AutoSize = true;
            this.click_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.click_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_lbl.ForeColor = System.Drawing.Color.White;
            this.click_lbl.Location = new System.Drawing.Point(854, 597);
            this.click_lbl.Name = "click_lbl";
            this.click_lbl.Size = new System.Drawing.Size(124, 24);
            this.click_lbl.TabIndex = 10;
            this.click_lbl.Text = "Click to proceed..";
            this.click_lbl.Visible = false;
            // 
            // next_pbox
            // 
            this.next_pbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.next_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.next_pbtn;
            this.next_pbox.Location = new System.Drawing.Point(962, 591);
            this.next_pbox.Name = "next_pbox";
            this.next_pbox.Size = new System.Drawing.Size(33, 32);
            this.next_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_pbox.TabIndex = 9;
            this.next_pbox.TabStop = false;
            this.next_pbox.Visible = false;
            this.next_pbox.Click += new System.EventHandler(this.next_pbox_Click);
            // 
            // view_lbl
            // 
            this.view_lbl.AutoSize = true;
            this.view_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.view_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_lbl.ForeColor = System.Drawing.Color.Black;
            this.view_lbl.Location = new System.Drawing.Point(631, 541);
            this.view_lbl.Name = "view_lbl";
            this.view_lbl.Size = new System.Drawing.Size(47, 28);
            this.view_lbl.TabIndex = 12;
            this.view_lbl.Text = "VIEW";
            this.view_lbl.Click += new System.EventHandler(this.view_lbl_Click);
            // 
            // enter_lbl
            // 
            this.enter_lbl.AutoSize = true;
            this.enter_lbl.BackColor = System.Drawing.Color.Maroon;
            this.enter_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_lbl.ForeColor = System.Drawing.Color.White;
            this.enter_lbl.Location = new System.Drawing.Point(955, 596);
            this.enter_lbl.Name = "enter_lbl";
            this.enter_lbl.Size = new System.Drawing.Size(59, 28);
            this.enter_lbl.TabIndex = 13;
            this.enter_lbl.Text = "ENTER";
            this.enter_lbl.Visible = false;
            this.enter_lbl.Click += new System.EventHandler(this.enter_lbl_Click);
            // 
            // bedroomWalkTimer
            // 
            this.bedroomWalkTimer.Interval = 50;
            this.bedroomWalkTimer.Tick += new System.EventHandler(this.bedroomWalkTimer_Tick);
            // 
            // sched_pbox
            // 
            this.sched_pbox.BackColor = System.Drawing.SystemColors.Control;
            this.sched_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.sched;
            this.sched_pbox.Location = new System.Drawing.Point(288, 111);
            this.sched_pbox.Name = "sched_pbox";
            this.sched_pbox.Size = new System.Drawing.Size(584, 386);
            this.sched_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sched_pbox.TabIndex = 8;
            this.sched_pbox.TabStop = false;
            this.sched_pbox.Visible = false;
            // 
            // closetcollision_pbox
            // 
            this.closetcollision_pbox.Location = new System.Drawing.Point(264, 132);
            this.closetcollision_pbox.Name = "closetcollision_pbox";
            this.closetcollision_pbox.Size = new System.Drawing.Size(143, 45);
            this.closetcollision_pbox.TabIndex = 1;
            this.closetcollision_pbox.TabStop = false;
            this.closetcollision_pbox.Tag = "closet_open";
            // 
            // bedroom_charac
            // 
            this.bedroom_charac.BackColor = System.Drawing.Color.Transparent;
            this.bedroom_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_pajama_front;
            this.bedroom_charac.Location = new System.Drawing.Point(500, 243);
            this.bedroom_charac.Name = "bedroom_charac";
            this.bedroom_charac.Size = new System.Drawing.Size(152, 221);
            this.bedroom_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bedroom_charac.TabIndex = 2;
            this.bedroom_charac.TabStop = false;
            // 
            // hint_panel
            // 
            this.hint_panel.Controls.Add(this.hinttext_lbl);
            this.hint_panel.Location = new System.Drawing.Point(784, 50);
            this.hint_panel.Name = "hint_panel";
            this.hint_panel.Size = new System.Drawing.Size(366, 104);
            this.hint_panel.TabIndex = 14;
            this.hint_panel.Visible = false;
            // 
            // hinttext_lbl
            // 
            this.hinttext_lbl.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinttext_lbl.Location = new System.Drawing.Point(14, 12);
            this.hinttext_lbl.Name = "hinttext_lbl";
            this.hinttext_lbl.Size = new System.Drawing.Size(341, 79);
            this.hinttext_lbl.TabIndex = 0;
            this.hinttext_lbl.Text = "Buy hint?";
            this.hinttext_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hinttext_lbl.Visible = false;
            // 
            // Bedroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.bedroom;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.hint_panel);
            this.Controls.Add(this.sched_pbox);
            this.Controls.Add(this.enter_lbl);
            this.Controls.Add(this.view_lbl);
            this.Controls.Add(this.next_pbox);
            this.Controls.Add(this.click_lbl);
            this.Controls.Add(this.dg_bedroom);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.bedroom_charac);
            this.Controls.Add(this.closetcollision_pbox);
            this.Controls.Add(this.dg_pbox);
            this.Controls.Add(this.doorcollision_pbox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bedroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bedroom";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.doorcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hint_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sched_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closetcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom_charac)).EndInit();
            this.hint_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox doorcollision_pbox;
        private System.Windows.Forms.PictureBox dg_pbox;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox hint_pbox;
        private System.Windows.Forms.PictureBox menu_pbox;
        private System.Windows.Forms.Label currency_lbl;
        private System.Windows.Forms.Label day_lbl;
        private System.Windows.Forms.Label dg_bedroom;
        private System.Windows.Forms.Label click_lbl;
        private System.Windows.Forms.PictureBox next_pbox;
        private System.Windows.Forms.Label view_lbl;
        private System.Windows.Forms.Label enter_lbl;
        private System.Windows.Forms.Label hint_lbl;
        public System.Windows.Forms.Timer bedroomWalkTimer;
        private System.Windows.Forms.PictureBox sched_pbox;
        private System.Windows.Forms.PictureBox closetcollision_pbox;
        public System.Windows.Forms.PictureBox bedroom_charac;
        private System.Windows.Forms.Panel hint_panel;
        private System.Windows.Forms.Label hinttext_lbl;
    }
}