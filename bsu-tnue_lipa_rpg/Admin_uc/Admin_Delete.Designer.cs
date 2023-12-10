namespace bsu_tnue_lipa_rpg
{
    partial class Admin_Delete
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
            this.del_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // del_btn
            // 
            this.del_btn.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.trash;
            this.del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(524, 174);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(128, 119);
            this.del_btn.TabIndex = 42;
            this.del_btn.Text = " ";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(142, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 48);
            this.label7.TabIndex = 43;
            this.label7.Text = "DELETE ALL RECORDS";
            // 
            // Admin_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.del_btn);
            this.Name = "Admin_Delete";
            this.Size = new System.Drawing.Size(862, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Label label7;
    }
}
