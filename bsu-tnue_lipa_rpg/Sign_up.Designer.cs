namespace bsu_tnue_lipa_rpg
{
    partial class Sign_up
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Crt_sr_code_tbox = new System.Windows.Forms.TextBox();
            this.Crt_password_tbox = new System.Windows.Forms.TextBox();
            this.Crt_first_name_tbox = new System.Windows.Forms.TextBox();
            this.Crt_last_name_tbox = new System.Windows.Forms.TextBox();
            this.Crt_gender_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password_validator_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(577, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "continue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Crt_sr_code_tbox
            // 
            this.Crt_sr_code_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crt_sr_code_tbox.Location = new System.Drawing.Point(332, 181);
            this.Crt_sr_code_tbox.Name = "Crt_sr_code_tbox";
            this.Crt_sr_code_tbox.Size = new System.Drawing.Size(196, 41);
            this.Crt_sr_code_tbox.TabIndex = 2;
            // 
            // Crt_password_tbox
            // 
            this.Crt_password_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crt_password_tbox.Location = new System.Drawing.Point(332, 359);
            this.Crt_password_tbox.Name = "Crt_password_tbox";
            this.Crt_password_tbox.Size = new System.Drawing.Size(196, 41);
            this.Crt_password_tbox.TabIndex = 3;
            // 
            // Crt_first_name_tbox
            // 
            this.Crt_first_name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crt_first_name_tbox.Location = new System.Drawing.Point(605, 181);
            this.Crt_first_name_tbox.Name = "Crt_first_name_tbox";
            this.Crt_first_name_tbox.Size = new System.Drawing.Size(196, 41);
            this.Crt_first_name_tbox.TabIndex = 3;
            this.Crt_first_name_tbox.TextChanged += new System.EventHandler(this.Crt_first_name_tbox_TextChanged);
            // 
            // Crt_last_name_tbox
            // 
            this.Crt_last_name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crt_last_name_tbox.Location = new System.Drawing.Point(332, 270);
            this.Crt_last_name_tbox.Name = "Crt_last_name_tbox";
            this.Crt_last_name_tbox.Size = new System.Drawing.Size(196, 41);
            this.Crt_last_name_tbox.TabIndex = 4;
            // 
            // Crt_gender_tbox
            // 
            this.Crt_gender_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crt_gender_tbox.Location = new System.Drawing.Point(605, 270);
            this.Crt_gender_tbox.Name = "Crt_gender_tbox";
            this.Crt_gender_tbox.Size = new System.Drawing.Size(196, 41);
            this.Crt_gender_tbox.TabIndex = 5;
            this.Crt_gender_tbox.TextChanged += new System.EventHandler(this.Crt_gender_tbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter your sr_code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(659, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(672, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(389, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // password_validator_tbox
            // 
            this.password_validator_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_validator_tbox.Location = new System.Drawing.Point(605, 359);
            this.password_validator_tbox.Name = "password_validator_tbox";
            this.password_validator_tbox.Size = new System.Drawing.Size(196, 41);
            this.password_validator_tbox.TabIndex = 11;
            this.password_validator_tbox.TextChanged += new System.EventHandler(this.password_validator_tbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(630, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Re-Type Password:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1133, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password_validator_tbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Crt_gender_tbox);
            this.Controls.Add(this.Crt_last_name_tbox);
            this.Controls.Add(this.Crt_first_name_tbox);
            this.Controls.Add(this.Crt_password_tbox);
            this.Controls.Add(this.Crt_sr_code_tbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Crt_sr_code_tbox;
        private System.Windows.Forms.TextBox Crt_password_tbox;
        private System.Windows.Forms.TextBox Crt_first_name_tbox;
        private System.Windows.Forms.TextBox Crt_last_name_tbox;
        private System.Windows.Forms.TextBox Crt_gender_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_validator_tbox;
        private System.Windows.Forms.Label label6;
    }
}