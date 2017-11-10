namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginemp_txt_User = new System.Windows.Forms.TextBox();
            this.loginemp_txt_Pass = new System.Windows.Forms.TextBox();
            this.loginemp_lbl_User = new System.Windows.Forms.Label();
            this.loginemp_lbl_Pass = new System.Windows.Forms.Label();
            this.loginemp_btn_Login = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aTMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginatm_lbl_Bic = new System.Windows.Forms.Label();
            this.loginatm_txt_Bic = new System.Windows.Forms.TextBox();
            this.loginatm_lbl_Pin = new System.Windows.Forms.Label();
            this.loginatm_txt_Pin = new System.Windows.Forms.TextBox();
            this.loginatm_btn_Login = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginemp_txt_User
            // 
            this.loginemp_txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginemp_txt_User.Location = new System.Drawing.Point(15, 65);
            this.loginemp_txt_User.MaxLength = 24;
            this.loginemp_txt_User.Name = "loginemp_txt_User";
            this.loginemp_txt_User.Size = new System.Drawing.Size(284, 26);
            this.loginemp_txt_User.TabIndex = 0;
            // 
            // loginemp_txt_Pass
            // 
            this.loginemp_txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginemp_txt_Pass.Location = new System.Drawing.Point(15, 117);
            this.loginemp_txt_Pass.MaxLength = 24;
            this.loginemp_txt_Pass.Name = "loginemp_txt_Pass";
            this.loginemp_txt_Pass.Size = new System.Drawing.Size(284, 26);
            this.loginemp_txt_Pass.TabIndex = 1;
            this.loginemp_txt_Pass.UseSystemPasswordChar = true;
            // 
            // loginemp_lbl_User
            // 
            this.loginemp_lbl_User.AutoSize = true;
            this.loginemp_lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.loginemp_lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginemp_lbl_User.ForeColor = System.Drawing.Color.White;
            this.loginemp_lbl_User.Location = new System.Drawing.Point(11, 42);
            this.loginemp_lbl_User.Name = "loginemp_lbl_User";
            this.loginemp_lbl_User.Size = new System.Drawing.Size(91, 20);
            this.loginemp_lbl_User.TabIndex = 2;
            this.loginemp_lbl_User.Text = "Username";
            // 
            // loginemp_lbl_Pass
            // 
            this.loginemp_lbl_Pass.AutoSize = true;
            this.loginemp_lbl_Pass.BackColor = System.Drawing.Color.Transparent;
            this.loginemp_lbl_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginemp_lbl_Pass.ForeColor = System.Drawing.Color.White;
            this.loginemp_lbl_Pass.Location = new System.Drawing.Point(11, 94);
            this.loginemp_lbl_Pass.Name = "loginemp_lbl_Pass";
            this.loginemp_lbl_Pass.Size = new System.Drawing.Size(86, 20);
            this.loginemp_lbl_Pass.TabIndex = 3;
            this.loginemp_lbl_Pass.Text = "Password";
            // 
            // loginemp_btn_Login
            // 
            this.loginemp_btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(44)))), ((int)(((byte)(185)))));
            this.loginemp_btn_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginemp_btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(44)))), ((int)(((byte)(185)))));
            this.loginemp_btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(197)))));
            this.loginemp_btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(44)))), ((int)(((byte)(185)))));
            this.loginemp_btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginemp_btn_Login.ForeColor = System.Drawing.Color.White;
            this.loginemp_btn_Login.Location = new System.Drawing.Point(223, 149);
            this.loginemp_btn_Login.Name = "loginemp_btn_Login";
            this.loginemp_btn_Login.Size = new System.Drawing.Size(75, 23);
            this.loginemp_btn_Login.TabIndex = 4;
            this.loginemp_btn_Login.Text = "Login";
            this.loginemp_btn_Login.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.aTMToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // aTMToolStripMenuItem
            // 
            this.aTMToolStripMenuItem.Name = "aTMToolStripMenuItem";
            this.aTMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aTMToolStripMenuItem.Text = "ATM";
            this.aTMToolStripMenuItem.Click += new System.EventHandler(this.aTMToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeProgrammToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // closeProgrammToolStripMenuItem
            // 
            this.closeProgrammToolStripMenuItem.Name = "closeProgrammToolStripMenuItem";
            this.closeProgrammToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeProgrammToolStripMenuItem.Text = "Close Programm";
            this.closeProgrammToolStripMenuItem.Click += new System.EventHandler(this.closeProgrammToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem1,
            this.aTMToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem1.Text = "Employee";
            // 
            // aTMToolStripMenuItem1
            // 
            this.aTMToolStripMenuItem1.Name = "aTMToolStripMenuItem1";
            this.aTMToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.aTMToolStripMenuItem1.Text = "ATM";
            // 
            // loginatm_lbl_Bic
            // 
            this.loginatm_lbl_Bic.AutoSize = true;
            this.loginatm_lbl_Bic.BackColor = System.Drawing.Color.Transparent;
            this.loginatm_lbl_Bic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginatm_lbl_Bic.ForeColor = System.Drawing.Color.White;
            this.loginatm_lbl_Bic.Location = new System.Drawing.Point(12, 42);
            this.loginatm_lbl_Bic.Name = "loginatm_lbl_Bic";
            this.loginatm_lbl_Bic.Size = new System.Drawing.Size(39, 20);
            this.loginatm_lbl_Bic.TabIndex = 8;
            this.loginatm_lbl_Bic.Text = "BIC";
            this.loginatm_lbl_Bic.Visible = false;
            // 
            // loginatm_txt_Bic
            // 
            this.loginatm_txt_Bic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginatm_txt_Bic.Location = new System.Drawing.Point(15, 65);
            this.loginatm_txt_Bic.MaxLength = 24;
            this.loginatm_txt_Bic.Name = "loginatm_txt_Bic";
            this.loginatm_txt_Bic.Size = new System.Drawing.Size(284, 26);
            this.loginatm_txt_Bic.TabIndex = 9;
            this.loginatm_txt_Bic.Visible = false;
            // 
            // loginatm_lbl_Pin
            // 
            this.loginatm_lbl_Pin.AutoSize = true;
            this.loginatm_lbl_Pin.BackColor = System.Drawing.Color.Transparent;
            this.loginatm_lbl_Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginatm_lbl_Pin.ForeColor = System.Drawing.Color.White;
            this.loginatm_lbl_Pin.Location = new System.Drawing.Point(12, 94);
            this.loginatm_lbl_Pin.Name = "loginatm_lbl_Pin";
            this.loginatm_lbl_Pin.Size = new System.Drawing.Size(34, 20);
            this.loginatm_lbl_Pin.TabIndex = 10;
            this.loginatm_lbl_Pin.Text = "Pin";
            this.loginatm_lbl_Pin.Visible = false;
            // 
            // loginatm_txt_Pin
            // 
            this.loginatm_txt_Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginatm_txt_Pin.Location = new System.Drawing.Point(16, 117);
            this.loginatm_txt_Pin.MaxLength = 4;
            this.loginatm_txt_Pin.Name = "loginatm_txt_Pin";
            this.loginatm_txt_Pin.Size = new System.Drawing.Size(284, 26);
            this.loginatm_txt_Pin.TabIndex = 11;
            this.loginatm_txt_Pin.Visible = false;
            // 
            // loginatm_btn_Login
            // 
            this.loginatm_btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(44)))), ((int)(((byte)(185)))));
            this.loginatm_btn_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginatm_btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(44)))), ((int)(((byte)(185)))));
            this.loginatm_btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(197)))));
            this.loginatm_btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(44)))), ((int)(((byte)(185)))));
            this.loginatm_btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginatm_btn_Login.ForeColor = System.Drawing.Color.White;
            this.loginatm_btn_Login.Location = new System.Drawing.Point(223, 149);
            this.loginatm_btn_Login.Name = "loginatm_btn_Login";
            this.loginatm_btn_Login.Size = new System.Drawing.Size(75, 23);
            this.loginatm_btn_Login.TabIndex = 12;
            this.loginatm_btn_Login.Text = "Login";
            this.loginatm_btn_Login.UseVisualStyleBackColor = false;
            this.loginatm_btn_Login.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wall1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 183);
            this.Controls.Add(this.loginatm_btn_Login);
            this.Controls.Add(this.loginatm_txt_Pin);
            this.Controls.Add(this.loginatm_lbl_Pin);
            this.Controls.Add(this.loginatm_txt_Bic);
            this.Controls.Add(this.loginatm_lbl_Bic);
            this.Controls.Add(this.loginemp_btn_Login);
            this.Controls.Add(this.loginemp_lbl_Pass);
            this.Controls.Add(this.loginemp_lbl_User);
            this.Controls.Add(this.loginemp_txt_Pass);
            this.Controls.Add(this.loginemp_txt_User);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MAZE Banksystem | Employee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginemp_txt_User;
        private System.Windows.Forms.TextBox loginemp_txt_Pass;
        private System.Windows.Forms.Label loginemp_lbl_User;
        private System.Windows.Forms.Label loginemp_lbl_Pass;
        private System.Windows.Forms.Button loginemp_btn_Login;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aTMToolStripMenuItem1;
        private System.Windows.Forms.Label loginatm_lbl_Bic;
        private System.Windows.Forms.TextBox loginatm_txt_Bic;
        private System.Windows.Forms.Label loginatm_lbl_Pin;
        private System.Windows.Forms.TextBox loginatm_txt_Pin;
        private System.Windows.Forms.Button loginatm_btn_Login;
    }
}

