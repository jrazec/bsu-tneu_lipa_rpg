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
            ((System.ComponentModel.ISupportInitialize)(this.obsecondflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).BeginInit();
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
            // OB_secondflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_clinic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox obsecondflr_charac;
        public System.Windows.Forms.Timer obsecondWalkTimer;
        private System.Windows.Forms.PictureBox staircollision_pbox;
        private System.Windows.Forms.PictureBox upflrcollision_pbox;
    }
}
