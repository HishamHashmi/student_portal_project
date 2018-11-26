using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hisham_Assignment_3
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hashmi\source\repos\Hisham_Assignment_3\Hisham_Assignment_3\Database1.mdf;Integrated Security=True");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            con.Open();
            var result = from s in db.Login_tables
                         where s.Username == textBox1.Text & s.Password == textBox2.Text
                         select s;
               
            if (result.Count() != 0)
            {
                Form2 fm = new Form2();
                fm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            con.Close();    
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            con.Open();
            var result = from s in db.Login_tables
                         where s.Username == textBox3.Text & s.Password == textBox4.Text
                         select s;
            if (result.Count() == 0)
            {
                Login_table lt = new Login_table();
                
                lt.Username = textBox3.Text;
                lt.Password = textBox4.Text;

                db.Login_tables.InsertOnSubmit(lt);
                db.SubmitChanges();
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("that user already exists");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
