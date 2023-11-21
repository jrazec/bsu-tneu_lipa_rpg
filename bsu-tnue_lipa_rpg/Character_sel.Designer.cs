namespace bsu_tnue_lipa_rpg
{
    partial class Character_sel
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
            this.dg1_pbox = new System.Windows.Forms.PictureBox();
            this.dg_chracter_sel1 = new System.Windows.Forms.Label();
            this.ign_tbox = new System.Windows.Forms.TextBox();
            this.dg_clicknxt_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg1_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // dg1_pbox
            // 
            this.dg1_pbox.BackColor = System.Drawing.Color.Transparent;
            this.dg1_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.dialogue_base;
            this.dg1_pbox.Location = new System.Drawing.Point(106, 463);
            this.dg1_pbox.Name = "dg1_pbox";
            this.dg1_pbox.Size = new System.Drawing.Size(954, 174);
            this.dg1_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dg1_pbox.TabIndex = 0;
            this.dg1_pbox.TabStop = false;
            // 
            // dg_chracter_sel1
            // 
            this.dg_chracter_sel1.AutoSize = true;
            this.dg_chracter_sel1.BackColor = System.Drawing.Color.Transparent;
            this.dg_chracter_sel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_chracter_sel1.ForeColor = System.Drawing.Color.White;
            this.dg_chracter_sel1.Location = new System.Drawing.Point(212, 525);
            this.dg_chracter_sel1.Name = "dg_chracter_sel1";
            this.dg_chracter_sel1.Size = new System.Drawing.Size(524, 28);
            this.dg_chracter_sel1.TabIndex = 1;
            this.dg_chracter_sel1.Text = "Welcome to your bedroom! But first what do you want to be called?";
            // 
            // ign_tbox
            // 
            this.ign_tbox.BackColor = System.Drawing.Color.White;
            this.ign_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ign_tbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ign_tbox.ForeColor = System.Drawing.Color.Black;
            this.ign_tbox.Location = new System.Drawing.Point(758, 525);
            this.ign_tbox.Name = "ign_tbox";
            this.ign_tbox.Size = new System.Drawing.Size(198, 28);
            this.ign_tbox.TabIndex = 2;
            this.ign_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dg_clicknxt_lbl
            // 
            this.dg_clicknxt_lbl.AutoSize = true;
            this.dg_clicknxt_lbl.BackColor = System.Drawing.Color.Transparent;
            this.dg_clicknxt_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_clicknxt_lbl.ForeColor = System.Drawing.Color.White;
            this.dg_clicknxt_lbl.Location = new System.Drawing.Point(840, 588);
            this.dg_clicknxt_lbl.Name = "dg_clicknxt_lbl";
            this.dg_clicknxt_lbl.Size = new System.Drawing.Size(116, 18);
            this.dg_clicknxt_lbl.TabIndex = 3;
            this.dg_clicknxt_lbl.Text = "Click to proceed....";
            // 
            // Character_sel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.bedroom;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.dg_clicknxt_lbl);
            this.Controls.Add(this.ign_tbox);
            this.Controls.Add(this.dg_chracter_sel1);
            this.Controls.Add(this.dg1_pbox);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Character_sel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character_sel";
            this.Load += new System.EventHandler(this.Character_sel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dg1_pbox;
        private System.Windows.Forms.Label dg_chracter_sel1;
        private System.Windows.Forms.TextBox ign_tbox;
        private System.Windows.Forms.Label dg_clicknxt_lbl;
    }
}