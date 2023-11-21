namespace bsu_tnue_lipa_rpg
{
    partial class Facade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guard_pbox = new System.Windows.Forms.PictureBox();
            this.facade_charac = new System.Windows.Forms.PictureBox();
            this.interactcollision_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guard_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facade_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interactcollision_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 50);
            this.panel1.TabIndex = 0;
            // 
            // guard_pbox
            // 
            this.guard_pbox.BackColor = System.Drawing.Color.Transparent;
            this.guard_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Guard;
            this.guard_pbox.Location = new System.Drawing.Point(673, 146);
            this.guard_pbox.Name = "guard_pbox";
            this.guard_pbox.Size = new System.Drawing.Size(149, 229);
            this.guard_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guard_pbox.TabIndex = 1;
            this.guard_pbox.TabStop = false;
            // 
            // facade_charac
            // 
            this.facade_charac.BackColor = System.Drawing.Color.Transparent;
            this.facade_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.male_uni_back;
            this.facade_charac.Location = new System.Drawing.Point(449, 398);
            this.facade_charac.Name = "facade_charac";
            this.facade_charac.Size = new System.Drawing.Size(128, 229);
            this.facade_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facade_charac.TabIndex = 2;
            this.facade_charac.TabStop = false;
            // 
            // interactcollision_pbox
            // 
            this.interactcollision_pbox.Location = new System.Drawing.Point(463, 146);
            this.interactcollision_pbox.Name = "interactcollision_pbox";
            this.interactcollision_pbox.Size = new System.Drawing.Size(189, 28);
            this.interactcollision_pbox.TabIndex = 3;
            this.interactcollision_pbox.TabStop = false;
            // 
            // Facade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.facade;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.interactcollision_pbox);
            this.Controls.Add(this.facade_charac);
            this.Controls.Add(this.guard_pbox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facade";
            ((System.ComponentModel.ISupportInitialize)(this.guard_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facade_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interactcollision_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox guard_pbox;
        private System.Windows.Forms.PictureBox facade_charac;
        private System.Windows.Forms.PictureBox interactcollision_pbox;
    }
}