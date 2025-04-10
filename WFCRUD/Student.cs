

using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;



namespace WFCRUD
{
    public partial class frmStudent : Form
    {
        private readonly int? _studId;
        EFProjectContext db = new EFProjectContext();
        public frmStudent(int? studId = null)
        {
            InitializeComponent();
            _studId = studId;
            LoadStudents(); // Load the instructors into the ComboBox
            if (_studId.HasValue)
                LoadStudentData(_studId.Value);
        }

        private void LoadStudents()
        {
            
                comboStud.DataSource = db.Students.AsNoTracking()
                    .Select(i => new { i.St_Id, FullName = i.St_Fname + " " + i.St_Lname })
                    .ToList();
                comboStud.DisplayMember = "FullName";
                comboStud.ValueMember = "St_Id";
            
        }

        private void LoadStudentData(int id)
        {
           
            var student = db.Students.AsNoTracking().FirstOrDefault(i => i.St_Id == id);
            if (student != null)
            {
                txtId.Text = student.St_Id.ToString();
                txtFname.Text = student.St_Fname;
                txtLname.Text = student.St_Lname;
                txtPhone.Text = student.St_Phone;
            }
            
        }
        private void comboStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;

            if (comboStud.SelectedValue is int id)
            {
                LoadStudentData(id);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            var newStudent = new Student
            {
                St_Fname = txtFname.Text,
                St_Lname = txtLname.Text,
                St_Phone = txtPhone.Text,
            };

            db.Students.Add(newStudent);
            db.SaveChanges();
            MessageBox.Show("Student added successfully!");
            clearFields();
            Close();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            
            var student = db.Students.Find(id);
            if (student != null)
            {
                student.St_Fname = txtFname.Text;
                student.St_Lname = txtLname.Text;
                student.St_Phone = txtPhone.Text;
                db.SaveChanges();
                MessageBox.Show("Student updated successfully!");
                clearFields();
                Close();
            }
            else
            {
                MessageBox.Show("Student not found!");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            try
            {
                if (MessageBox.Show($"Are you sure you want to delete {txtFname.Text} {txtLname.Text}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    // Find the student
                    var student = db.Students.Find(id);
                    if (student != null)
                    {
                        db.Students.Remove(student);
                        db.SaveChanges();
                        MessageBox.Show("Student deleted successfully!");
                        LoadStudents(); // Refresh student list
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void clearFields()
        {
            txtId.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtPhone.Clear();
        }
    }
}
