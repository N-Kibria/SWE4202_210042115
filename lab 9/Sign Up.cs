using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace lab_9
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = @"G:\IUT\Semester\1-2\SWE 4202\lab 9\documents"+textBox4.Text+".txt";
                StreamWriter sw= new StreamWriter(filepath);
                using(sw)
                {
                    sw.WriteLine("Name : " + textBox4.Text);
                    sw.WriteLine("Username : " + textBox3.Text);
                    sw.WriteLine("Password : " + textBox2.Text);
                    sw.WriteLine("Re-Type Password : " + textBox1.Text);
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox2.Clear();
                    textBox1.Clear();


                }
            }
            catch(Exception)
            {
                MessageBox.Show("A user with the same user name already exists", "passwords do not match");// "username and password must be at least six characters"); ;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
