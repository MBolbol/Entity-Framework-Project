
using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class frmInstructor : Form
    {
        private readonly int? _instructorId;

        public frmInstructor(int? instructorId = null)
        {
            InitializeComponent();
            _instructorId = instructorId;
            LoadDepartments();
            LoadInstructors(); // Load the instructors into the ComboBox
            if (_instructorId.HasValue)
                LoadInstructorData(_instructorId.Value);
        }

        private void LoadDepartments()
        {
            using (var db = new EFProjectContext())
            {
                comboDepartment.DataSource = db.Departments.ToList();
                comboDepartment.DisplayMember = "Dept_Name";
                comboDepartment.ValueMember = "Dept_Id";
            }
        }

        private void LoadInstructors()
        {
            using (var db = new EFProjectContext())
            {
                comboIns.DataSource = db.Instructors.AsNoTracking()
                    .Select(i => new { i.Ins_Id, FullName = i.Ins_Fname + " " + i.Ins_Lname })
                    .ToList();
                comboIns.DisplayMember = "FullName";
                comboIns.ValueMember = "Ins_Id";
            }
        }

        private void LoadInstructorData(int id)
        {
            using (var db = new EFProjectContext())
            {
                var instructor = db.Instructors.AsNoTracking().FirstOrDefault(i => i.Ins_Id == id);
                if (instructor != null)
                {
                    txtId.Text = instructor.Ins_Id.ToString();
                    txtFname.Text = instructor.Ins_Fname;
                    txtLname.Text = instructor.Ins_Lname;
                    txtPhone.Text = instructor.Ins_Phone;
                    comboDepartment.SelectedValue = instructor.Dept_Id ?? 0;
                }
            }
        }
        private void comboIns_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false; // Disable editing the ID

            if (comboIns.SelectedValue is int id)
            {
                LoadInstructorData(id);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //if (!int.TryParse(txtId.Text, out int id))
            //{
            //    MessageBox.Show("Please enter a valid numeric ID.");
            //    return;
            //}

            using (var db = new EFProjectContext())
            {
                var newInstructor = new Instructor
                {
                    Ins_Fname = txtFname.Text,
                    Ins_Lname = txtLname.Text,
                    Ins_Phone = txtPhone.Text,
                    Dept_Id = (int?)comboDepartment.SelectedValue
                };

                db.Instructors.Add(newInstructor);
                db.SaveChanges();
                MessageBox.Show("Instructor added successfully!");
                txtId.Clear();
                txtFname.Clear();
                txtLname.Clear();
                txtPhone.Clear();
                comboDepartment.SelectedIndex = -1;
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            using (var db = new EFProjectContext())
            {
                var instructor = db.Instructors.Find(id);
                if (instructor != null)
                {
                    instructor.Ins_Fname = txtFname.Text;
                    instructor.Ins_Lname = txtLname.Text;
                    instructor.Ins_Phone = txtPhone.Text;
                    instructor.Dept_Id = (int?)comboDepartment.SelectedValue;
                    db.SaveChanges();
                    MessageBox.Show("Instructor updated successfully!");
                    txtId.Clear();
                    txtFname.Clear();
                    txtLname.Clear();
                    txtPhone.Clear();
                    comboDepartment.SelectedIndex = -1;
                    Close();

                }
                else
                {
                    MessageBox.Show("Instructor not found!");
                }
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
                    using (var db = new EFProjectContext())
                    {
                        // Check if the instructor is referenced as Dept_Manager
                        var departments = db.Departments.Where(d => d.Dept_Manager == id).ToList();
                        if (departments.Any()) // If instructor is managing any department
                        {
                            foreach (var dept in departments)
                            {
                                dept.Dept_Manager = null; // 
                            }
                            db.SaveChanges();
                        }

                        // Find the instructor
                        var instructor = db.Instructors.Find(id);
                        if (instructor != null)
                        {
                            db.Instructors.Remove(instructor);
                            db.SaveChanges();
                            MessageBox.Show("Instructor deleted successfully!");
                            LoadInstructors(); // Refresh instructor list
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Instructor not found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
