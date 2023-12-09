namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    partial class OB_firstflr
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
            this.obfirstflr_charac = new System.Windows.Forms.PictureBox();
            this.obfirstWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.staircollision_pbox = new System.Windows.Forms.PictureBox();
            this.upflrcollision_pbox = new System.Windows.Forms.PictureBox();
            this.returncollision_pbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obfirstflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // obfirstflr_charac
            // 
            this.obfirstflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.obfirstflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.obfirstflr_charac.Location = new System.Drawing.Point(408, 280);
            this.obfirstflr_charac.Name = "obfirstflr_charac";
            this.obfirstflr_charac.Size = new System.Drawing.Size(133, 135);
            this.obfirstflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obfirstflr_charac.TabIndex = 0;
            this.obfirstflr_charac.TabStop = false;
            // 
            // obfirstWalkTimer
            // 
            this.obfirstWalkTimer.Enabled = true;
            this.obfirstWalkTimer.Interval = 50;
            this.obfirstWalkTimer.Tick += new System.EventHandler(this.obfirstWalkTimer_Tick);
            // 
            // staircollision_pbox
            // 
            this.staircollision_pbox.BackColor = System.Drawing.Color.Transparent;
            this.staircollision_pbox.Location = new System.Drawing.Point(7, 327);
            this.staircollision_pbox.Name = "staircollision_pbox";
            this.staircollision_pbox.Size = new System.Drawing.Size(35, 69);
            this.staircollision_pbox.TabIndex = 1;
            this.staircollision_pbox.TabStop = false;
            this.staircollision_pbox.Tag = "go_up";
            // 
            // upflrcollision_pbox
            // 
            this.upflrcollision_pbox.BackColor = System.Drawing.Color.Transparent;
            this.upflrcollision_pbox.Location = new System.Drawing.Point(1402, 189);
            this.upflrcollision_pbox.Name = "upflrcollision_pbox";
            this.upflrcollision_pbox.Size = new System.Drawing.Size(31, 162);
            this.upflrcollision_pbox.TabIndex = 2;
            this.upflrcollision_pbox.TabStop = false;
            this.upflrcollision_pbox.Tag = "go_up";
            // 
            // returncollision_pbox
            // 
            this.returncollision_pbox.BackColor = System.Drawing.Color.Transparent;
            this.returncollision_pbox.Location = new System.Drawing.Point(267, 526);
            this.returncollision_pbox.Name = "returncollision_pbox";
            this.returncollision_pbox.Size = new System.Drawing.Size(343, 14);
            this.returncollision_pbox.TabIndex = 3;
            this.returncollision_pbox.TabStop = false;
            this.returncollision_pbox.Tag = "return_to_map";
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
            this.label1.TabIndex = 7;
            this.label1.Text = "Go up ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(67, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "<- Go up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(435, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exit ↓";
            // 
            // OB_firstflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_1stflr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.obfirstflr_charac);
            this.Controls.Add(this.returncollision_pbox);
            this.Controls.Add(this.upflrcollision_pbox);
            this.Controls.Add(this.staircollision_pbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OB_firstflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.obfirstflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox obfirstflr_charac;
        public System.Windows.Forms.Timer obfirstWalkTimer;
        private System.Windows.Forms.PictureBox staircollision_pbox;
        private System.Windows.Forms.PictureBox upflrcollision_pbox;
        private System.Windows.Forms.PictureBox returncollision_pbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
