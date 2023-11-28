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
            ((System.ComponentModel.ISupportInitialize)(this.cecsfirstflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // cecsfirstflr_charac
            // 
            this.cecsfirstflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.cecsfirstflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.cecsfirstflr_charac.Location = new System.Drawing.Point(186, 255);
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
            this.elevcollision_pbox.Location = new System.Drawing.Point(503, 258);
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
            // CECS_firstflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.registrar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.elevcollision_pbox);
            this.Controls.Add(this.returncollision_pbox);
            this.Controls.Add(this.cecsfirstflr_charac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CECS_firstflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.cecsfirstflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returncollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cecsfirstflr_charac;
        private System.Windows.Forms.PictureBox returncollision_pbox;
        private System.Windows.Forms.PictureBox elevcollision_pbox;
        public System.Windows.Forms.Timer cecsfirstWalkTimer;
    }
}
