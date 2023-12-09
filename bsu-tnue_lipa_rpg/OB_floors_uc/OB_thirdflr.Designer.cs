namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    partial class OB_thirdflr
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
            this.staircollision_pbox = new System.Windows.Forms.PictureBox();
            this.upflrcollision_pbox = new System.Windows.Forms.PictureBox();
            this.obthirdflr_charac = new System.Windows.Forms.PictureBox();
            this.obthirdWalkTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obthirdflr_charac)).BeginInit();
            this.SuspendLayout();
            // 
            // staircollision_pbox
            // 
            this.staircollision_pbox.BackColor = System.Drawing.Color.DimGray;
            this.staircollision_pbox.Location = new System.Drawing.Point(3, 245);
            this.staircollision_pbox.Name = "staircollision_pbox";
            this.staircollision_pbox.Size = new System.Drawing.Size(16, 117);
            this.staircollision_pbox.TabIndex = 3;
            this.staircollision_pbox.TabStop = false;
            this.staircollision_pbox.Tag = "go_down";
            // 
            // upflrcollision_pbox
            // 
            this.upflrcollision_pbox.BackColor = System.Drawing.Color.DimGray;
            this.upflrcollision_pbox.Location = new System.Drawing.Point(1403, 219);
            this.upflrcollision_pbox.Name = "upflrcollision_pbox";
            this.upflrcollision_pbox.Size = new System.Drawing.Size(21, 162);
            this.upflrcollision_pbox.TabIndex = 4;
            this.upflrcollision_pbox.TabStop = false;
            this.upflrcollision_pbox.Tag = "go_up";
            // 
            // obthirdflr_charac
            // 
            this.obthirdflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.obthirdflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.obthirdflr_charac.Location = new System.Drawing.Point(274, 227);
            this.obthirdflr_charac.Name = "obthirdflr_charac";
            this.obthirdflr_charac.Size = new System.Drawing.Size(111, 135);
            this.obthirdflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obthirdflr_charac.TabIndex = 5;
            this.obthirdflr_charac.TabStop = false;
            // 
            // obthirdWalkTimer
            // 
            this.obthirdWalkTimer.Enabled = true;
            this.obthirdWalkTimer.Interval = 50;
            this.obthirdWalkTimer.Tick += new System.EventHandler(this.obthirdWalkTimer_Tick);
            // 
            // OB_thirdflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_hallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.obthirdflr_charac);
            this.Controls.Add(this.upflrcollision_pbox);
            this.Controls.Add(this.staircollision_pbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OB_thirdflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obthirdflr_charac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox staircollision_pbox;
        private System.Windows.Forms.PictureBox upflrcollision_pbox;
        public System.Windows.Forms.PictureBox obthirdflr_charac;
        public System.Windows.Forms.Timer obthirdWalkTimer;
    }
}
