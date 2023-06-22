using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace crud_operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3KNG7NB;Initial Catalog=curd_db;Integrated Security=True");

        public int StudentId;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentrcd();
        }

        private void GetStudentrcd()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM  student_details ", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            StudentRecordDataGidView.DataSource = dt;

        }

        private void insert_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO student_details VALUES(@Name,@FatherName,@RollNumber,@Address,@Mobile)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtfname.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtno.Text);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New student successfully saved to the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentrcd();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (txtname.Text == string.Empty)
            {
                MessageBox.Show("Student name is required ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            txtname.Clear();
            txtfname.Clear();
            txtno.Clear();
            txtaddress.Clear();
            txtmobile.Clear();


            txtname.Focus();

        }

        private void StudentRecordDataGidView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            StudentId = Convert.ToInt32(StudentRecordDataGidView.SelectedRows[0].Cells[0].Value);
            txtname.Text = StudentRecordDataGidView.SelectedRows[0].Cells[1].Value.ToString();
            txtfname.Text = StudentRecordDataGidView.SelectedRows[0].Cells[2].Value.ToString();
            txtno.Text = StudentRecordDataGidView.SelectedRows[0].Cells[3].Value.ToString();
            txtaddress.Text = StudentRecordDataGidView.SelectedRows[0].Cells[4].Value.ToString();
            txtmobile.Text = StudentRecordDataGidView.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (StudentId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE student_details SET Name=@Name, FatherName=@FatherName, RollNumber=@RollNumber, Address=@Address, Mobile=@Mobile WHERE StudentId=@ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtfname.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtno.Text);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentrcd();
                ResetFormControls();
            }

            else
            {
                MessageBox.Show("Please select a student to update", "select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void db_Click(object sender, EventArgs e)
        {
            if (StudentId > 0)
            {



                SqlCommand cmd = new SqlCommand("DELETE FROM student_details WHERE StudentId=@ID", con);

                cmd.CommandType = CommandType.Text;


                cmd.Parameters.AddWithValue("@ID", StudentId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("student Deleted from the database", " Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentrcd();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a student to Delete", "select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}