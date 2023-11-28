namespace bsu_tnue_lipa_rpg
{
    partial class home_colorpanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.home1;
            this.pictureBox1.Location = new System.Drawing.Point(70, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // home_lbl
            // 
            this.home_lbl.AutoSize = true;
            this.home_lbl.BackColor = System.Drawing.Color.Maroon;
            this.home_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_lbl.ForeColor = System.Drawing.Color.White;
            this.home_lbl.Location = new System.Drawing.Point(105, 10);
            this.home_lbl.Name = "home_lbl";
            this.home_lbl.Size = new System.Drawing.Size(67, 34);
            this.home_lbl.TabIndex = 6;
            this.home_lbl.Text = "HOME";
            // 
            // home_colorpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.home_lbl);
            this.Name = "home_colorpanel";
            this.Size = new System.Drawing.Size(243, 55);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label home_lbl;
    }
}
