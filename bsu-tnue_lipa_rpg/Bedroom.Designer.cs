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
            this.menu_panel = new System.Windows.Forms.Panel();
            this.hint_pbox = new System.Windows.Forms.PictureBox();
            this.menu_pbox = new System.Windows.Forms.PictureBox();
            this.currency_lbl = new System.Windows.Forms.Label();
            this.day_lbl = new System.Windows.Forms.Label();
            this.closetcollision_pbox = new System.Windows.Forms.PictureBox();
            this.bedroom_charac = new System.Windows.Forms.PictureBox();
            this.bedroomWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.doorcollision_pbox = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hint_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closetcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorcollision_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Maroon;
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
            // hint_pbox
            // 
            this.hint_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources._1;
            this.hint_pbox.Location = new System.Drawing.Point(978, 6);
            this.hint_pbox.Name = "hint_pbox";
            this.hint_pbox.Size = new System.Drawing.Size(44, 34);
            this.hint_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hint_pbox.TabIndex = 3;
            this.hint_pbox.TabStop = false;
            // 
            // menu_pbox
            // 
            this.menu_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources._1;
            this.menu_pbox.Location = new System.Drawing.Point(13, 5);
            this.menu_pbox.Name = "menu_pbox";
            this.menu_pbox.Size = new System.Drawing.Size(44, 34);
            this.menu_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_pbox.TabIndex = 2;
            this.menu_pbox.TabStop = false;
            // 
            // currency_lbl
            // 
            this.currency_lbl.AutoSize = true;
            this.currency_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currency_lbl.Location = new System.Drawing.Point(776, 6);
            this.currency_lbl.Name = "currency_lbl";
            this.currency_lbl.Size = new System.Drawing.Size(110, 34);
            this.currency_lbl.TabIndex = 1;
            this.currency_lbl.Text = "₱ 800.00";
            // 
            // day_lbl
            // 
            this.day_lbl.AutoSize = true;
            this.day_lbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.day_lbl.Location = new System.Drawing.Point(147, 6);
            this.day_lbl.Name = "day_lbl";
            this.day_lbl.Size = new System.Drawing.Size(99, 34);
            this.day_lbl.TabIndex = 0;
            this.day_lbl.Text = "Monday";
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
            this.bedroom_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.male_casual_front;
            this.bedroom_charac.Location = new System.Drawing.Point(749, 406);
            this.bedroom_charac.Name = "bedroom_charac";
            this.bedroom_charac.Size = new System.Drawing.Size(125, 221);
            this.bedroom_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bedroom_charac.TabIndex = 2;
            this.bedroom_charac.TabStop = false;
            // 
            // bedroomWalkTimer
            // 
            this.bedroomWalkTimer.Enabled = true;
            this.bedroomWalkTimer.Interval = 50;
            this.bedroomWalkTimer.Tick += new System.EventHandler(this.bedroomWalkTimer_Tick);
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
            // Bedroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.bedroom;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.doorcollision_pbox);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.bedroom_charac);
            this.Controls.Add(this.closetcollision_pbox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bedroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bedroom";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hint_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closetcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorcollision_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox closetcollision_pbox;
        private System.Windows.Forms.PictureBox bedroom_charac;
        private System.Windows.Forms.Timer bedroomWalkTimer;
        private System.Windows.Forms.Label currency_lbl;
        private System.Windows.Forms.Label day_lbl;
        private System.Windows.Forms.PictureBox hint_pbox;
        private System.Windows.Forms.PictureBox menu_pbox;
        private System.Windows.Forms.PictureBox doorcollision_pbox;
    }
}