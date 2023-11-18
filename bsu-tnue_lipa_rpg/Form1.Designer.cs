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
            this.loginAcc_btn.BackColor = System.Drawing.Color.Maroon;
            this.loginAcc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAcc_btn.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAcc_btn.ForeColor = System.Drawing.Color.White;
            this.loginAcc_btn.Location = new System.Drawing.Point(351, 200);
            this.loginAcc_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginAcc_btn.Name = "loginAcc_btn";
            this.loginAcc_btn.Size = new System.Drawing.Size(477, 117);
            this.loginAcc_btn.TabIndex = 1;
            this.loginAcc_btn.Text = "LOGIN ACCOUNT";
            this.loginAcc_btn.UseVisualStyleBackColor = false;
            this.loginAcc_btn.Click += new System.EventHandler(this.loginAcc_btn_Click);
            // 
            // signupAcc_btn
            // 
            this.signupAcc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupAcc_btn.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupAcc_btn.Location = new System.Drawing.Point(351, 345);
            this.signupAcc_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupAcc_btn.Name = "signupAcc_btn";
            this.signupAcc_btn.Size = new System.Drawing.Size(477, 116);
            this.signupAcc_btn.TabIndex = 2;
            this.signupAcc_btn.Text = "Create Account";
            this.signupAcc_btn.UseVisualStyleBackColor = true;
            this.signupAcc_btn.Click += new System.EventHandler(this.signupAcc_btn_Click);
            // 
            // set_up_btn
            // 
            this.set_up_btn.Location = new System.Drawing.Point(1018, 582);
            this.set_up_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.set_up_btn.Name = "set_up_btn";
            this.set_up_btn.Size = new System.Drawing.Size(103, 35);
            this.set_up_btn.TabIndex = 3;
            this.set_up_btn.Text = "Set-Up";
            this.set_up_btn.UseVisualStyleBackColor = true;
            this.set_up_btn.Click += new System.EventHandler(this.set_up_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 589);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click Here first if it is your first time downloading the game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.set_up_btn);
            this.Controls.Add(this.signupAcc_btn);
            this.Controls.Add(this.loginAcc_btn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
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

