namespace bsu_tnue_lipa_rpg
{
    partial class Admin_Read
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gmplay_btn = new System.Windows.Forms.Button();
            this.students_btn = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.achie_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmplay_btn
            // 
            this.gmplay_btn.BackColor = System.Drawing.Color.White;
            this.gmplay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gmplay_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmplay_btn.ForeColor = System.Drawing.Color.Black;
            this.gmplay_btn.Location = new System.Drawing.Point(226, 17);
            this.gmplay_btn.Name = "gmplay_btn";
            this.gmplay_btn.Size = new System.Drawing.Size(87, 31);
            this.gmplay_btn.TabIndex = 33;
            this.gmplay_btn.Text = "GAMEPLAY";
            this.gmplay_btn.UseVisualStyleBackColor = false;
            // 
            // students_btn
            // 
            this.students_btn.BackColor = System.Drawing.Color.LightCoral;
            this.students_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.students_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students_btn.ForeColor = System.Drawing.Color.White;
            this.students_btn.Location = new System.Drawing.Point(30, 17);
            this.students_btn.Name = "students_btn";
            this.students_btn.Size = new System.Drawing.Size(87, 31);
            this.students_btn.TabIndex = 31;
            this.students_btn.Text = "STUDENTS";
            this.students_btn.UseVisualStyleBackColor = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GENDER";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IGN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SR-CODE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Full Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // dgrid
            // 
            this.dgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid.ColumnHeadersHeight = 50;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgrid.Location = new System.Drawing.Point(0, 0);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowHeadersVisible = false;
            this.dgrid.RowHeadersWidth = 51;
            this.dgrid.RowTemplate.Height = 24;
            this.dgrid.Size = new System.Drawing.Size(802, 417);
            this.dgrid.TabIndex = 0;
            this.dgrid.Visible = false;
            // 
            // achie_btn
            // 
            this.achie_btn.BackColor = System.Drawing.Color.Firebrick;
            this.achie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.achie_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achie_btn.ForeColor = System.Drawing.Color.White;
            this.achie_btn.Location = new System.Drawing.Point(128, 17);
            this.achie_btn.Name = "achie_btn";
            this.achie_btn.Size = new System.Drawing.Size(87, 31);
            this.achie_btn.TabIndex = 32;
            this.achie_btn.Text = "ACHIEVERS";
            this.achie_btn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgrid);
            this.panel4.Location = new System.Drawing.Point(30, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 417);
            this.panel4.TabIndex = 30;
            // 
            // Admin_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.gmplay_btn);
            this.Controls.Add(this.students_btn);
            this.Controls.Add(this.achie_btn);
            this.Controls.Add(this.panel4);
            this.Name = "Admin_Read";
            this.Size = new System.Drawing.Size(862, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gmplay_btn;
        private System.Windows.Forms.Button students_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.Button achie_btn;
        private System.Windows.Forms.Panel panel4;
    }
}
