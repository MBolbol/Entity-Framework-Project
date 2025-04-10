using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class frmCourseSession : Form
    {
        private readonly int? _sessionId;
        EFProjectContext db = new EFProjectContext();
        public frmCourseSession(int? sessionId = null)
        {
            InitializeComponent();
            _sessionId = sessionId;
            LoadInstructors();
            LoadCourses();
            LoadCourseSessions();
            if (sessionId.HasValue)
                LoadCourseSessionData(sessionId.Value);
        }

        private void LoadInstructors()
        {

            comboIns.DataSource = db.Instructors.AsNoTracking()
                .Select(i => new { i.Ins_Id, FullName = i.Ins_Fname + " " + i.Ins_Lname })
                .ToList();
            comboIns.DisplayMember = "FullName";
            comboIns.ValueMember = "Ins_Id";

        }

        private void LoadCourses()
        {

            comboCrs.DataSource = db.Courses.AsNoTracking()
                .Select(c => new { c.Crs_Id, c.Crs_Name })
                    .ToList();
            comboCrs.DisplayMember = "Crs_Name";
            comboCrs.ValueMember = "Crs_Id";

        }
        private void LoadCourseSessions()
        {

            comboSessionTitle.DataSource = db.CourseSessions.AsNoTracking()
            .Include(cs => cs.Crs)
            .Include(cs => cs.Ins)
            .Select(cs => new
            {
                cs.CourseSessionId,
                Title = $"{cs.Title} - {cs.Crs.Crs_Name} "
            })
            .ToList();
            comboSessionTitle.DisplayMember = "Title";
            comboSessionTitle.ValueMember = "CourseSessionId";

        }
        private void LoadCourseSessionData(int id)
        {

            var courseSession = db.CourseSessions.AsNoTracking()
                .Include(cs => cs.Crs)
                .Include(cs => cs.Ins)
                .FirstOrDefault(c => c.CourseSessionId == id);
            if (courseSession != null)
            {
                txtId.Text = courseSession.CourseSessionId.ToString();
                txtTitle.Text = courseSession.Title;
                txtDate.Text = courseSession.Crs_Date.ToString("yyyy-MM-dd");
                txtCrs_Id.Text = courseSession.Crs_Id?.ToString() ?? "N/A";
                txtIns_Id.Text = courseSession.Ins_Id?.ToString() ?? "N/A";
                comboCrs.SelectedValue = courseSession.Crs_Id ?? (object)DBNull.Value;
                comboIns.SelectedValue = courseSession.Ins_Id ?? (object)DBNull.Value;
            }

        }

        private void comboSessionTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtCrs_Id.Enabled = false;
            txtIns_Id.Enabled = false;
            if (comboSessionTitle.SelectedValue is int id)
            {
                LoadCourseSessionData(id);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            var newCourseSession = new CourseSession
            {
                Title = txtTitle.Text,
                Crs_Date = DateTime.Parse(txtDate.Text),
                Crs_Id = (int?)comboCrs.SelectedValue,
                Ins_Id = (int?)comboIns.SelectedValue
            };

            db.CourseSessions.Add(newCourseSession);
            db.SaveChanges();
            MessageBox.Show("Course Session added successfully!");
            ClearFields();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            var courseSession = db.CourseSessions.Find(id);
            if (courseSession != null)
            {
                courseSession.Title = txtTitle.Text;
                courseSession.Crs_Date = DateTime.Parse(txtDate.Text);
                courseSession.Crs_Id = (int?)comboCrs.SelectedValue;
                courseSession.Ins_Id = (int?)comboIns.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("Course Sessions updated successfully!");
                LoadCourseSessions();
                ClearFields();
                Close();
            }
            else
            {
                MessageBox.Show("Course Sessions not found!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            try
            {
                var courseSession = db.CourseSessions
                    .Include(cs => cs.CourseSessionAttendances)
                    .FirstOrDefault(cs => cs.CourseSessionId == id);

                if (courseSession == null)
                {
                    MessageBox.Show("Course Session not found!");
                    return;
                }

                var result = MessageBox.Show(
                    $"Delete {courseSession.Title} and all related attendances?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes) return;

                db.CourseSessionAttendances.RemoveRange(courseSession.CourseSessionAttendances);
                db.CourseSessions.Remove(courseSession);
                db.SaveChanges();

                MessageBox.Show("Course Session deleted successfully!");
                ClearFields();
                LoadCourseSessions();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearFields()
        {
            txtId.Clear();
            txtTitle.Clear();
            txtDate.Clear();
            txtCrs_Id.Clear();
            txtIns_Id.Clear();
            comboCrs.SelectedIndex = -1;
            comboIns.SelectedIndex = -1;
        }
    }
}
