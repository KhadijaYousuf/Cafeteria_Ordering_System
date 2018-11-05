using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cafeteria_Ordering_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string msg = "";

                if (checkBox1.Checked == true)
                {
                    msg = "Food Item Selected";
                }

                if (checkBox2.Checked == true)
                {
                    msg = "Food Item Selected";
                }

                if (checkBox3.Checked == true)
                {
                    msg = "Food Item Selected";
                }

                if (msg.Length > 0)
                {
                }

                else
                {
                    MessageBox.Show("No Food Item Selected");
                }
                checkBox1.ThreeState = true;
            }
            rtxtreciept.Clear();
            rtxtreciept.AppendText(Environment.NewLine);
            rtxtreciept.AppendText("\t" + "CAFETERIA ORDERING SYSTEM" + Environment.NewLine);
            rtxtreciept.AppendText("----------------------------------------------------------------------------" + Environment.NewLine);
            rtxtreciept.AppendText("Item 1\t\t Item Id: FI01\t\tRs." + textBox2.Text + Environment.NewLine);
            rtxtreciept.AppendText("Item 2\t\t Item Id: FI02\t\tRs." + textBox6.Text + Environment.NewLine);
            rtxtreciept.AppendText("Item 3\t\t Item Id: FI03\t\tRs." + textBox7.Text + Environment.NewLine);
            rtxtreciept.AppendText("----------------------------------------------------------------------------" + Environment.NewLine);
            rtxtreciept.AppendText("Total Amount:\t\t\t\tRs." + textBox5.Text + Environment.NewLine);
            rtxtreciept.AppendText("----------------------------------------------------------------------------" + Environment.NewLine);
            rtxtreciept.AppendText(label7.Text + "\t\t" + Environment.NewLine);
            rtxtreciept.AppendText("----------------------------------------------------------------------------" + Environment.NewLine);
            rtxtreciept.AppendText("Cash on Delivery" + Environment.NewLine);
           
            rtxtreciept.AppendText("\t\t           Signature:__________________");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox2.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";

            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int val2, val3, val4, val5, val6, val7;

            int.TryParse(textBox1.Text, out val2);
            int.TryParse(textBox3.Text, out val3);
            int.TryParse(textBox4.Text, out val4);

            textBox2.Text = (val2 * 1200).ToString();
            textBox6.Text = (val3 * 1500).ToString();
            textBox7.Text = (val4 * 600).ToString();

            int.TryParse(textBox2.Text, out val5);
            int.TryParse(textBox6.Text, out val6);
            int.TryParse(textBox7.Text, out val7);

            textBox5.Text = (val5 + val6 + val7).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            int val2, val3, val4;

            int.TryParse(textBox1.Text, out val2);
            int.TryParse(textBox3.Text, out val3);
            int.TryParse(textBox4.Text, out val4);

            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = (val2 * 0).ToString();
            textBox6.Text = (val3 * 0).ToString();
            textBox7.Text = (val4 * 0).ToString();
            textBox5.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox3.Enabled = true;
                textBox6.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox4.Enabled = true;
                textBox7.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtreciept.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Cut();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Notepad Text";
            save.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter Sw = new System.IO.StreamWriter(save.FileName))
                    Sw.WriteLine(rtxtreciept.Text);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtxtreciept.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Paste();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
