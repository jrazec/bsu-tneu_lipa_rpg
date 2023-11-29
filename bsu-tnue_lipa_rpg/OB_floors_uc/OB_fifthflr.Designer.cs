namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    partial class OB_fifthflr
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
            this.engrjonnah_pbox = new System.Windows.Forms.PictureBox();
            this.obfifthflr_charac = new System.Windows.Forms.PictureBox();
            this.staircollision_pbox = new System.Windows.Forms.PictureBox();
            this.obfifthWalkTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.engrjonnah_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obfifthflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // engrjonnah_pbox
            // 
            this.engrjonnah_pbox.BackColor = System.Drawing.Color.Transparent;
            this.engrjonnah_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Engr_Jonnah;
            this.engrjonnah_pbox.Location = new System.Drawing.Point(761, 170);
            this.engrjonnah_pbox.Name = "engrjonnah_pbox";
            this.engrjonnah_pbox.Size = new System.Drawing.Size(111, 135);
            this.engrjonnah_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.engrjonnah_pbox.TabIndex = 0;
            this.engrjonnah_pbox.TabStop = false;
            // 
            // obfifthflr_charac
            // 
            this.obfifthflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.obfifthflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.obfifthflr_charac.Location = new System.Drawing.Point(258, 194);
            this.obfifthflr_charac.Name = "obfifthflr_charac";
            this.obfifthflr_charac.Size = new System.Drawing.Size(111, 135);
            this.obfifthflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obfifthflr_charac.TabIndex = 7;
            this.obfifthflr_charac.TabStop = false;
            // 
            // staircollision_pbox
            // 
            this.staircollision_pbox.BackColor = System.Drawing.Color.DimGray;
            this.staircollision_pbox.Location = new System.Drawing.Point(29, 415);
            this.staircollision_pbox.Name = "staircollision_pbox";
            this.staircollision_pbox.Size = new System.Drawing.Size(16, 117);
            this.staircollision_pbox.TabIndex = 8;
            this.staircollision_pbox.TabStop = false;
            this.staircollision_pbox.Tag = "go_down";
            // 
            // obfifthWalkTimer
            // 
            this.obfifthWalkTimer.Enabled = true;
            this.obfifthWalkTimer.Interval = 50;
            this.obfifthWalkTimer.Tick += new System.EventHandler(this.obfifthWalkTimer_Tick);
            // 
            // OB_fifthflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_libr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.staircollision_pbox);
            this.Controls.Add(this.obfifthflr_charac);
            this.Controls.Add(this.engrjonnah_pbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OB_fifthflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.engrjonnah_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obfifthflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox engrjonnah_pbox;
        private System.Windows.Forms.PictureBox obfifthflr_charac;
        private System.Windows.Forms.PictureBox staircollision_pbox;
        public System.Windows.Forms.Timer obfifthWalkTimer;
    }
}
