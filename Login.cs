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

namespace Employee_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //private void Login_Load(object sender, EventArgs e)
        //{

        //}

       // private void button1_Click(object sender, EventArgs e)
        //{
         //   string user = guna2TextBox1.Text;
        //}

        private void Login_Load_1(object sender, EventArgs e)
        {

        }       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from emp.clientdetails where username='" + this.textBox1.Text + "' and password='"+this.textBox2.Text+"' ", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Successfully login");
                }
                else if (count > 1)
                {
                    MessageBox.Show("Access denied");
                }
                else
                {
                    MessageBox.Show("Data Set not Exist");

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
