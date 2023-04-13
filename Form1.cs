using Nika_Iakobashvili_Davaleba_9.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nika_Iakobashvili_Davaleba_9
{
    public partial class Form1 : Form
    {
        public static List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = textBox1.Text;
                if (fname.Length < 2)
                {
                    throw new InvalidName("First name must be at least 2 characters long");
                }
                string lname = textBox2.Text;
                if (lname.Length < 2)
                {
                    throw new InvalidName("Last name must be at least 2 characters long");
                }
                string id = textBox3.Text;
                if (id.Length != 11)
                {
                    throw new InvalidId("ID must be 11 characters long");
                }
                DateTime birthdate = dateTimePicker1.Value;
                if (birthdate > DateTime.Now)
                {
                    throw new InvalidBirthDate("Birth date must be in the past");
                }
                else if (birthdate < DateTime.Now.AddYears(-200))
                {
                    throw new InvalidBirthDate("Cannot be older than 200 years");
                }
                string mail = textBox4.Text;
                if (mail.Length < 5)
                {
                    throw new InvalidEmail("Email must be at least 5 characters long");
                }
                else if (!mail.Contains("@"))
                {
                    throw new InvalidEmail("Email must contain @");
                }
                else if (!mail.Contains("."))
                {
                    throw new InvalidEmail("Email must contain .");
                }
                string phone = textBox5.Text;
                if (phone.Length != 9)
                {
                    throw new InvalidPhone("Phone number must be 9 characters long");
                }
                string postal = textBox6.Text;
                if (postal.Length != 4)
                {
                    throw new InvalidPostalCode("Postal code must be 4 characters long");
                }
                string website = textBox7.Text;
                if (website.Length < 5)
                {
                    throw new InvalidWebAddress("Website must be at least 5 characters long");
                }
                else if (!website.Contains("."))
                {
                    throw new InvalidWebAddress("Website must contain .");
                }

                User usr = new User(fname, lname, id, birthdate, mail, phone, postal, website);
                users.Add(usr);
                labelInfo.Text = "User added";
                // clear all field 
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
