namespace bsu_tnue_lipa_rpg.CECS_floors_uc
{
    partial class CECS_fifthflr
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
            this.drbalazon_pbox = new System.Windows.Forms.PictureBox();
            this.cecsfifthflr_charac = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elevcollision_pbox = new System.Windows.Forms.PictureBox();
            this.cecsfifthWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.success_door = new System.Windows.Forms.Panel();
            this.door3_panel = new System.Windows.Forms.Panel();
            this.door2_panel = new System.Windows.Forms.Panel();
            this.door1_panel = new System.Windows.Forms.Panel();
            this.dr_dg = new System.Windows.Forms.Label();
            this.dg_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drbalazon_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecsfifthflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // drbalazon_pbox
            // 
            this.drbalazon_pbox.BackColor = System.Drawing.Color.Transparent;
            this.drbalazon_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Dr_Balazon;
            this.drbalazon_pbox.Location = new System.Drawing.Point(733, 163);
            this.drbalazon_pbox.Name = "drbalazon_pbox";
            this.drbalazon_pbox.Size = new System.Drawing.Size(101, 119);
            this.drbalazon_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drbalazon_pbox.TabIndex = 0;
            this.drbalazon_pbox.TabStop = false;
            // 
            // cecsfifthflr_charac
            // 
            this.cecsfifthflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.cecsfifthflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.cecsfifthflr_charac.Location = new System.Drawing.Point(82, 259);
            this.cecsfifthflr_charac.Name = "cecsfifthflr_charac";
            this.cecsfifthflr_charac.Size = new System.Drawing.Size(101, 119);
            this.cecsfifthflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cecsfifthflr_charac.TabIndex = 3;
            this.cecsfifthflr_charac.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1296, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "To elevator ->";
            // 
            // elevcollision_pbox
            // 
            this.elevcollision_pbox.Location = new System.Drawing.Point(1404, 204);
            this.elevcollision_pbox.Name = "elevcollision_pbox";
            this.elevcollision_pbox.Size = new System.Drawing.Size(29, 185);
            this.elevcollision_pbox.TabIndex = 5;
            this.elevcollision_pbox.TabStop = false;
            this.elevcollision_pbox.Tag = "go_to_elev";
            // 
            // cecsfifthWalkTimer
            // 
            this.cecsfifthWalkTimer.Enabled = true;
            this.cecsfifthWalkTimer.Interval = 50;
            this.cecsfifthWalkTimer.Tick += new System.EventHandler(this.cecsfifthWalkTimer_Tick);
            // 
            // success_door
            // 
            this.success_door.BackColor = System.Drawing.Color.Transparent;
            this.success_door.Location = new System.Drawing.Point(502, 175);
            this.success_door.Name = "success_door";
            this.success_door.Size = new System.Drawing.Size(50, 74);
            this.success_door.TabIndex = 15;
            // 
            // door3_panel
            // 
            this.door3_panel.BackColor = System.Drawing.Color.Transparent;
            this.door3_panel.Location = new System.Drawing.Point(552, 168);
            this.door3_panel.Name = "door3_panel";
            this.door3_panel.Size = new System.Drawing.Size(10, 82);
            this.door3_panel.TabIndex = 11;
            // 
            // door2_panel
            // 
            this.door2_panel.BackColor = System.Drawing.Color.Transparent;
            this.door2_panel.Location = new System.Drawing.Point(492, 163);
            this.door2_panel.Name = "door2_panel";
            this.door2_panel.Size = new System.Drawing.Size(70, 10);
            this.door2_panel.TabIndex = 10;
            // 
            // door1_panel
            // 
            this.door1_panel.BackColor = System.Drawing.Color.Transparent;
            this.door1_panel.Location = new System.Drawing.Point(491, 163);
            this.door1_panel.Name = "door1_panel";
            this.door1_panel.Size = new System.Drawing.Size(11, 87);
            this.door1_panel.TabIndex = 14;
            // 
            // dr_dg
            // 
            this.dr_dg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dr_dg.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_dg.ForeColor = System.Drawing.Color.White;
            this.dr_dg.Location = new System.Drawing.Point(388, 440);
            this.dr_dg.Name = "dr_dg";
            this.dr_dg.Size = new System.Drawing.Size(808, 112);
            this.dr_dg.TabIndex = 13;
            this.dr_dg.Text = "Congratulations Red Spartan! Let\'s now proceed\r\nto our class here in Computer Lab" +
    " 1,  shall we?";
            this.dr_dg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dg_pbox
            // 
            this.dg_pbox.BackColor = System.Drawing.Color.Transparent;
            this.dg_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.dr_dialogue;
            this.dg_pbox.Location = new System.Drawing.Point(138, 385);
            this.dg_pbox.Name = "dg_pbox";
            this.dg_pbox.Size = new System.Drawing.Size(1189, 221);
            this.dg_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dg_pbox.TabIndex = 12;
            this.dg_pbox.TabStop = false;
            // 
            // CECS_fifthflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.cecs_hallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.success_door);
            this.Controls.Add(this.door3_panel);
            this.Controls.Add(this.door2_panel);
            this.Controls.Add(this.door1_panel);
            this.Controls.Add(this.dr_dg);
            this.Controls.Add(this.dg_pbox);
            this.Controls.Add(this.cecsfifthflr_charac);
            this.Controls.Add(this.drbalazon_pbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elevcollision_pbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CECS_fifthflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.drbalazon_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecsfifthflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drbalazon_pbox;
        private System.Windows.Forms.PictureBox cecsfifthflr_charac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox elevcollision_pbox;
        public System.Windows.Forms.Timer cecsfifthWalkTimer;
        private System.Windows.Forms.Panel success_door;
        private System.Windows.Forms.Panel door3_panel;
        private System.Windows.Forms.Panel door2_panel;
        private System.Windows.Forms.Panel door1_panel;
        private System.Windows.Forms.Label dr_dg;
        private System.Windows.Forms.PictureBox dg_pbox;
    }
}
