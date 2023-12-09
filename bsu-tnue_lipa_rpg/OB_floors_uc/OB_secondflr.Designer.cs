namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    partial class OB_secondflr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.obsecondflr_charac = new System.Windows.Forms.PictureBox();
            this.obsecondWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.staircollision_pbox = new System.Windows.Forms.PictureBox();
            this.upflrcollision_pbox = new System.Windows.Forms.PictureBox();
            this.door3_panel = new System.Windows.Forms.Panel();
            this.door2_panel = new System.Windows.Forms.Panel();
            this.door1_panel = new System.Windows.Forms.Panel();
            this.dg_dg = new System.Windows.Forms.Label();
            this.dg_pbox = new System.Windows.Forms.PictureBox();
            this.success_med = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obsecondflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.success_med)).BeginInit();
            this.SuspendLayout();
            // 
            // obsecondflr_charac
            // 
            this.obsecondflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.obsecondflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.obsecondflr_charac.Location = new System.Drawing.Point(238, 362);
            this.obsecondflr_charac.Name = "obsecondflr_charac";
            this.obsecondflr_charac.Size = new System.Drawing.Size(99, 135);
            this.obsecondflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obsecondflr_charac.TabIndex = 1;
            this.obsecondflr_charac.TabStop = false;
            // 
            // obsecondWalkTimer
            // 
            this.obsecondWalkTimer.Enabled = true;
            this.obsecondWalkTimer.Interval = 50;
            this.obsecondWalkTimer.Tick += new System.EventHandler(this.obsecondWalkTimer_Tick);
            // 
            // staircollision_pbox
            // 
            this.staircollision_pbox.BackColor = System.Drawing.Color.Transparent;
            this.staircollision_pbox.Location = new System.Drawing.Point(15, 451);
            this.staircollision_pbox.Name = "staircollision_pbox";
            this.staircollision_pbox.Size = new System.Drawing.Size(35, 69);
            this.staircollision_pbox.TabIndex = 2;
            this.staircollision_pbox.TabStop = false;
            this.staircollision_pbox.Tag = "go_down";
            // 
            // upflrcollision_pbox
            // 
            this.upflrcollision_pbox.BackColor = System.Drawing.Color.Transparent;
            this.upflrcollision_pbox.Location = new System.Drawing.Point(1412, 200);
            this.upflrcollision_pbox.Name = "upflrcollision_pbox";
            this.upflrcollision_pbox.Size = new System.Drawing.Size(21, 162);
            this.upflrcollision_pbox.TabIndex = 3;
            this.upflrcollision_pbox.TabStop = false;
            this.upflrcollision_pbox.Tag = "go_up";
            // 
            // door3_panel
            // 
            this.door3_panel.BackColor = System.Drawing.Color.Transparent;
            this.door3_panel.Location = new System.Drawing.Point(670, 139);
            this.door3_panel.Name = "door3_panel";
            this.door3_panel.Size = new System.Drawing.Size(10, 104);
            this.door3_panel.TabIndex = 23;
            this.door3_panel.Visible = false;
            // 
            // door2_panel
            // 
            this.door2_panel.BackColor = System.Drawing.Color.Transparent;
            this.door2_panel.Location = new System.Drawing.Point(209, 139);
            this.door2_panel.Name = "door2_panel";
            this.door2_panel.Size = new System.Drawing.Size(471, 13);
            this.door2_panel.TabIndex = 22;
            this.door2_panel.Visible = false;
            // 
            // door1_panel
            // 
            this.door1_panel.BackColor = System.Drawing.Color.Transparent;
            this.door1_panel.Location = new System.Drawing.Point(208, 139);
            this.door1_panel.Name = "door1_panel";
            this.door1_panel.Size = new System.Drawing.Size(10, 104);
            this.door1_panel.TabIndex = 26;
            this.door1_panel.Visible = false;
            // 
            // dg_dg
            // 
            this.dg_dg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dg_dg.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_dg.ForeColor = System.Drawing.Color.White;
            this.dg_dg.Location = new System.Drawing.Point(326, 430);
            this.dg_dg.Name = "dg_dg";
            this.dg_dg.Size = new System.Drawing.Size(808, 143);
            this.dg_dg.TabIndex = 25;
            this.dg_dg.Text = "Heading out for your medical appointment at the school clinic..";
            this.dg_dg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dg_dg.Visible = false;
            // 
            // dg_pbox
            // 
            this.dg_pbox.BackColor = System.Drawing.Color.Transparent;
            this.dg_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.dialogue_base;
            this.dg_pbox.Location = new System.Drawing.Point(124, 390);
            this.dg_pbox.Name = "dg_pbox";
            this.dg_pbox.Size = new System.Drawing.Size(1189, 221);
            this.dg_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dg_pbox.TabIndex = 24;
            this.dg_pbox.TabStop = false;
            this.dg_pbox.Visible = false;
            // 
            // success_med
            // 
            this.success_med.BackColor = System.Drawing.Color.Transparent;
            this.success_med.Location = new System.Drawing.Point(266, 159);
            this.success_med.Name = "success_med";
            this.success_med.Size = new System.Drawing.Size(389, 12);
            this.success_med.TabIndex = 27;
            this.success_med.TabStop = false;
            this.success_med.Tag = "med";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(75, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "<- Go down";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1328, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Go up ->";
            // 
            // OB_secondflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_clinic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.success_med);
            this.Controls.Add(this.door3_panel);
            this.Controls.Add(this.door2_panel);
            this.Controls.Add(this.door1_panel);
            this.Controls.Add(this.dg_dg);
            this.Controls.Add(this.dg_pbox);
            this.Controls.Add(this.upflrcollision_pbox);
            this.Controls.Add(this.staircollision_pbox);
            this.Controls.Add(this.obsecondflr_charac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OB_secondflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.obsecondflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.success_med)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox obsecondflr_charac;
        public System.Windows.Forms.Timer obsecondWalkTimer;
        private System.Windows.Forms.PictureBox staircollision_pbox;
        private System.Windows.Forms.PictureBox upflrcollision_pbox;
        public System.Windows.Forms.Panel door3_panel;
        public System.Windows.Forms.Panel door2_panel;
        public System.Windows.Forms.Panel door1_panel;
        public System.Windows.Forms.Label dg_dg;
        public System.Windows.Forms.PictureBox dg_pbox;
        public System.Windows.Forms.PictureBox success_med;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
