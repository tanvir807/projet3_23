using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_FORM1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, dob, gender, email, address, courses, paymode;
            long mobile;
            name = textBox6.Text;
            dob = textBox7.Text;
            email = textBox9.Text;
            address = richTextBox1.Text;
            paymode = domainUpDown1.SelectedItem.ToString();
            if (radioButton1.Checked == true)
                gender = radioButton1.Text;
            else if (radioButton2.Checked == true)
                gender = radioButton2.Text;
            else
                gender = radioButton3.Text;
            if (checkBox1.Checked == true)
                courses = checkBox1.Text;
            else if (checkBox2.Checked == true)
                courses = checkBox2.Text;
            else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                courses = "C and C#";
            else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                courses = "C and Other Languages";
            else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                courses = "C# and Other Languages are selected";
            else
                courses = checkBox3.Text;
            mobile = long.Parse(textBox10.Text);
            MessageBox.Show("Name:" + name + "\nDOB:" + dob + "\nGender:" + gender + "\nEmail:" + email + "address:" + address + "\nCourses selected:" + courses + "\nMobile" + mobile + "\nPayment mode selected:" + paymode);


        }
    }
}
