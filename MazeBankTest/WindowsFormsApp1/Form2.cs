using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class f_Employee : Form
    {
        //bool withordep   false -> withdraw  true -> deposit
        private bool withordep;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

        public f_Employee()
        {
            InitializeComponent();
        }

        private void closeProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void f_Employee_Load(object sender, EventArgs e)
        {
            database_connection();
        }

        private void database_connection()
        {

            server = "eduweb.kb.local";
            database = "team08";
            uid = "team08";
            password = "T3amO8";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from Transaction", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                this.CloseConnection();
            }
        }


        //Open Connection to Database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to Server. Contact Administration");
                        break;
                    case 45:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }

        }

        //Close Connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_num1.Text != "" && txt_num2.Text != "")
            {
                DateTime localDate = DateTime.Now;
                bool zer0 = false;
                string swithordep;
                double amount1, amount2, amount;
                if (txt_num1.Text == "")
                {
                    amount1 = 0;
                }
                else
                {
                    amount1 = Convert.ToDouble(txt_num1.Text);
                }
                if (txt_num2.Text == "" || txt_num2.Text == "0" || txt_num2.Text == "00")
                {
                    amount2 = 0;
                    zer0 = true;
                }
                else if (Convert.ToDouble(txt_num2.Text) < 10)
                {
                    amount2 = Convert.ToDouble(txt_num2.Text) * 10;
                    zer0 = false;
                }
                else
                {
                    amount2 = Convert.ToDouble(txt_num2.Text);
                    zer0 = false;
                }

                if (zer0 == true)
                {
                    amount = amount1;
                }
                else
                {
                    amount = amount1 + amount2 / 100;
                }

                lbl_balance.Text = ("Balance: " + Convert.ToString(amount));

                if (withordep == false)
                {
                    swithordep = "withdraw";
                }
                else
                {
                    swithordep = "deposit";
                }

                //Database
                if (amount > 0)
                {


                    server = "eduweb.kb.local";
                    database = "team08";
                    uid = "team08";
                    password = "T3amO8";
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                    connection = new MySqlConnection(connectionString);



                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO Transaction (costumerID, date, type, amount) VALUES (@CostumerID, @Date, @Type, @Amount)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@CostumerID", "0001");
                        cmd.Parameters.AddWithValue("@Date", localDate);
                        cmd.Parameters.AddWithValue("@Type", swithordep);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    database_connection();
                }
                    lbl_deposit.Visible = false;
                    lbl_withdraw.Visible = false;
                    lbl_dot.Visible = false;
                    txt_num1.Text = "";
                    txt_num2.Text = "";
                    txt_num1.Visible = false;
                    txt_num2.Visible = false;
                    button1.Visible = false;
                    dataGridView1.Visible = true;
                }
        }

        private void depositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            withordep = true;
            dataGridView1.Visible = false;
            lbl_deposit.Visible = true;
            lbl_dot.Visible = true;
            txt_num1.Visible = true;
            txt_num2.Visible = true;
            button1.Visible = true;
        }

        private void withdrawToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            withordep = false;
            dataGridView1.Visible = false;
            lbl_withdraw.Visible = true;
            lbl_dot.Visible = true;
            txt_num1.Visible = true;
            txt_num2.Visible = true;
            button1.Visible = true;
        }
    }
}

