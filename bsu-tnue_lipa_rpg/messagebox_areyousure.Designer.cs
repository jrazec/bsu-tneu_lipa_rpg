namespace bsu_tnue_lipa_rpg
{
    partial class messagebox_areyousure
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
            this.label2 = new System.Windows.Forms.Label();
            this.yes_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.no_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "YOU\'VE COME A LONG WAY SPARTAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 72);
            this.label2.TabIndex = 10;
            this.label2.Text = "ARE YOU SURE?";
            // 
            // yes_btn
            // 
            this.yes_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_btn.ForeColor = System.Drawing.Color.Maroon;
            this.yes_btn.Location = new System.Drawing.Point(345, 253);
            this.yes_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(93, 32);
            this.yes_btn.TabIndex = 9;
            this.yes_btn.Text = "YES";
            this.yes_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.spartan_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(216, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // no_btn
            // 
            this.no_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_btn.ForeColor = System.Drawing.Color.Maroon;
            this.no_btn.Location = new System.Drawing.Point(444, 253);
            this.no_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(93, 32);
            this.no_btn.TabIndex = 13;
            this.no_btn.Text = "NO";
            this.no_btn.UseVisualStyleBackColor = true;
            // 
            // messagebox_areyousure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(549, 298);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "messagebox_areyousure";
            this.Text = "WILL OF COURAGE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button no_btn;
    }
}