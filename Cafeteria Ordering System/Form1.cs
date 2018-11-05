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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection RegistrationSettings = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Khadija\Documents\RegistrationSettings.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter form1 = new SqlDataAdapter("Select Count(*) from RegistrationSetup where Username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", RegistrationSettings);
            DataTable dt = new DataTable();
            form1.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Menu obj = new Menu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username And Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm obj = new RegistrationForm();
            obj.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HowToUse obj = new HowToUse();
            obj.Show();
            this.Hide();
        }
    }
}
