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

namespace Final_Exam
{
   public partial class School : Form
   {
      public School()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void School_Load(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Second year term 2\C#\Final Exam + Project\Final Exam\Final Exam\school.mdf;Integrated Security=True");
         con.Open();
         SqlCommand cmd = new SqlCommand("select * from login_info where UserName ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "' ", con);
         SqlDataReader re = cmd.ExecuteReader();
         if (re.Read())
         {
            this.Hide();
           Information secondPage = new Information();
            secondPage.Show();
         }
         else
         {
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Please re insert Username and Password");
         }
         
      }

      private void textBox2_TextChanged(object sender, EventArgs e)
      {

      }
   }
}
