namespace School_management_system
{
    partial class Login
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
            this.Loginfrm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.logfrm = new System.Windows.Forms.Panel();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.usErrorLable = new System.Windows.Forms.Label();
            this.PAssErrorLable = new System.Windows.Forms.Label();
            this.Loginfrm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.logfrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loginfrm
            // 
            this.Loginfrm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Loginfrm.Controls.Add(this.panel1);
            this.Loginfrm.Controls.Add(this.logfrm);
            this.Loginfrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loginfrm.Location = new System.Drawing.Point(0, 0);
            this.Loginfrm.Name = "Loginfrm";
            this.Loginfrm.Size = new System.Drawing.Size(1170, 751);
            this.Loginfrm.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 100);
            this.panel1.TabIndex = 2;
            // 
            // Welcome
            // 
            this.Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Dubai", 27F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(255, 20);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(691, 61);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome To School Managenment System ";
            // 
            // logfrm
            // 
            this.logfrm.BackColor = System.Drawing.Color.Gainsboro;
            this.logfrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logfrm.Controls.Add(this.Loginbtn);
            this.logfrm.Controls.Add(this.passwordTxt);
            this.logfrm.Controls.Add(this.usernameTxt);
            this.logfrm.Controls.Add(this.password);
            this.logfrm.Controls.Add(this.username);
            this.logfrm.Controls.Add(this.PAssErrorLable);
            this.logfrm.Controls.Add(this.usErrorLable);
            this.logfrm.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logfrm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logfrm.Location = new System.Drawing.Point(266, 226);
            this.logfrm.Name = "logfrm";
            this.logfrm.Size = new System.Drawing.Size(680, 447);
            this.logfrm.TabIndex = 0;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.FlatAppearance.BorderSize = 2;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Dubai", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(246, 280);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(184, 44);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Dubai", 15F);
            this.passwordTxt.ForeColor = System.Drawing.Color.Gray;
            this.passwordTxt.Location = new System.Drawing.Point(94, 211);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(472, 41);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            this.passwordTxt.Enter += new System.EventHandler(this.passwordtxt_Enter);
            this.passwordTxt.Leave += new System.EventHandler(this.passwordtxt_Leave);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Dubai", 15F);
            this.usernameTxt.ForeColor = System.Drawing.Color.Gray;
            this.usernameTxt.Location = new System.Drawing.Point(94, 138);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(472, 41);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.Text = "Enter Username";
            this.usernameTxt.TextChanged += new System.EventHandler(this.Usernametxt_TextChanged);
            this.usernameTxt.Enter += new System.EventHandler(this.Usernametxt_Enter);
            this.usernameTxt.Leave += new System.EventHandler(this.Usernametxt_Leave);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Dubai", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.password.Location = new System.Drawing.Point(88, 183);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(103, 34);
            this.password.TabIndex = 0;
            this.password.Text = "Password:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Dubai", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(88, 101);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(107, 34);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // usErrorLable
            // 
            this.usErrorLable.AutoSize = true;
            this.usErrorLable.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.usErrorLable.Location = new System.Drawing.Point(546, 116);
            this.usErrorLable.Name = "usErrorLable";
            this.usErrorLable.Size = new System.Drawing.Size(25, 34);
            this.usErrorLable.TabIndex = 66;
            this.usErrorLable.Text = "*";
            this.usErrorLable.Visible = false;
            // 
            // PAssErrorLable
            // 
            this.PAssErrorLable.AutoSize = true;
            this.PAssErrorLable.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.PAssErrorLable.Location = new System.Drawing.Point(546, 190);
            this.PAssErrorLable.Name = "PAssErrorLable";
            this.PAssErrorLable.Size = new System.Drawing.Size(25, 34);
            this.PAssErrorLable.TabIndex = 67;
            this.PAssErrorLable.Text = "*";
            this.PAssErrorLable.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 751);
            this.ControlBox = false;
            this.Controls.Add(this.Loginfrm);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Loginfrm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.logfrm.ResumeLayout(false);
            this.logfrm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loginfrm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logfrm;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label usErrorLable;
        private System.Windows.Forms.Label PAssErrorLable;
    }
}