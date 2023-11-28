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
            ((System.ComponentModel.ISupportInitialize)(this.obsecondflr_charac)).BeginInit();
            this.SuspendLayout();
            // 
            // obsecondflr_charac
            // 
            this.obsecondflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.obsecondflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.obsecondflr_charac.Location = new System.Drawing.Point(208, 371);
            this.obsecondflr_charac.Name = "obsecondflr_charac";
            this.obsecondflr_charac.Size = new System.Drawing.Size(133, 135);
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
            // OB_secondflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_clinic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.obsecondflr_charac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OB_secondflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.obsecondflr_charac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox obsecondflr_charac;
        private System.Windows.Forms.Timer obsecondWalkTimer;
    }
}
