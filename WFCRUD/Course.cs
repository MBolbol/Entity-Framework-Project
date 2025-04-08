using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class frmCourse : Form
    {
        private readonly int? _crsId;

        public frmCourse(int? crsId = null)
        {
            InitializeComponent();
            _crsId = crsId;
            LoadDepartments();
            LoadInstructors();
            LoadCourses();
            if (_crsId.HasValue)
                LoadCourseData(_crsId.Value);
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
        private void LoadCourses()
        {
            using (var db = new EFProjectContext())
            {
            comboCourse.DataSource = db.Courses.AsNoTracking()
                    
                    .ToList();
                comboCourse.DisplayMember = "Crs_Name";
                comboCourse.ValueMember = "Crs_Id";
            }
        }

        private void LoadCourseData(int id)
        {
            using (var db = new EFProjectContext())
            {
                var course = db.Courses.AsNoTracking().FirstOrDefault(c => c.Crs_Id == id);
                if (course != null)
                {
                    txtId.Text = course.Crs_Id.ToString();
                    txtName.Text = course.Crs_Name;
                    txtDuration.Text = course.Crs_Duration.ToString();
                    txtDept_Id.Text = comboDepartment.SelectedValue.ToString();
                    txtIns_Id.Text = comboIns.SelectedValue.ToString();
                    comboDepartment.SelectedValue = course.Dept_Id ?? 0;
                    comboIns.SelectedValue = course.Ins_Id;
                }
            }
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtDept_Id.Enabled = false;
            txtIns_Id.Enabled = false;
            if (comboCourse.SelectedValue is int id)
            {
                LoadCourseData(id);
            }
        }


        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            //if (!int.TryParse(txtId.Text, out int id))
            //{
            //    MessageBox.Show("Please enter a valid numeric ID.");
            //    return;
            //}

            using (var db = new EFProjectContext())
            {
                var newCourse = new Course
                {
                    Crs_Name = txtName.Text,
                    Crs_Duration = int.Parse(txtDuration.Text),
                    Dept_Id = (int?)comboDepartment.SelectedValue,
                    Ins_Id = (int)comboIns.SelectedValue
                };

                db.Courses.Add(newCourse);
                db.SaveChanges();
                MessageBox.Show("Course added successfully!");
                txtId.Clear();
                txtName.Clear();
                txtDuration.Clear();
                txtDept_Id.Clear();
                txtIns_Id.Clear();
                comboDepartment.SelectedIndex = -1;
                comboIns.SelectedIndex = -1;
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            using (var db = new EFProjectContext())
            {
                var course = db.Courses.Find(id);
                if (course != null)
                {
                    course.Crs_Name = txtName.Text;
                    course.Crs_Duration = int.TryParse(txtDuration.Text, out int duration) ? duration : (int?)null;
                    course.Dept_Id = (int?)comboDepartment.SelectedValue;
                    course.Ins_Id = (int)comboIns.SelectedValue;
                    db.SaveChanges();
                    MessageBox.Show("Course updated successfully!");
                    txtId.Clear();
                    txtName.Clear();
                    txtDuration.Clear();
                    comboDepartment.SelectedIndex = -1;

                    Close();
                }
                else
                {
                    MessageBox.Show("Course not found!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            try
            {
                if (MessageBox.Show($"Are you sure you want to delete {txtName.Text} Course?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var db = new EFProjectContext())
                    {
                        var instructors = db.Instructors.Where(c => c.Ins_Id == id).ToList();
                        if (instructors.Any()) 
                        {
                            foreach (var ins in instructors)
                            {
                                ins.Ins_Id = 1; 
                            }
                            db.SaveChanges();
                        }

                        var course = db.Courses.Find(id);
                        if (course != null)
                        {
                            db.Courses.Remove(course);
                            db.SaveChanges();
                            MessageBox.Show("Course deleted successfully!");
                            LoadCourses(); 
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Course not found!");
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
