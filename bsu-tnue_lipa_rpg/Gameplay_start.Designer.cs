namespace bsu_tnue_lipa_rpg
{
    partial class Gameplay_start
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.White;
            this.btn_play.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.Black;
            this.btn_play.Location = new System.Drawing.Point(369, 290);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(413, 76);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "START";
            this.btn_play.UseVisualStyleBackColor = false;
            // 
            // btn_options
            // 
            this.btn_options.BackColor = System.Drawing.Color.Maroon;
            this.btn_options.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_options.ForeColor = System.Drawing.Color.White;
            this.btn_options.Location = new System.Drawing.Point(369, 391);
            this.btn_options.Name = "btn_options";
            this.btn_options.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_options.Size = new System.Drawing.Size(413, 75);
            this.btn_options.TabIndex = 1;
            this.btn_options.Text = "OPTIONS";
            this.btn_options.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Maroon;
            this.btn_exit.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(369, 491);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(413, 74);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // Gameplay_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.btn_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gameplay_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay_start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Button btn_exit;
    }
}