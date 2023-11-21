namespace bsu_tnue_lipa_rpg
{
    partial class Game_mechanics
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
            this.t4_pbox = new System.Windows.Forms.PictureBox();
            this.t3_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.t4_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // t4_pbox
            // 
            this.t4_pbox.BackColor = System.Drawing.Color.Transparent;
            this.t4_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.tutorial_4;
            this.t4_pbox.Location = new System.Drawing.Point(39, 12);
            this.t4_pbox.Name = "t4_pbox";
            this.t4_pbox.Size = new System.Drawing.Size(1073, 601);
            this.t4_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.t4_pbox.TabIndex = 0;
            this.t4_pbox.TabStop = false;
            this.t4_pbox.Visible = false;
            // 
            // t3_pbox
            // 
            this.t3_pbox.BackColor = System.Drawing.Color.Transparent;
            this.t3_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.tutorial_3;
            this.t3_pbox.Location = new System.Drawing.Point(39, 12);
            this.t3_pbox.Name = "t3_pbox";
            this.t3_pbox.Size = new System.Drawing.Size(1073, 601);
            this.t3_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.t3_pbox.TabIndex = 1;
            this.t3_pbox.TabStop = false;
            this.t3_pbox.Visible = false;
            // 
            // Game_mechanics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.map_blur;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.t3_pbox);
            this.Controls.Add(this.t4_pbox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game_mechanics";
            this.Text = "Game_mechanics";
            ((System.ComponentModel.ISupportInitialize)(this.t4_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox t4_pbox;
        private System.Windows.Forms.PictureBox t3_pbox;
    }
}