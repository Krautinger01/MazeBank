﻿namespace WindowsFormsApp1
{
    partial class f_Employee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_deposit = new System.Windows.Forms.Label();
            this.lbl_withdraw = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.lbl_dot = new System.Windows.Forms.Label();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_konto = new System.Windows.Forms.Label();
            this.txt_konto = new System.Windows.Forms.TextBox();
            this.btn_konto = new System.Windows.Forms.Button();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Current = new System.Windows.Forms.Label();
            this.grp_add = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.txt_add_name = new System.Windows.Forms.TextBox();
            this.txt_add_surname = new System.Windows.Forms.TextBox();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_add_adress = new System.Windows.Forms.TextBox();
            this.txt_add_phone = new System.Windows.Forms.TextBox();
            this.txt_add_num1 = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_add_mail = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_add_num2 = new System.Windows.Forms.TextBox();
            this.lbl_dot1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawToolStripMenuItem,
            this.newCustomerToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem1,
            this.withdrawToolStripMenuItem1});
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.withdrawToolStripMenuItem.Text = "cash";
            // 
            // depositToolStripMenuItem1
            // 
            this.depositToolStripMenuItem1.Name = "depositToolStripMenuItem1";
            this.depositToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.depositToolStripMenuItem1.Text = "deposit";
            this.depositToolStripMenuItem1.Click += new System.EventHandler(this.depositToolStripMenuItem1_Click);
            // 
            // withdrawToolStripMenuItem1
            // 
            this.withdrawToolStripMenuItem1.Name = "withdrawToolStripMenuItem1";
            this.withdrawToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.withdrawToolStripMenuItem1.Text = "withdraw";
            this.withdrawToolStripMenuItem1.Click += new System.EventHandler(this.withdrawToolStripMenuItem1_Click);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.newCustomerToolStripMenuItem.Text = "customer: none";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newToolStripMenuItem.Text = "new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeToolStripMenuItem.Text = "change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.logoutToolStripMenuItem.Text = "logout customer";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.closeProgrammToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // closeProgrammToolStripMenuItem
            // 
            this.closeProgrammToolStripMenuItem.Name = "closeProgrammToolStripMenuItem";
            this.closeProgrammToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeProgrammToolStripMenuItem.Text = "Close Programm";
            this.closeProgrammToolStripMenuItem.Click += new System.EventHandler(this.closeProgrammToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_balance.Location = new System.Drawing.Point(12, 46);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(49, 13);
            this.lbl_balance.TabIndex = 2;
            this.lbl_balance.Text = "Balance:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(921, 454);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_deposit
            // 
            this.lbl_deposit.AutoSize = true;
            this.lbl_deposit.Location = new System.Drawing.Point(12, 46);
            this.lbl_deposit.Name = "lbl_deposit";
            this.lbl_deposit.Size = new System.Drawing.Size(46, 13);
            this.lbl_deposit.TabIndex = 4;
            this.lbl_deposit.Text = "Deposit:";
            this.lbl_deposit.Visible = false;
            // 
            // lbl_withdraw
            // 
            this.lbl_withdraw.AutoSize = true;
            this.lbl_withdraw.Location = new System.Drawing.Point(12, 46);
            this.lbl_withdraw.Name = "lbl_withdraw";
            this.lbl_withdraw.Size = new System.Drawing.Size(55, 13);
            this.lbl_withdraw.TabIndex = 5;
            this.lbl_withdraw.Text = "Withdraw:";
            this.lbl_withdraw.Visible = false;
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(73, 43);
            this.txt_num1.MaxLength = 9;
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(72, 20);
            this.txt_num1.TabIndex = 6;
            this.txt_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_num1.Visible = false;
            this.txt_num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_dot
            // 
            this.lbl_dot.AutoSize = true;
            this.lbl_dot.Location = new System.Drawing.Point(145, 50);
            this.lbl_dot.Name = "lbl_dot";
            this.lbl_dot.Size = new System.Drawing.Size(10, 13);
            this.lbl_dot.TabIndex = 7;
            this.lbl_dot.Text = ".";
            this.lbl_dot.Visible = false;
            this.lbl_dot.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(158, 43);
            this.txt_num2.MaxLength = 2;
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(23, 20);
            this.txt_num2.TabIndex = 8;
            this.txt_num2.Visible = false;
            this.txt_num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_konto
            // 
            this.lbl_konto.AutoSize = true;
            this.lbl_konto.Location = new System.Drawing.Point(12, 46);
            this.lbl_konto.Name = "lbl_konto";
            this.lbl_konto.Size = new System.Drawing.Size(35, 13);
            this.lbl_konto.TabIndex = 10;
            this.lbl_konto.Text = "IBAN:";
            this.lbl_konto.Visible = false;
            // 
            // txt_konto
            // 
            this.txt_konto.Location = new System.Drawing.Point(73, 43);
            this.txt_konto.MaxLength = 11;
            this.txt_konto.Name = "txt_konto";
            this.txt_konto.Size = new System.Drawing.Size(82, 20);
            this.txt_konto.TabIndex = 11;
            this.txt_konto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_konto.Visible = false;
            this.txt_konto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_konto
            // 
            this.btn_konto.Location = new System.Drawing.Point(185, 41);
            this.btn_konto.Name = "btn_konto";
            this.btn_konto.Size = new System.Drawing.Size(75, 23);
            this.btn_konto.TabIndex = 12;
            this.btn_konto.Text = "Accept";
            this.btn_konto.UseVisualStyleBackColor = true;
            this.btn_konto.Visible = false;
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // lbl_Current
            // 
            this.lbl_Current.AutoSize = true;
            this.lbl_Current.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Current.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Current.Location = new System.Drawing.Point(841, 9);
            this.lbl_Current.Name = "lbl_Current";
            this.lbl_Current.Size = new System.Drawing.Size(68, 13);
            this.lbl_Current.TabIndex = 18;
            this.lbl_Current.Text = "Transactions";
            // 
            // grp_add
            // 
            this.grp_add.Controls.Add(this.lbl_dot1);
            this.grp_add.Controls.Add(this.txt_add_num2);
            this.grp_add.Controls.Add(this.btn_add);
            this.grp_add.Controls.Add(this.txt_add_mail);
            this.grp_add.Controls.Add(this.lbl_mail);
            this.grp_add.Controls.Add(this.txt_add_num1);
            this.grp_add.Controls.Add(this.txt_add_phone);
            this.grp_add.Controls.Add(this.txt_add_adress);
            this.grp_add.Controls.Add(this.date_birth);
            this.grp_add.Controls.Add(this.txt_add_surname);
            this.grp_add.Controls.Add(this.txt_add_name);
            this.grp_add.Controls.Add(this.lbl_income);
            this.grp_add.Controls.Add(this.lbl_phone);
            this.grp_add.Controls.Add(this.lbl_adress);
            this.grp_add.Controls.Add(this.lbl_date);
            this.grp_add.Controls.Add(this.lbl_surname);
            this.grp_add.Controls.Add(this.lbl_name);
            this.grp_add.Location = new System.Drawing.Point(12, 41);
            this.grp_add.Name = "grp_add";
            this.grp_add.Size = new System.Drawing.Size(894, 107);
            this.grp_add.TabIndex = 19;
            this.grp_add.TabStop = false;
            this.grp_add.Text = "Add Customer";
            this.grp_add.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(17, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(17, 54);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(52, 13);
            this.lbl_surname.TabIndex = 21;
            this.lbl_surname.Text = "Surname:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(17, 79);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 13);
            this.lbl_date.TabIndex = 22;
            this.lbl_date.Text = "Birthday:";
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Location = new System.Drawing.Point(220, 30);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(42, 13);
            this.lbl_adress.TabIndex = 23;
            this.lbl_adress.Text = "Adress:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(221, 58);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 24;
            this.lbl_phone.Text = "Phone:";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Location = new System.Drawing.Point(406, 58);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(45, 13);
            this.lbl_income.TabIndex = 25;
            this.lbl_income.Text = "Income:";
            // 
            // txt_add_name
            // 
            this.txt_add_name.Location = new System.Drawing.Point(74, 27);
            this.txt_add_name.MaxLength = 15;
            this.txt_add_name.Name = "txt_add_name";
            this.txt_add_name.Size = new System.Drawing.Size(123, 20);
            this.txt_add_name.TabIndex = 20;
            // 
            // txt_add_surname
            // 
            this.txt_add_surname.Location = new System.Drawing.Point(74, 51);
            this.txt_add_surname.MaxLength = 15;
            this.txt_add_surname.Name = "txt_add_surname";
            this.txt_add_surname.Size = new System.Drawing.Size(123, 20);
            this.txt_add_surname.TabIndex = 26;
            // 
            // date_birth
            // 
            this.date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_birth.Location = new System.Drawing.Point(74, 75);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(123, 20);
            this.date_birth.TabIndex = 27;
            // 
            // txt_add_adress
            // 
            this.txt_add_adress.Location = new System.Drawing.Point(277, 27);
            this.txt_add_adress.MaxLength = 40;
            this.txt_add_adress.Name = "txt_add_adress";
            this.txt_add_adress.Size = new System.Drawing.Size(333, 20);
            this.txt_add_adress.TabIndex = 28;
            // 
            // txt_add_phone
            // 
            this.txt_add_phone.Location = new System.Drawing.Point(278, 55);
            this.txt_add_phone.MaxLength = 15;
            this.txt_add_phone.Name = "txt_add_phone";
            this.txt_add_phone.Size = new System.Drawing.Size(122, 20);
            this.txt_add_phone.TabIndex = 29;
            this.txt_add_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_add_num1
            // 
            this.txt_add_num1.Location = new System.Drawing.Point(457, 55);
            this.txt_add_num1.MaxLength = 15;
            this.txt_add_num1.Name = "txt_add_num1";
            this.txt_add_num1.Size = new System.Drawing.Size(114, 20);
            this.txt_add_num1.TabIndex = 30;
            this.txt_add_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_add_num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(221, 83);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_mail.TabIndex = 31;
            this.lbl_mail.Text = "Mail:";
            // 
            // txt_add_mail
            // 
            this.txt_add_mail.Location = new System.Drawing.Point(277, 81);
            this.txt_add_mail.MaxLength = 40;
            this.txt_add_mail.Name = "txt_add_mail";
            this.txt_add_mail.Size = new System.Drawing.Size(333, 20);
            this.txt_add_mail.TabIndex = 33;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(803, 79);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Accept";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_add_num2
            // 
            this.txt_add_num2.Location = new System.Drawing.Point(581, 54);
            this.txt_add_num2.MaxLength = 2;
            this.txt_add_num2.Name = "txt_add_num2";
            this.txt_add_num2.Size = new System.Drawing.Size(29, 20);
            this.txt_add_num2.TabIndex = 32;
            this.txt_add_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_add_num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_dot1
            // 
            this.lbl_dot1.AutoSize = true;
            this.lbl_dot1.Location = new System.Drawing.Point(571, 60);
            this.lbl_dot1.Name = "lbl_dot1";
            this.lbl_dot1.Size = new System.Drawing.Size(10, 13);
            this.lbl_dot1.TabIndex = 34;
            this.lbl_dot1.Text = ".";
            // 
            // f_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 533);
            this.ControlBox = false;
            this.Controls.Add(this.grp_add);
            this.Controls.Add(this.lbl_Current);
            this.Controls.Add(this.btn_konto);
            this.Controls.Add(this.txt_konto);
            this.Controls.Add(this.lbl_konto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.lbl_dot);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_withdraw);
            this.Controls.Add(this.lbl_deposit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAZE Banksystem | User ";
            this.Load += new System.EventHandler(this.f_Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_add.ResumeLayout(false);
            this.grp_add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeProgrammToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_deposit;
        private System.Windows.Forms.Label lbl_withdraw;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label lbl_dot;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_konto;
        private System.Windows.Forms.TextBox txt_konto;
        private System.Windows.Forms.Button btn_konto;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Current;
        private System.Windows.Forms.GroupBox grp_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_add_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_add_num1;
        private System.Windows.Forms.TextBox txt_add_phone;
        private System.Windows.Forms.TextBox txt_add_adress;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.TextBox txt_add_surname;
        private System.Windows.Forms.TextBox txt_add_name;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_dot1;
        private System.Windows.Forms.TextBox txt_add_num2;
    }
}