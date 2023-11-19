namespace bsu_tnue_lipa_rpg
{
    partial class Form1
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
            this.loginAcc_btn = new System.Windows.Forms.Button();
            this.signupAcc_btn = new System.Windows.Forms.Button();
            this.set_up_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginAcc_btn
            // 
            this.loginAcc_btn.BackColor = System.Drawing.Color.White;
            this.loginAcc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAcc_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAcc_btn.ForeColor = System.Drawing.Color.Black;
            this.loginAcc_btn.Location = new System.Drawing.Point(361, 292);
            this.loginAcc_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginAcc_btn.Name = "loginAcc_btn";
            this.loginAcc_btn.Size = new System.Drawing.Size(428, 89);
            this.loginAcc_btn.TabIndex = 1;
            this.loginAcc_btn.Text = "LOGIN ACCOUNT";
            this.loginAcc_btn.UseVisualStyleBackColor = false;
            this.loginAcc_btn.Click += new System.EventHandler(this.loginAcc_btn_Click);
            // 
            // signupAcc_btn
            // 
            this.signupAcc_btn.BackColor = System.Drawing.Color.Maroon;
            this.signupAcc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupAcc_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupAcc_btn.ForeColor = System.Drawing.Color.White;
            this.signupAcc_btn.Location = new System.Drawing.Point(361, 400);
            this.signupAcc_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupAcc_btn.Name = "signupAcc_btn";
            this.signupAcc_btn.Size = new System.Drawing.Size(428, 88);
            this.signupAcc_btn.TabIndex = 2;
            this.signupAcc_btn.Text = "Create Account";
            this.signupAcc_btn.UseVisualStyleBackColor = false;
            this.signupAcc_btn.Click += new System.EventHandler(this.signupAcc_btn_Click);
            // 
            // set_up_btn
            // 
            this.set_up_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_up_btn.ForeColor = System.Drawing.Color.Black;
            this.set_up_btn.Location = new System.Drawing.Point(1060, 597);
            this.set_up_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.set_up_btn.Name = "set_up_btn";
            this.set_up_btn.Size = new System.Drawing.Size(78, 29);
            this.set_up_btn.TabIndex = 3;
            this.set_up_btn.Text = "SET-UP";
            this.set_up_btn.UseVisualStyleBackColor = true;
            this.set_up_btn.Click += new System.EventHandler(this.set_up_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(930, 602);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "For first time players";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.set_up_btn);
            this.Controls.Add(this.signupAcc_btn);
            this.Controls.Add(this.loginAcc_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginAcc_btn;
        private System.Windows.Forms.Button signupAcc_btn;
        private System.Windows.Forms.Button set_up_btn;
        private System.Windows.Forms.Label label1;
    }
}

