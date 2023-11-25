namespace bsu_tnue_lipa_rpg.Closet_garments_uc
{
    partial class shoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "shoes";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Shoes;
            this.pictureBox4.Location = new System.Drawing.Point(61, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(122, 113);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(61, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 56);
            this.label8.TabIndex = 27;
            this.label8.Text = "Estetik Starter Pack";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "shoes";
            this.Size = new System.Drawing.Size(671, 518);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
    }
}
