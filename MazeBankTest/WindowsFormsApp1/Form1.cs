using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

        private void closeProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void aTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_Hide();
            Cred_Hide();
            ATM_Unhide();
            f_login.ActiveForm.Text = "MAZE Banksystem | ATM";
        }

        private void Cred_Hide()
        {
            lbl_Credits.Visible = false;
            lbl_CreditsCurrent.Visible = false;
        }

        private void ATM_Unhide()
        {
            loginatm_lbl_Bic.Visible = true;
            loginatm_txt_Bic.Visible = true;
            loginatm_lbl_Pin.Visible = true;
            loginatm_txt_Pin.Visible = true;
            loginatm_btn_Login.Visible = true;
            loginatm_lbl_Current.Visible = true;
        }

        private void Emp_Hide()
        {
            loginemp_lbl_User.Visible = false;
            loginemp_txt_User.Visible = false;
            loginemp_lbl_Pass.Visible = false;
            loginemp_txt_Pass.Visible = false;
            loginemp_btn_Login.Visible = false;
            loginemp_lbl_Current.Visible = false;
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATM_Hide();
            Cred_Hide();
            Emp_Unhide();
            f_login.ActiveForm.Text = "MAZE Banksystem | Employee";
        }

        private void Emp_Unhide()
        {
            loginemp_lbl_User.Visible = true;
            loginemp_txt_User.Visible = true;
            loginemp_lbl_Pass.Visible = true;
            loginemp_txt_Pass.Visible = true;
            loginemp_btn_Login.Visible = true;
            loginemp_lbl_Current.Visible = true;
        }

        private void ATM_Hide()
        {
            loginatm_lbl_Bic.Visible = false;
            loginatm_txt_Bic.Visible = false;
            loginatm_lbl_Pin.Visible = false;
            loginatm_txt_Pin.Visible = false;
            loginatm_btn_Login.Visible = false;
            loginatm_lbl_Current.Visible = false;
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATM_Hide();
            Emp_Hide();
            f_login.ActiveForm.Text = "MAZE Banksystem | Credits";
            Cred_Unhide();
        }

        private void Cred_Unhide()
        {
            lbl_Credits.Visible = true;
            lbl_CreditsCurrent.Visible = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Employee formEmployee = new f_Employee();
            this.Hide();
            formEmployee.Show();
        }

        private void f_login_Load(object sender, EventArgs e)
        {

        }
    }
}
