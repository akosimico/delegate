namespace hdelegates
{
    public partial class Form1 : Form
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleName { get; set; }
            public string Address { get; set; }
            public string Program { get; set; }
            public long Age { get; set; }
            public long ContactNo { get; set; }
            public long StudentNo { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] courses = {
        "BS in Information Technology (BSIT)",
        "BS in Computer Science (BSCS)",
        "BS in Information Systems (BSIS)",
        "2-yr. Information Technology (IT)",
        "2-yr. Associate in Computer Technology (ACT)",
        "BS in Business Administration (BSBA)",
        "BS in Accountancy (BSA)",
        "BS in Accounting Information System (BSAIS)",
        "BS in Management Accounting (BSMA)",
        "BS in Retail Technology and Consumer Science (BSRTCS)",
        "2-yr. Associate in Retail Technology (ART)",
        "BS in Hospitality Management (BSHM)",
        "BS in Culinary Management (BSCM)",
        "3-yr. Hotel and Restaurant Administration (HRA)",
        "2-yr. Hospitality and Restaurant Services (HRS)",
        "BS in Tourism Management (BSTM)"
    };

            foreach (string course in courses)
            {
                guna2ComboBox1.Items.Add(course);
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Student student = new Student
                {
                    FirstName = guna2TextBox1.Text,
                    LastName = guna2TextBox2.Text,
                    MiddleName = guna2TextBox3.Text ?? "",
                    Address = guna2TextBox4.Text,
                    Program = guna2ComboBox1.Text,
                    Age = long.Parse(guna2TextBox7.Text),
                    ContactNo = long.Parse(guna2TextBox6.Text),
                    StudentNo = long.Parse(guna2TextBox5.Text)
                };

                Form2 form2 = new Form2(student);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly");
            }
        }
        private bool ValidateInput()
        {
            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox4.Text == "" || guna2ComboBox1.Text == "")
            {
                return false;
            }

            if (!long.TryParse(guna2TextBox7.Text, out long age) || age <= 0)
            {
                return false;
            }

            if (!long.TryParse(guna2TextBox6.Text, out long contactNo) || contactNo <= 0)
            {
                return false;
            }

            if (!long.TryParse(guna2TextBox5.Text, out long studentNo) || studentNo <= 0)
            {
                return false;
            }

            return true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        { 
                guna2TextBox1.Text = "";
                guna2TextBox2.Text = "";
                guna2TextBox3.Text = "";
                guna2TextBox4.Text = "";
                guna2TextBox5.Text = "";
                guna2TextBox6.Text = "";
                guna2TextBox7.Text = "";
            guna2ComboBox1.Text = "";
        }
    }
}
