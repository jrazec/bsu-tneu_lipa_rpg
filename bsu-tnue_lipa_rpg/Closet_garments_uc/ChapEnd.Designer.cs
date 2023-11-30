namespace bsu_tnue_lipa_rpg.Closet_garments_uc
{
    partial class Chapter_End
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.proceed_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proceed_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 182);
            this.label1.TabIndex = 0;
            this.label1.Text = "Success!";
            // 
            // proceed_pbox
            // 
            this.proceed_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources._111_01;
            this.proceed_pbox.Location = new System.Drawing.Point(518, 330);
            this.proceed_pbox.Name = "proceed_pbox";
            this.proceed_pbox.Size = new System.Drawing.Size(240, 188);
            this.proceed_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proceed_pbox.TabIndex = 1;
            this.proceed_pbox.TabStop = false;
            this.proceed_pbox.Click += new System.EventHandler(this.proceed_pbox_Click);
            // 
            // Chapter_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1439, 799);
            this.Controls.Add(this.proceed_pbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chapter_End";
            this.Text = "ChapEnd";
            ((System.ComponentModel.ISupportInitialize)(this.proceed_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox proceed_pbox;
    }
}