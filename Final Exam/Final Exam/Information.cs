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
   public partial class Information : Form
   {
      public Information()
      {
         InitializeComponent();
      }

      private void Information_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'studentDataSet.Data_student' table. You can move, or remove it, as needed.
         //this.data_studentTableAdapter.Fill(this.studentDataSet.Data_student, "Level 2-2");
      }
      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
      //Insert data
      private void button8_Click(object sender, EventArgs e)
      {
         try
         {
            SqlConnection cont = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Second year term 2\C#\Final Exam + Project\Final Exam\Final Exam\Student.mdf;Integrated Security=True");
            cont.Open();
            SqlCommand cmd = new SqlCommand("insert into Data_student values ('" + textBox1.Text + "' , '" + textBox3.Text + "' , '" +                                 textBox2.Text + "' , '" +
               textBox4.Text + "' , '" + comboBox2.SelectedItem.ToString() + "' , '" + comboBox1.SelectedItem.ToString() + "')", cont);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Student added succesfully.");
            clear_data();
            show();
            cont.Close();
         }
         catch
         {
            MessageBox.Show("Sorry Data Repeated!!");
         }
      }
      //delete data
      private void button7_Click(object sender, EventArgs e)
      {
         try
         {
            SqlConnection cont = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Second year term 2\C#\Final Exam + Project\Final Exam\Final Exam\Student.mdf;Integrated Security=True");
            cont.Open();
            SqlCommand cmd = new SqlCommand(@"delete Data_student where (ID='" + textBox1.Text + "')", cont);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Student succesfully.");
            clear_data();
            show();
            cont.Close();
         }
         catch
         {
            MessageBox.Show("Sorry Data are Not Found!!");
         }
      }
      //update data
      private void button3_Click(object sender, EventArgs e)
      {
         try
         {
            SqlConnection cont = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Second year term 2\C#\Final Exam + Project\Final Exam\Final Exam\Student.mdf;Integrated Security=True");
            cont.Open();
            SqlCommand cmd = new SqlCommand("update Data_student set FN='" + textBox3.Text + "' ,MN= '" + textBox2.Text + "' ,LN= '" + textBox4.Text +
               "' ,Subject= '" + comboBox2.SelectedItem.ToString() + "' ,Level= '" + comboBox1.SelectedItem.ToString() + "' where (ID='" + textBox1.Text + "')", cont);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Student succesfully.");
            clear_data();
            show();
            cont.Close();
         }
         catch
         {
            MessageBox.Show("Sorry Error!!");
         }
      }
      //show data
      private void button1_Click(object sender, EventArgs e)
      {
         try
         {
            show();
         }
         catch
         {
            MessageBox.Show("Sorry Error!!");
         }
      }
      //close
      private void button2_Click(object sender, EventArgs e)
      {
         Close();
      }
      //report
      private void button6_Click(object sender, EventArgs e)
      {
         this.Hide();
         Report secondPage = new Report();
         secondPage.Show();
      }
      private void show()
      {
         SqlConnection cont = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Second year term 2\C#\Final Exam + Project\Final Exam\Final Exam\Student.mdf;Integrated Security=True");
         cont.Open();
         SqlCommand cmd = new SqlCommand("select * from Data_student", cont);
         cmd.CommandType = CommandType.Text;
         SqlDataAdapter sda = new SqlDataAdapter(cmd);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         dataGridView1.DataSource = dt;
      }
      private void clear_data()
      {
         textBox1.Clear();
         textBox2.Clear();
         textBox3.Clear();
         textBox4.Clear();
         comboBox1.Show();
         comboBox2.Show();
      }
      
   }
}
