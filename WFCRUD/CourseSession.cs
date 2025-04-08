using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class frmCourseSession : Form
    {
        private readonly int? _sessionId;

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
                comboCrs.DataSource = db.Courses.AsNoTracking()

                        .ToList();
                comboCrs.DisplayMember = "Crs_Name";
                comboCrs.ValueMember = "Crs_Id";
            }
        }
        private void LoadCourseSessions()
        {
            using (var db = new EFProjectContext())
            {
                comboSessionTitle.DataSource = db.CourseSessions.AsNoTracking()

                        .ToList();
                comboSessionTitle.DisplayMember = "Title";
                comboSessionTitle.ValueMember = "Crs_Id";
            }
        }
        private void LoadCourseSessionData(int id)
        {
            using (var db = new EFProjectContext())
            {
                var courseSession = db.CourseSessions.AsNoTracking().FirstOrDefault(c => c.Crs_Id == id);
                if (courseSession != null)
                {
                    txtId.Text = courseSession.Crs_Id.ToString();
                    txtTitle.Text = courseSession.Title;
                    txtDate.Text = courseSession.Crs_Date.ToString();
                    txtCrs_Id.Text = comboCrs.SelectedValue.ToString();
                    txtIns_Id.Text = comboIns.SelectedValue.ToString();
                    comboCrs.SelectedValue = courseSession.Crs_Id ?? 0;
                    comboIns.SelectedValue = courseSession.Ins_Id;
                }
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
            //if (!int.TryParse(txtId.Text, out int id))
            //{
            //    MessageBox.Show("Please enter a valid numeric ID.");
            //    return;
            //}

            using (var db = new EFProjectContext())
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
                txtId.Clear();
                txtTitle.Clear();
                txtDate.Clear();
                txtCrs_Id.Clear();
                txtIns_Id.Clear();
                comboCrs.SelectedIndex = -1;
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
                var courseSession = db.CourseSessions.Find(id);
                if (courseSession != null)
                {
                    courseSession.Title = txtTitle.Text;
                    courseSession.Crs_Date = DateTime.Parse(txtDate.Text);
                    courseSession.Crs_Id = (int?)comboCrs.SelectedValue;
                    courseSession.Ins_Id = (int?)comboIns.SelectedValue;
                    db.SaveChanges();
                    MessageBox.Show("Course Sessions updated successfully!");
                    txtId.Clear();
                    txtTitle.Clear();
                    txtDate.Clear();
                    comboCrs.SelectedIndex = -1;
                    comboIns.SelectedIndex = -1;

                    Close();
                }
                else
                {
                    MessageBox.Show("Course Sessions not found!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

            try
            {
                if (MessageBox.Show($"Are you sure you want to delete {txtTitle.Text} Course Session?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var db = new EFProjectContext())
                    {
                        var attendances = db.CourseSessionAttendances.Where(a => a.CourseSessionID == id).ToList();
                        if (attendances.Any())
                        {
                            db.CourseSessionAttendances.RemoveRange(attendances);
                            db.SaveChanges();
                        }

                        var courseSession = db.CourseSessions.Find(id);
                        if (courseSession != null)
                        {
                            db.CourseSessions.Remove(courseSession);
                            db.SaveChanges();
                            MessageBox.Show("Course Sessions deleted successfully!");
                            LoadCourseSessions(); 
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
