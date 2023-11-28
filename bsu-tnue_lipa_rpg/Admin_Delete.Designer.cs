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
            this.delete_search_txt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.del_lbl = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.del_search_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_search_txt
            // 
            this.delete_search_txt.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_search_txt.Location = new System.Drawing.Point(416, 45);
            this.delete_search_txt.Name = "delete_search_txt";
            this.delete_search_txt.Size = new System.Drawing.Size(285, 35);
            this.delete_search_txt.TabIndex = 38;
            this.delete_search_txt.Text = " ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(118, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 388);
            this.listBox1.TabIndex = 40;
            // 
            // del_lbl
            // 
            this.del_lbl.BackColor = System.Drawing.Color.White;
            this.del_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_lbl.Location = new System.Drawing.Point(416, 132);
            this.del_lbl.Name = "del_lbl";
            this.del_lbl.Size = new System.Drawing.Size(285, 35);
            this.del_lbl.TabIndex = 41;
            this.del_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // del_btn
            // 
            this.del_btn.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.trash;
            this.del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(713, 132);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(33, 35);
            this.del_btn.TabIndex = 42;
            this.del_btn.Text = " ";
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // del_search_btn
            // 
            this.del_search_btn.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.search;
            this.del_search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_search_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_search_btn.Location = new System.Drawing.Point(713, 45);
            this.del_search_btn.Name = "del_search_btn";
            this.del_search_btn.Size = new System.Drawing.Size(33, 35);
            this.del_search_btn.TabIndex = 36;
            this.del_search_btn.Text = " ";
            this.del_search_btn.UseVisualStyleBackColor = true;
            // 
            // Admin_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.del_lbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.del_search_btn);
            this.Controls.Add(this.delete_search_txt);
            this.Name = "Admin_Delete";
            this.Size = new System.Drawing.Size(862, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button del_search_btn;
        private System.Windows.Forms.TextBox delete_search_txt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label del_lbl;
        private System.Windows.Forms.Button del_btn;
    }
}
