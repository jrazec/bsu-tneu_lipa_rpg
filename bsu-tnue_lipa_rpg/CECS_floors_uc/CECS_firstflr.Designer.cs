namespace bsu_tnue_lipa_rpg
{
    partial class CECS_firstflr
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
            this.cecsfirstflr_charac = new System.Windows.Forms.PictureBox();
            this.returncollision_pbox = new System.Windows.Forms.PictureBox();
            this.elevcollision_pbox = new System.Windows.Forms.PictureBox();
            this.cecsfirstWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.atty_pbox = new System.Windows.Forms.PictureBox();
            this.door3_panel = new System.Windows.Forms.Panel();
            this.door2_panel = new System.Windows.Forms.Panel();
            this.door1_panel = new System.Windows.Forms.Panel();
            this.atty_dg = new System.Windows.Forms.Label();
            this.dg_pbox = new System.Windows.Forms.PictureBox();
            this.success_registrar = new System.Windows.Forms.PictureBox();
            this.click_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cecsfirstflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atty_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.success_registrar)).BeginInit();
            this.SuspendLayout();
            // 
            // cecsfirstflr_charac
            // 
            this.cecsfirstflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.cecsfirstflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.cecsfirstflr_charac.Location = new System.Drawing.Point(95, 283);
            this.cecsfirstflr_charac.Name = "cecsfirstflr_charac";
            this.cecsfirstflr_charac.Size = new System.Drawing.Size(101, 119);
            this.cecsfirstflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cecsfirstflr_charac.TabIndex = 0;
            this.cecsfirstflr_charac.TabStop = false;
            // 
            // returncollision_pbox
            // 
            this.returncollision_pbox.BackColor = System.Drawing.Color.White;
            this.returncollision_pbox.Location = new System.Drawing.Point(3, 258);
            this.returncollision_pbox.Name = "returncollision_pbox";
            this.returncollision_pbox.Size = new System.Drawing.Size(27, 128);
            this.returncollision_pbox.TabIndex = 1;
            this.returncollision_pbox.TabStop = false;
            this.returncollision_pbox.Tag = "return_to_map";
            // 
            // elevcollision_pbox
            // 
            this.elevcollision_pbox.BackColor = System.Drawing.Color.White;
            this.elevcollision_pbox.Location = new System.Drawing.Point(1395, 283);
            this.elevcollision_pbox.Name = "elevcollision_pbox";
            this.elevcollision_pbox.Size = new System.Drawing.Size(27, 128);
            this.elevcollision_pbox.TabIndex = 2;
            this.elevcollision_pbox.TabStop = false;
            this.elevcollision_pbox.Tag = "go_to_elev";
            // 
            // cecsfirstWalkTimer
            // 
            this.cecsfirstWalkTimer.Enabled = true;
            this.cecsfirstWalkTimer.Interval = 50;
            this.cecsfirstWalkTimer.Tick += new System.EventHandler(this.cecsfirstWalkTimer_Tick);
            // 
            // atty_pbox
            // 
            this.atty_pbox.BackColor = System.Drawing.Color.Transparent;
            this.atty_pbox.Enabled = false;
            this.atty_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Atty_Alvin;
            this.atty_pbox.Location = new System.Drawing.Point(192, 151);
            this.atty_pbox.Name = "atty_pbox";
            this.atty_pbox.Size = new System.Drawing.Size(85, 116);
            this.atty_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.atty_pbox.TabIndex = 3;
            this.atty_pbox.TabStop = false;
            this.atty_pbox.Tag = "atty";
            this.atty_pbox.Visible = false;
            // 
            // door3_panel
            // 
            this.door3_panel.BackColor = System.Drawing.Color.Transparent;
            this.door3_panel.Location = new System.Drawing.Point(1409, 151);
            this.door3_panel.Name = "door3_panel";
            this.door3_panel.Size = new System.Drawing.Size(10, 104);
            this.door3_panel.TabIndex = 17;
            this.door3_panel.Visible = false;
            // 
            // door2_panel
            // 
            this.door2_panel.BackColor = System.Drawing.Color.Transparent;
            this.door2_panel.Location = new System.Drawing.Point(964, 151);
            this.door2_panel.Name = "door2_panel";
            this.door2_panel.Size = new System.Drawing.Size(455, 13);
            this.door2_panel.TabIndex = 16;
            this.door2_panel.Visible = false;
            // 
            // door1_panel
            // 
            this.door1_panel.BackColor = System.Drawing.Color.Transparent;
            this.door1_panel.Location = new System.Drawing.Point(963, 151);
            this.door1_panel.Name = "door1_panel";
            this.door1_panel.Size = new System.Drawing.Size(10, 104);
            this.door1_panel.TabIndex = 20;
            this.door1_panel.Visible = false;
            // 
            // atty_dg
            // 
            this.atty_dg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.atty_dg.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atty_dg.ForeColor = System.Drawing.Color.White;
            this.atty_dg.Location = new System.Drawing.Point(364, 425);
            this.atty_dg.Name = "atty_dg";
            this.atty_dg.Size = new System.Drawing.Size(808, 143);
            this.atty_dg.TabIndex = 19;
            this.atty_dg.Text = "The registrar\'s office is conveniently situated here on the first floor of the CE" +
    "CS Building . \r\nI am wishing you an excellent day ahead!";
            this.atty_dg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.atty_dg.Visible = false;
            // 
            // dg_pbox
            // 
            this.dg_pbox.BackColor = System.Drawing.Color.Transparent;
            this.dg_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.atty_dialogue;
            this.dg_pbox.Location = new System.Drawing.Point(114, 385);
            this.dg_pbox.Name = "dg_pbox";
            this.dg_pbox.Size = new System.Drawing.Size(1189, 221);
            this.dg_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dg_pbox.TabIndex = 18;
            this.dg_pbox.TabStop = false;
            this.dg_pbox.Visible = false;
            // 
            // success_registrar
            // 
            this.success_registrar.BackColor = System.Drawing.Color.Transparent;
            this.success_registrar.Enabled = false;
            this.success_registrar.Location = new System.Drawing.Point(1191, 170);
            this.success_registrar.Name = "success_registrar";
            this.success_registrar.Size = new System.Drawing.Size(204, 31);
            this.success_registrar.TabIndex = 23;
            this.success_registrar.TabStop = false;
            this.success_registrar.Tag = "regis";
            this.success_registrar.Visible = false;
            this.success_registrar.Click += new System.EventHandler(this.success_registrar_Click);
            // 
            // click_lbl
            // 
            this.click_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.click_lbl.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.click_lbl.Location = new System.Drawing.Point(1220, 132);
            this.click_lbl.Name = "click_lbl";
            this.click_lbl.Size = new System.Drawing.Size(110, 32);
            this.click_lbl.TabIndex = 25;
            this.click_lbl.Text = "Ask Here!";
            this.click_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.click_lbl.Visible = false;
            // 
            // CECS_firstflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.registrar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.cecsfirstflr_charac);
            this.Controls.Add(this.click_lbl);
            this.Controls.Add(this.success_registrar);
            this.Controls.Add(this.door3_panel);
            this.Controls.Add(this.door2_panel);
            this.Controls.Add(this.door1_panel);
            this.Controls.Add(this.atty_dg);
            this.Controls.Add(this.dg_pbox);
            this.Controls.Add(this.atty_pbox);
            this.Controls.Add(this.elevcollision_pbox);
            this.Controls.Add(this.returncollision_pbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CECS_firstflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.cecsfirstflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atty_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.success_registrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cecsfirstflr_charac;
        private System.Windows.Forms.PictureBox returncollision_pbox;
        private System.Windows.Forms.PictureBox elevcollision_pbox;
        public System.Windows.Forms.Timer cecsfirstWalkTimer;
        public System.Windows.Forms.PictureBox atty_pbox;
        public System.Windows.Forms.Panel door3_panel;
        public System.Windows.Forms.Panel door2_panel;
        public System.Windows.Forms.Panel door1_panel;
        public System.Windows.Forms.Label atty_dg;
        public System.Windows.Forms.PictureBox dg_pbox;
        public System.Windows.Forms.PictureBox success_registrar;
        public System.Windows.Forms.Label click_lbl;
    }
}
