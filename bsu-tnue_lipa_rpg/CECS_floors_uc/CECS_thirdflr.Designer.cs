namespace bsu_tnue_lipa_rpg.CECS_floors_uc
{
    partial class CECS_thirdflr
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
            this.cecsthirdflr_charac = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elevcollision_pbox = new System.Windows.Forms.PictureBox();
            this.cecsthirdWalkTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cecsthirdflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // cecsthirdflr_charac
            // 
            this.cecsthirdflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.cecsthirdflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.cecsthirdflr_charac.Location = new System.Drawing.Point(73, 267);
            this.cecsthirdflr_charac.Name = "cecsthirdflr_charac";
            this.cecsthirdflr_charac.Size = new System.Drawing.Size(101, 119);
            this.cecsthirdflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cecsthirdflr_charac.TabIndex = 3;
            this.cecsthirdflr_charac.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1296, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "To elevator ->";
            // 
            // elevcollision_pbox
            // 
            this.elevcollision_pbox.Location = new System.Drawing.Point(1404, 201);
            this.elevcollision_pbox.Name = "elevcollision_pbox";
            this.elevcollision_pbox.Size = new System.Drawing.Size(29, 185);
            this.elevcollision_pbox.TabIndex = 5;
            this.elevcollision_pbox.TabStop = false;
            this.elevcollision_pbox.Tag = "go_to_elev";
            // 
            // cecsthirdWalkTimer
            // 
            this.cecsthirdWalkTimer.Enabled = true;
            this.cecsthirdWalkTimer.Interval = 50;
            this.cecsthirdWalkTimer.Tick += new System.EventHandler(this.cecsthirdWalkTimer_Tick);
            // 
            // CECS_thirdflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.cecs_hallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elevcollision_pbox);
            this.Controls.Add(this.cecsthirdflr_charac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CECS_thirdflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.cecsthirdflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cecsthirdflr_charac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox elevcollision_pbox;
        public System.Windows.Forms.Timer cecsthirdWalkTimer;
    }
}
