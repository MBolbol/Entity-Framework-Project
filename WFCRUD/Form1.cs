using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshGrid<T>() where T : class
        {
            using (var db = new EFProjectContext())
            {
                db.ChangeTracker.Clear(); // Clears tracking to avoid duplicate instance issues
                db.Set<T>().Load();
                dataGridView1.DataSource = db.Set<T>().Local.ToBindingList();
            }
        }
        private void toolStripAddIns_Click(object sender, EventArgs e)
        {
            var frm = new frmInstructor();
            frm.ShowDialog();
            RefreshGrid<Instructor>();
        }

        private void toolStripUpdateIns_Click(object sender, EventArgs e)
        {
            var frm = new frmInstructor();
            frm.ShowDialog();
            RefreshGrid<Instructor>();
        }

        private void toolStripDeleteIns_Click(object sender, EventArgs e)
        {
            var frm = new frmInstructor();
            frm.ShowDialog();
            RefreshGrid<Instructor>();
        }

        private void toolStripShowIns_Click(object sender, EventArgs e)
        {
            RefreshGrid<Instructor>();

        }

        private void toolStripAddDept_Click(object sender, EventArgs e)
        {
            var frm = new frmDepartment();
            frm.ShowDialog();
            RefreshGrid<Department>();
        }

        private void toolStripUpdateDept_Click(object sender, EventArgs e)
        {
            var frm = new frmDepartment();
            frm.ShowDialog();
            RefreshGrid<Department>();
        }

        private void toolStripDeleteDept_Click(object sender, EventArgs e)
        {
            var frm = new frmDepartment();
            frm.ShowDialog();
            RefreshGrid<Department>();
        }

        private void toolStripShowDept_Click(object sender, EventArgs e)
        {
            RefreshGrid<Department>();
        }

        private void toolStripAddStud_Click(object sender, EventArgs e)
        {
            var frm = new frmStudent();
            frm.ShowDialog();
            RefreshGrid<Student>();
        }

        private void toolStripUpdateStud_Click(object sender, EventArgs e)
        {
            var frm = new frmStudent();
            frm.ShowDialog();
            RefreshGrid<Student>();
        }

        private void toolStripDeleteStud_Click(object sender, EventArgs e)
        {
            var frm = new frmStudent();
            frm.ShowDialog();
            RefreshGrid<Student>();
        }

        private void toolStripShowStud_Click(object sender, EventArgs e)
        {
            RefreshGrid<Student>();

        }

        private void toolStripAddCrs_Click(object sender, EventArgs e)
        {
            var frm = new frmCourse();
            frm.ShowDialog();
            RefreshGrid<Course>();
        }

        private void toolStripUpdateCrs_Click(object sender, EventArgs e)
        {
            var frm = new frmCourse();
            frm.ShowDialog();
            RefreshGrid<Course>();
        }

        private void toolStripDeleteCrs_Click(object sender, EventArgs e)
        {
            var frm = new frmCourse();
            frm.ShowDialog();
            RefreshGrid<Course>();
        }

        private void toolStripShowCrs_Click(object sender, EventArgs e)
        {
            RefreshGrid<Course>();

        }

        private void toolStripAddCrsSession_Click(object sender, EventArgs e)
        {
            var frm = new frmCourseSession();
            frm.ShowDialog();
            RefreshGrid<CourseSession>();
        }

        private void toolStripUpdateCrsSession_Click(object sender, EventArgs e)
        {
            var frm = new frmCourseSession();
            frm.ShowDialog();
            RefreshGrid<CourseSession>();
        }

        private void toolStripDeleteCrsSession_Click(object sender, EventArgs e)
        {
            var frm = new frmCourseSession();
            frm.ShowDialog();
            RefreshGrid<CourseSession>();
        }

        private void toolStripShowCrsSession_Click(object sender, EventArgs e)
        {
            RefreshGrid<CourseSession>();

        }

        private void toolStripAddCrsSessionAttend_Click(object sender, EventArgs e)
        {
            var frm = new frmCourseSessionAttendance();
            frm.ShowDialog();
            RefreshGrid<CourseSessionAttendance>();
        }

        private void ToolStripUpdateCrsSessionAttend_Click(object sender, EventArgs e)
        {
            var frm = new frmCourseSessionAttendance();
            frm.ShowDialog();
            RefreshGrid<CourseSessionAttendance>();
        }

        private void ToolStripDeleteCrsSessionAttend_Click(object sender, EventArgs e)
        {
            var frm = new frmCourseSessionAttendance();
            frm.ShowDialog();
            RefreshGrid<CourseSessionAttendance>();
        }

        private void ToolStripShowCrsSessionAttend_Click(object sender, EventArgs e)
        {
            RefreshGrid<CourseSessionAttendance>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
