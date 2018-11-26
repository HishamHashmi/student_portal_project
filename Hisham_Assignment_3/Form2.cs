using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hisham_Assignment_3
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hashmi\source\repos\Hisham_Assignment_3\Hisham_Assignment_3\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Semester_1' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(con);
            if (textBox1.Text == "1")
            {
                con.Open();
                var result = from s in db.Semester_1s
                             select new
                             {
                                 s.Id,
                                 s.Code,
                                 s.Title,
                                 s.Credit_Hours,
                                 s.Grade
                             };
                dataGridView1.DataSource = result;
                con.Close();
            }
            else if (textBox1.Text == "2")
            {
                con.Open();
                var result = from s in db.Semester_2s
                             select new
                             {
                                 s.Id,
                                 s.Code,
                                 s.Title,
                                 s.Credit_Hours,
                                 s.Grade
                             };
                dataGridView1.DataSource = result;
                con.Close();

            }
            else if (textBox1.Text == "3")
            {
                con.Open();
                var result = from s in db.Semester_3s
                             select new
                             {
                                 s.Id,
                                 s.Code,
                                 s.Title,
                                 s.Credit_Hours,
                                 s.Grade
                             };
                dataGridView1.DataSource = result;
                con.Close();
            }
            else if (textBox1.Text == "4")
            {
                con.Open();
                var result = from s in db.Semester_4s
                             select new
                             {
                                 s.Id,
                                 s.Code,
                                 s.Title,
                                 s.Credit_Hours,
                                 s.Grade
                             };
                dataGridView1.DataSource = result;
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Valid Semester Number.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

