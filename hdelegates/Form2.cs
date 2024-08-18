using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hdelegates.Form1;

namespace hdelegates
{
    public partial class Form2 : Form
    {
        private Student student;

        public Form2(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Text = "First Name: " + student.FirstName;
            label2.Text = student.LastName;
            label3.Text = student.MiddleName;
            label4.Text = student.Address;
            label5.Text = student.Program;
            label6.Text = student.Age.ToString();
            label7.Text = student.ContactNo.ToString();
            label8.Text = student.StudentNo.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Saved");
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
