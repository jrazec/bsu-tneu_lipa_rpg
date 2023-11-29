namespace bsu_tnue_lipa_rpg.CECS_floors_uc
{
    partial class CECS_secondflr
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
            this.label1 = new System.Windows.Forms.Label();
            this.elevcollision_pbox = new System.Windows.Forms.PictureBox();
            this.cecssecondflr_charac = new System.Windows.Forms.PictureBox();
            this.cecssecondWalkTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecssecondflr_charac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1296, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "To elevator ->";
            // 
            // elevcollision_pbox
            // 
            this.elevcollision_pbox.Location = new System.Drawing.Point(1404, 215);
            this.elevcollision_pbox.Name = "elevcollision_pbox";
            this.elevcollision_pbox.Size = new System.Drawing.Size(29, 185);
            this.elevcollision_pbox.TabIndex = 1;
            this.elevcollision_pbox.TabStop = false;
            this.elevcollision_pbox.Tag = "go_to_elev";
            // 
            // cecssecondflr_charac
            // 
            this.cecssecondflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.cecssecondflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.cecssecondflr_charac.Location = new System.Drawing.Point(70, 267);
            this.cecssecondflr_charac.Name = "cecssecondflr_charac";
            this.cecssecondflr_charac.Size = new System.Drawing.Size(101, 119);
            this.cecssecondflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cecssecondflr_charac.TabIndex = 2;
            this.cecssecondflr_charac.TabStop = false;
            // 
            // cecssecondWalkTimer
            // 
            this.cecssecondWalkTimer.Enabled = true;
            this.cecssecondWalkTimer.Interval = 50;
            this.cecssecondWalkTimer.Tick += new System.EventHandler(this.cecssecondWalkTimer_Tick);
            // 
            // CECS_secondflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.cecs_hallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.cecssecondflr_charac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elevcollision_pbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CECS_secondflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecssecondflr_charac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox elevcollision_pbox;
        private System.Windows.Forms.PictureBox cecssecondflr_charac;
        public System.Windows.Forms.Timer cecssecondWalkTimer;
    }
}
