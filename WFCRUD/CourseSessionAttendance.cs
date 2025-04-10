
using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class frmCourseSessionAttendance : Form
    {
        private readonly int? _attendId;
        EFProjectContext db = new EFProjectContext();
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
            
            comboCrs.DataSource = db.CourseSessions.AsNoTracking()

                    .ToList();
            comboCrs.DisplayMember = "Title";
            comboCrs.ValueMember = "CourseSessionId";
            
        }
        private void LoadStudents()
        {
            
            comboStud.DataSource = db.Students.AsNoTracking()
                .Select(i => new { i.St_Id, FullName = i.St_Fname + " " + i.St_Lname })
                .ToList();
            comboStud.DisplayMember = "FullName";
            comboStud.ValueMember = "St_Id";
            
        }
        private void LoadCourseSessionAttendances()
        {
           
            comboSessionNote.DataSource = db.CourseSessionAttendances.AsNoTracking()
                        .Select(a => new { a.CrsAttendance_Id, a.Notes })
                        .ToList();
            comboSessionNote.DisplayMember = "Notes";
            comboSessionNote.ValueMember = "CrsAttendance_Id";
            
        }
        private void LoadCourseSessionAttendanceData(int id)
        {
            
            var courseSessionAttendance = db.CourseSessionAttendances
                .FirstOrDefault(c => c.CrsAttendance_Id == id);
            if (courseSessionAttendance != null)
            {
                txtId.Text = courseSessionAttendance.CrsAttendance_Id.ToString();

                txtGrade.Text = courseSessionAttendance.Grade.ToString();
                txtNote.Text = courseSessionAttendance.Notes;
                txtCrs_Id.Text = courseSessionAttendance.CourseSessionID.ToString();
                txtStud_Id.Text = courseSessionAttendance.StudentID.ToString();
                comboCrs.SelectedValue = courseSessionAttendance.CourseSessionID ?? 0;
                comboStud.SelectedValue = courseSessionAttendance.StudentID;

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
             
            ClearFields();
            Close();
            
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

           
            var courseSessionAttendances = db.CourseSessionAttendances.Find(id);
            if (courseSessionAttendances != null)
            {
                courseSessionAttendances.Notes = txtNote.Text;
                courseSessionAttendances.Grade = int.Parse(txtGrade.Text);
                courseSessionAttendances.CourseSessionID = (int?)comboCrs.SelectedValue;
                courseSessionAttendances.StudentID = (int?)comboStud.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("Course Session Attendance updated successfully!");
                ClearFields();
                Close();
            }
            else
            {
                MessageBox.Show("Course Session Attendance Sessions not found!");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            try
            {
                var attendance = db.CourseSessionAttendances.Find(id);
                if (attendance == null)
                {
                    MessageBox.Show("Attendance not found!");
                    return;
                }

                var result = MessageBox.Show(
                    $"Delete attendance record for {attendance.Student?.St_Fname}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes) return;

                db.CourseSessionAttendances.Remove(attendance);
                db.SaveChanges();

                MessageBox.Show("Attendance deleted successfully!");
                ClearFields();
                LoadCourseSessionAttendances();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearFields()
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
