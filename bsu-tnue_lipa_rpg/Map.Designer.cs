namespace bsu_tnue_lipa_rpg
{
    partial class Map
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.map_charac = new System.Windows.Forms.PictureBox();
            this.mapWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.cecscollision_pbox = new System.Windows.Forms.PictureBox();
            this.obcollision_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.map_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecscollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obcollision_pbox)).BeginInit();
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
            // map_charac
            // 
            this.map_charac.BackColor = System.Drawing.Color.Transparent;
            this.map_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.male_uni_front;
            this.map_charac.Location = new System.Drawing.Point(509, 350);
            this.map_charac.Name = "map_charac";
            this.map_charac.Size = new System.Drawing.Size(53, 86);
            this.map_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map_charac.TabIndex = 1;
            this.map_charac.TabStop = false;
            // 
            // mapWalkTimer
            // 
            this.mapWalkTimer.Interval = 50;
            this.mapWalkTimer.Tick += new System.EventHandler(this.mapWalkTimer_Tick);
            // 
            // cecscollision_pbox
            // 
            this.cecscollision_pbox.Location = new System.Drawing.Point(159, 370);
            this.cecscollision_pbox.Name = "cecscollision_pbox";
            this.cecscollision_pbox.Size = new System.Drawing.Size(48, 213);
            this.cecscollision_pbox.TabIndex = 2;
            this.cecscollision_pbox.TabStop = false;
            // 
            // obcollision_pbox
            // 
            this.obcollision_pbox.Location = new System.Drawing.Point(980, 219);
            this.obcollision_pbox.Name = "obcollision_pbox";
            this.obcollision_pbox.Size = new System.Drawing.Size(48, 125);
            this.obcollision_pbox.TabIndex = 3;
            this.obcollision_pbox.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.map_art;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.obcollision_pbox);
            this.Controls.Add(this.cecscollision_pbox);
            this.Controls.Add(this.map_charac);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.map_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecscollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obcollision_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox map_charac;
        private System.Windows.Forms.Timer mapWalkTimer;
        private System.Windows.Forms.PictureBox cecscollision_pbox;
        private System.Windows.Forms.PictureBox obcollision_pbox;
    }
}