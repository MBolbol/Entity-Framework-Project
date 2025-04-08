
using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class frmCourseSessionAttendance : Form
    {
        private readonly int? _attendId;

        public frmCourseSessionAttendance(int? attendId = null)
        {
            InitializeComponent();
            _attendId = attendId;
            LoadCourseSessions();
            LoadStudents();
            LoadCourseSessionAttendances();
            if (attendId.HasValue)
                LoadCourseSessionAttendanceData(attendId.Value);
        }
        private void LoadCourseSessions()
        {
            using (var db = new EFProjectContext())
            {
                comboCrs.DataSource = db.CourseSessions.AsNoTracking()

                        .ToList();
                comboCrs.DisplayMember = "Title";
                comboCrs.ValueMember = "Crs_Id";
            }
        }
        private void LoadStudents()
        {
            using (var db = new EFProjectContext())
            {
                comboStud.DataSource = db.Students.AsNoTracking()
                    .Select(i => new { i.St_Id, FullName = i.St_Fname + " " + i.St_Lname })
                    .ToList();
                comboStud.DisplayMember = "FullName";
                comboStud.ValueMember = "St_Id";
            }
        }
        private void LoadCourseSessionAttendances()
        {
            using (var db = new EFProjectContext())
            {
                comboSessionNote.DataSource = db.CourseSessionAttendances.AsNoTracking()
                            .Select(a => new { a.CrsAttendance_Id, a.Notes })
                            .ToList();
                comboSessionNote.DisplayMember = "Notes";
                comboSessionNote.ValueMember = "CrsAttendance_Id";
            }
        }
        private void LoadCourseSessionAttendanceData(int id)
        {
            using (var db = new EFProjectContext())
            {
                var courseSessionAttendance = db.CourseSessionAttendances
                    .FirstOrDefault(c => c.CrsAttendance_Id == id);
                if (courseSessionAttendance != null)
                {
                    txtId.Text = courseSessionAttendance.CrsAttendance_Id.ToString();

                    txtGrade.Text = courseSessionAttendance.Grade.ToString();
                    txtNote.Text = courseSessionAttendance.Notes;
                    txtCrs_Id.Text = comboCrs.SelectedValue.ToString();
                    txtStud_Id.Text = comboStud.SelectedValue.ToString();
                    comboCrs.SelectedValue = courseSessionAttendance.CourseSessionID ?? 0;
                    comboStud.SelectedValue = courseSessionAttendance.StudentID;

                }
            }
        }

        private void comboSessionNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtCrs_Id.Enabled = false;
            txtStud_Id.Enabled = false;
            if (comboSessionNote.SelectedValue is int id)
            {
                LoadCourseSessionAttendanceData(id);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (var db = new EFProjectContext())
            {
                var newCourseSessionAttendances = new CourseSessionAttendance
                {
                    Notes = txtNote.Text,
                    Grade = int.Parse(txtGrade.Text),
                    CourseSessionID = (int?)comboCrs.SelectedValue,
                    StudentID = (int?)comboStud.SelectedValue
                };

                db.CourseSessionAttendances.Add(newCourseSessionAttendances);
                db.SaveChanges();
                MessageBox.Show("Course Session Attendance added successfully!");
             
                ClearFilds();
                Close();
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            using (var db = new EFProjectContext())
            {
                var courseSessionAttendances = db.CourseSessionAttendances.Find(id);
                if (courseSessionAttendances != null)
                {
                    courseSessionAttendances.Notes = txtNote.Text;
                    courseSessionAttendances.Grade = int.Parse(txtGrade.Text);
                    courseSessionAttendances.CourseSessionID = (int?)comboCrs.SelectedValue;
                    courseSessionAttendances.StudentID = (int?)comboStud.SelectedValue;
                    db.SaveChanges();
                    MessageBox.Show("Course Session Attendance updated successfully!");
                    ClearFilds();
                    Close();
                }
                else
                {
                    MessageBox.Show("Course Session Attendance Sessions not found!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            try
            {
                if (MessageBox.Show($"Are you sure you want to delete {txtNote.Text} Course Session Note?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var db = new EFProjectContext())
                    {
                        var attendances = db.CourseSessionAttendances.Find(id);
                        if (attendances != null)
                        {
                            db.CourseSessionAttendances.Remove(attendances);
                            db.SaveChanges();
                            MessageBox.Show("Course Session Attendance deleted successfully!");
                            LoadCourseSessionAttendances();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Course Session Attendance not found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearFilds()
        {
            txtId.Clear();
            txtNote.Clear();
            txtGrade.Clear();
            txtCrs_Id.Clear();
            txtStud_Id.Clear();
            comboCrs.SelectedIndex = -1;
            comboStud.SelectedIndex = -1;
        }
    }
}
