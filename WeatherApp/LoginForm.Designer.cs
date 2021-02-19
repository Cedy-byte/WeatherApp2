namespace WeatherApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tabCrtlLoginForm = new System.Windows.Forms.TabControl();
            this.tabctrlLogin = new System.Windows.Forms.TabPage();
            this.btnLoginPass = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabctrlSignUp = new System.Windows.Forms.TabPage();
            this.btnCrtChar = new System.Windows.Forms.Button();
            this.btnConfChar = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblCreatePass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.tabCrtlLoginForm.SuspendLayout();
            this.tabctrlLogin.SuspendLayout();
            this.tabctrlSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCrtlLoginForm
            // 
            this.tabCrtlLoginForm.Controls.Add(this.tabctrlLogin);
            this.tabCrtlLoginForm.Controls.Add(this.tabctrlSignUp);
            this.tabCrtlLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCrtlLoginForm.Location = new System.Drawing.Point(3, 0);
            this.tabCrtlLoginForm.Name = "tabCrtlLoginForm";
            this.tabCrtlLoginForm.SelectedIndex = 0;
            this.tabCrtlLoginForm.Size = new System.Drawing.Size(795, 447);
            this.tabCrtlLoginForm.TabIndex = 0;
            // 
            // tabctrlLogin
            // 
            this.tabctrlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabctrlLogin.BackgroundImage")));
            this.tabctrlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabctrlLogin.Controls.Add(this.btnLoginPass);
            this.tabctrlLogin.Controls.Add(this.lblHeader);
            this.tabctrlLogin.Controls.Add(this.btnLogin);
            this.tabctrlLogin.Controls.Add(this.txtPassword);
            this.tabctrlLogin.Controls.Add(this.txtUsername);
            this.tabctrlLogin.Controls.Add(this.lblSurname);
            this.tabctrlLogin.Controls.Add(this.lblUsername);
            this.tabctrlLogin.Location = new System.Drawing.Point(4, 29);
            this.tabctrlLogin.Name = "tabctrlLogin";
            this.tabctrlLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabctrlLogin.Size = new System.Drawing.Size(787, 414);
            this.tabctrlLogin.TabIndex = 0;
            this.tabctrlLogin.Text = "Login";
            this.tabctrlLogin.UseVisualStyleBackColor = true;
            // 
            // btnLoginPass
            // 
            this.btnLoginPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginPass.BackgroundImage")));
            this.btnLoginPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoginPass.Location = new System.Drawing.Point(431, 227);
            this.btnLoginPass.Name = "btnLoginPass";
            this.btnLoginPass.Size = new System.Drawing.Size(45, 26);
            this.btnLoginPass.TabIndex = 77;
            this.btnLoginPass.UseVisualStyleBackColor = true;
            this.btnLoginPass.Click += new System.EventHandler(this.btnLoginPass_Click);
            this.btnLoginPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLoginPass_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(319, 69);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(87, 30);
            this.lblHeader.TabIndex = 76;
            this.lblHeader.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(293, 274);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 40);
            this.btnLogin.TabIndex = 75;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(293, 227);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 26);
            this.txtPassword.TabIndex = 74;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(293, 186);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 26);
            this.txtUsername.TabIndex = 73;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(191, 233);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 20);
            this.lblSurname.TabIndex = 72;
            this.lblSurname.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(191, 192);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 71;
            this.lblUsername.Text = "Userame:";
            // 
            // tabctrlSignUp
            // 
            this.tabctrlSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabctrlSignUp.BackgroundImage")));
            this.tabctrlSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabctrlSignUp.Controls.Add(this.btnCrtChar);
            this.tabctrlSignUp.Controls.Add(this.btnConfChar);
            this.tabctrlSignUp.Controls.Add(this.btnCreate);
            this.tabctrlSignUp.Controls.Add(this.cmbUserType);
            this.tabctrlSignUp.Controls.Add(this.txtConfirmPass);
            this.tabctrlSignUp.Controls.Add(this.txtPass);
            this.tabctrlSignUp.Controls.Add(this.txtCreateUser);
            this.tabctrlSignUp.Controls.Add(this.lblUserType);
            this.tabctrlSignUp.Controls.Add(this.lblConfirmPass);
            this.tabctrlSignUp.Controls.Add(this.lblCreatePass);
            this.tabctrlSignUp.Controls.Add(this.lblUser);
            this.tabctrlSignUp.Controls.Add(this.lblNewUser);
            this.tabctrlSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrlSignUp.Location = new System.Drawing.Point(4, 29);
            this.tabctrlSignUp.Name = "tabctrlSignUp";
            this.tabctrlSignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabctrlSignUp.Size = new System.Drawing.Size(787, 414);
            this.tabctrlSignUp.TabIndex = 1;
            this.tabctrlSignUp.Text = "Sign Up";
            this.tabctrlSignUp.UseVisualStyleBackColor = true;
            // 
            // btnCrtChar
            // 
            this.btnCrtChar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrtChar.BackgroundImage")));
            this.btnCrtChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrtChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrtChar.Location = new System.Drawing.Point(486, 173);
            this.btnCrtChar.Name = "btnCrtChar";
            this.btnCrtChar.Size = new System.Drawing.Size(45, 26);
            this.btnCrtChar.TabIndex = 69;
            this.btnCrtChar.UseVisualStyleBackColor = true;
            this.btnCrtChar.Click += new System.EventHandler(this.btnCrtChar_Click);
            this.btnCrtChar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCrtChar_Click);
            // 
            // btnConfChar
            // 
            this.btnConfChar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfChar.BackgroundImage")));
            this.btnConfChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfChar.Location = new System.Drawing.Point(486, 208);
            this.btnConfChar.Name = "btnConfChar";
            this.btnConfChar.Size = new System.Drawing.Size(45, 26);
            this.btnConfChar.TabIndex = 68;
            this.btnConfChar.UseVisualStyleBackColor = true;
            this.btnConfChar.Click += new System.EventHandler(this.btnConfChar_Click);
            this.btnConfChar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnConfChar_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(338, 305);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(193, 41);
            this.btnCreate.TabIndex = 67;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "General User"});
            this.cmbUserType.Location = new System.Drawing.Point(338, 249);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(193, 28);
            this.cmbUserType.TabIndex = 66;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(338, 208);
            this.txtConfirmPass.MaxLength = 8;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(193, 26);
            this.txtConfirmPass.TabIndex = 65;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(338, 173);
            this.txtPass.MaxLength = 8;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(193, 26);
            this.txtPass.TabIndex = 64;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUser.Location = new System.Drawing.Point(338, 132);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(193, 26);
            this.txtCreateUser.TabIndex = 63;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(198, 257);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(85, 20);
            this.lblUserType.TabIndex = 62;
            this.lblUserType.Text = "User Type:";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(198, 214);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(141, 20);
            this.lblConfirmPass.TabIndex = 61;
            this.lblConfirmPass.Text = "Confirm Password:";
            // 
            // lblCreatePass
            // 
            this.lblCreatePass.AutoSize = true;
            this.lblCreatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePass.Location = new System.Drawing.Point(198, 179);
            this.lblCreatePass.Name = "lblCreatePass";
            this.lblCreatePass.Size = new System.Drawing.Size(134, 20);
            this.lblCreatePass.TabIndex = 60;
            this.lblCreatePass.Text = "Create Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(198, 138);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 20);
            this.lblUser.TabIndex = 59;
            this.lblUser.Text = "Userame:";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.Location = new System.Drawing.Point(231, 63);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(291, 32);
            this.lblNewUser.TabIndex = 58;
            this.lblNewUser.Text = "Register New User";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCrtlLoginForm);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabCrtlLoginForm.ResumeLayout(false);
            this.tabctrlLogin.ResumeLayout(false);
            this.tabctrlLogin.PerformLayout();
            this.tabctrlSignUp.ResumeLayout(false);
            this.tabctrlSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCrtlLoginForm;
        private System.Windows.Forms.TabPage tabctrlLogin;
        private System.Windows.Forms.Button btnLoginPass;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TabPage tabctrlSignUp;
        private System.Windows.Forms.Button btnCrtChar;
        private System.Windows.Forms.Button btnConfChar;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblCreatePass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNewUser;
    }
}