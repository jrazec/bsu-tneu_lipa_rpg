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
            this.shoes1_lbl = new System.Windows.Forms.Label();
            this.shoes1_pbox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shoes1_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // shoes1_lbl
            // 
            this.shoes1_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoes1_lbl.Location = new System.Drawing.Point(96, 162);
            this.shoes1_lbl.Name = "shoes1_lbl";
            this.shoes1_lbl.Size = new System.Drawing.Size(45, 34);
            this.shoes1_lbl.TabIndex = 20;
            this.shoes1_lbl.Text = "shoes";
            // 
            // shoes1_pbox
            // 
            this.shoes1_pbox.BackColor = System.Drawing.Color.DarkGray;
            this.shoes1_pbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shoes1_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Shoes;
            this.shoes1_pbox.Location = new System.Drawing.Point(61, 37);
            this.shoes1_pbox.Name = "shoes1_pbox";
            this.shoes1_pbox.Size = new System.Drawing.Size(122, 113);
            this.shoes1_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shoes1_pbox.TabIndex = 16;
            this.shoes1_pbox.TabStop = false;
            this.shoes1_pbox.Click += new System.EventHandler(this.shoes1_pbox_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(61, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 56);
            this.label8.TabIndex = 27;
            this.label8.Text = "Unlock";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shoes1_lbl);
            this.Controls.Add(this.shoes1_pbox);
            this.Name = "shoes";
            this.Size = new System.Drawing.Size(671, 518);
            ((System.ComponentModel.ISupportInitialize)(this.shoes1_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label shoes1_lbl;
        private System.Windows.Forms.PictureBox shoes1_pbox;
        private System.Windows.Forms.Label label8;
    }
}
