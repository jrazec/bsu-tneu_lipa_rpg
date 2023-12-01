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
            this.success_registrar = new System.Windows.Forms.Panel();
            this.door3_panel = new System.Windows.Forms.Panel();
            this.door2_panel = new System.Windows.Forms.Panel();
            this.door1_panel = new System.Windows.Forms.Panel();
            this.dg_dg = new System.Windows.Forms.Label();
            this.dg_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obsecondflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).BeginInit();
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
            this.staircollision_pbox.BackColor = System.Drawing.Color.DimGray;
            this.staircollision_pbox.Location = new System.Drawing.Point(15, 451);
            this.staircollision_pbox.Name = "staircollision_pbox";
            this.staircollision_pbox.Size = new System.Drawing.Size(35, 69);
            this.staircollision_pbox.TabIndex = 2;
            this.staircollision_pbox.TabStop = false;
            this.staircollision_pbox.Tag = "go_down";
            // 
            // upflrcollision_pbox
            // 
            this.upflrcollision_pbox.BackColor = System.Drawing.Color.DimGray;
            this.upflrcollision_pbox.Location = new System.Drawing.Point(1412, 200);
            this.upflrcollision_pbox.Name = "upflrcollision_pbox";
            this.upflrcollision_pbox.Size = new System.Drawing.Size(21, 162);
            this.upflrcollision_pbox.TabIndex = 3;
            this.upflrcollision_pbox.TabStop = false;
            this.upflrcollision_pbox.Tag = "go_up";
            // 
            // success_registrar
            // 
            this.success_registrar.BackColor = System.Drawing.Color.Transparent;
            this.success_registrar.Location = new System.Drawing.Point(238, 169);
            this.success_registrar.Name = "success_registrar";
            this.success_registrar.Size = new System.Drawing.Size(394, 74);
            this.success_registrar.TabIndex = 27;
            // 
            // door3_panel
            // 
            this.door3_panel.BackColor = System.Drawing.Color.Transparent;
            this.door3_panel.Location = new System.Drawing.Point(670, 139);
            this.door3_panel.Name = "door3_panel";
            this.door3_panel.Size = new System.Drawing.Size(10, 104);
            this.door3_panel.TabIndex = 23;
            // 
            // door2_panel
            // 
            this.door2_panel.BackColor = System.Drawing.Color.Transparent;
            this.door2_panel.Location = new System.Drawing.Point(209, 139);
            this.door2_panel.Name = "door2_panel";
            this.door2_panel.Size = new System.Drawing.Size(471, 13);
            this.door2_panel.TabIndex = 22;
            // 
            // door1_panel
            // 
            this.door1_panel.BackColor = System.Drawing.Color.Transparent;
            this.door1_panel.Location = new System.Drawing.Point(208, 139);
            this.door1_panel.Name = "door1_panel";
            this.door1_panel.Size = new System.Drawing.Size(10, 104);
            this.door1_panel.TabIndex = 26;
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
            this.dg_dg.Text = "You proceed on getting you rmedical...";
            this.dg_dg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // OB_secondflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_clinic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.success_registrar);
            this.Controls.Add(this.door3_panel);
            this.Controls.Add(this.door2_panel);
            this.Controls.Add(this.door1_panel);
            this.Controls.Add(this.dg_dg);
            this.Controls.Add(this.dg_pbox);
            this.Controls.Add(this.upflrcollision_pbox);
            this.Controls.Add(this.staircollision_pbox);
            this.Controls.Add(this.obsecondflr_charac);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox obsecondflr_charac;
        public System.Windows.Forms.Timer obsecondWalkTimer;
        private System.Windows.Forms.PictureBox staircollision_pbox;
        private System.Windows.Forms.PictureBox upflrcollision_pbox;
        private System.Windows.Forms.Panel success_registrar;
        private System.Windows.Forms.Panel door3_panel;
        private System.Windows.Forms.Panel door2_panel;
        private System.Windows.Forms.Panel door1_panel;
        private System.Windows.Forms.Label dg_dg;
        private System.Windows.Forms.PictureBox dg_pbox;
    }
}
