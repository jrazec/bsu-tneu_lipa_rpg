namespace bsu_tnue_lipa_rpg
{
    partial class Bedroom
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
            this.menu_panel = new System.Windows.Forms.Panel();
            this.closetcollision_pbox = new System.Windows.Forms.PictureBox();
            this.bedroom_charac = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closetcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom_charac)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Maroon;
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1151, 50);
            this.menu_panel.TabIndex = 0;
            // 
            // closetcollision_pbox
            // 
            this.closetcollision_pbox.Location = new System.Drawing.Point(268, 182);
            this.closetcollision_pbox.Name = "closetcollision_pbox";
            this.closetcollision_pbox.Size = new System.Drawing.Size(143, 45);
            this.closetcollision_pbox.TabIndex = 1;
            this.closetcollision_pbox.TabStop = false;
            // 
            // bedroom_charac
            // 
            this.bedroom_charac.BackColor = System.Drawing.Color.Transparent;
            this.bedroom_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.male_casual_front;
            this.bedroom_charac.Location = new System.Drawing.Point(729, 406);
            this.bedroom_charac.Name = "bedroom_charac";
            this.bedroom_charac.Size = new System.Drawing.Size(162, 221);
            this.bedroom_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bedroom_charac.TabIndex = 2;
            this.bedroom_charac.TabStop = false;
            // 
            // Bedroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.bedroom;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.bedroom_charac);
            this.Controls.Add(this.closetcollision_pbox);
            this.Controls.Add(this.menu_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bedroom";
            this.Text = "Bedroom";
            ((System.ComponentModel.ISupportInitialize)(this.closetcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom_charac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox closetcollision_pbox;
        private System.Windows.Forms.PictureBox bedroom_charac;
    }
}