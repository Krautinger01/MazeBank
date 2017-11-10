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
    public partial class Form1 : Form
    {
        public Form1()
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
            ATM_Unhide();
            Form1.ActiveForm.Text = "MAZE Banksystem | ATM";
        }

        private void ATM_Unhide()
        {
            loginatm_lbl_Bic.Visible = true;
            loginatm_txt_Bic.Visible = true;
            loginatm_lbl_Pin.Visible = true;
            loginatm_txt_Pin.Visible = true;
            loginatm_btn_Login.Visible = true;
            lbl_atm.Visible = true;
        }

        private void Emp_Hide()
        {
            loginemp_lbl_User.Visible = false;
            loginemp_txt_User.Visible = false;
            loginemp_lbl_Pass.Visible = false;
            loginemp_txt_Pass.Visible = false;
            loginemp_btn_Login.Visible = false;
            lbl_employee.Visible = false;
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATM_Hide();
            Emp_Unhide();
            Form1.ActiveForm.Text = "MAZE Banksystem | Employee";
        }

        private void Emp_Unhide()
        {
            loginemp_lbl_User.Visible = true;
            loginemp_txt_User.Visible = true;
            loginemp_lbl_Pass.Visible = true;
            loginemp_txt_Pass.Visible = true;
            loginemp_btn_Login.Visible = true;
            lbl_employee.Visible = true;
        }

        private void ATM_Hide()
        {
            loginatm_lbl_Bic.Visible = false;
            loginatm_txt_Bic.Visible = false;
            loginatm_lbl_Pin.Visible = false;
            loginatm_txt_Pin.Visible = false;
            loginatm_btn_Login.Visible = false;
            lbl_atm.Visible = false;
        }
    }
}
