namespace bsu_tnue_lipa_rpg
{
    partial class Admin_Create
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.create_pbox = new System.Windows.Forms.PictureBox();
            this.create_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Maroon;
            this.exit_btn.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.power;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Maroon;
            this.exit_btn.Location = new System.Drawing.Point(1098, 587);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(42, 40);
            this.exit_btn.TabIndex = 20;
            this.exit_btn.UseVisualStyleBackColor = false;
            // 
            // create_pbox
            // 
            this.create_pbox.Location = new System.Drawing.Point(265, 71);
            this.create_pbox.Name = "create_pbox";
            this.create_pbox.Size = new System.Drawing.Size(705, 436);
            this.create_pbox.TabIndex = 21;
            this.create_pbox.TabStop = false;
            // 
            // create_btn
            // 
            this.create_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Location = new System.Drawing.Point(265, 549);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(96, 40);
            this.create_btn.TabIndex = 22;
            this.create_btn.Text = "CREATE";
            this.create_btn.UseVisualStyleBackColor = true;
            // 
            // Admin_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.create_pbox);
            this.Controls.Add(this.exit_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_Create";
            this.Size = new System.Drawing.Size(1151, 639);
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox create_pbox;
        private System.Windows.Forms.Button create_btn;
    }
}
