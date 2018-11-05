using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafeteria_Ordering_System
{
    public partial class RegistrationForm : Form
    {
         public static string Contact = "";
        public static string BranchAddress = "";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact = textBox5.Text;
            BranchAddress = textBox6.Text;

            SqlConnection RegistrationSettings = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Khadija\Documents\RegistrationSettings.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("INSERT INTO RegistrationSetup (FirstName,LastName,Username,Password,Contact,BranchAddress) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", RegistrationSettings);
            RegistrationSettings.Open();
            int i = cmd.ExecuteNonQuery();
            RegistrationSettings.Close();
            if (i > 0)
            {
                MessageBox.Show("User is Registered");
                this.Close();
                Menu obj = new Menu();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Username is Taken");
            }
        }
    }
}
