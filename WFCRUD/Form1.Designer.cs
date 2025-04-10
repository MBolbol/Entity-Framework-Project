namespace WFCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripInstructors = new ToolStripMenuItem();
            toolStripAddIns = new ToolStripMenuItem();
            toolStripUpdateIns = new ToolStripMenuItem();
            toolStripDeleteIns = new ToolStripMenuItem();
            toolStripShowIns = new ToolStripMenuItem();
            toolStripDepartment = new ToolStripMenuItem();
            toolStripAddDept = new ToolStripMenuItem();
            toolStripUpdateDept = new ToolStripMenuItem();
            toolStripDeleteDept = new ToolStripMenuItem();
            toolStripShowDept = new ToolStripMenuItem();
            toolStripStudent = new ToolStripMenuItem();
            toolStripAddStud = new ToolStripMenuItem();
            toolStripUpdateStud = new ToolStripMenuItem();
            toolStripDeleteStud = new ToolStripMenuItem();
            toolStripShowStud = new ToolStripMenuItem();
            toolStripCourse = new ToolStripMenuItem();
            toolStripAddCrs = new ToolStripMenuItem();
            toolStripUpdateCrs = new ToolStripMenuItem();
            toolStripDeleteCrs = new ToolStripMenuItem();
            toolStripShowCrs = new ToolStripMenuItem();
            toolStripCourseSession = new ToolStripMenuItem();
            toolStripAddCrsSession = new ToolStripMenuItem();
            toolStripUpdateCrsSession = new ToolStripMenuItem();
            toolStripDeleteCrsSession = new ToolStripMenuItem();
            toolStripShowCrsSession = new ToolStripMenuItem();
            ToolStripCourseSessionAttendance = new ToolStripMenuItem();
            toolStripAddCrsSessionAttend = new ToolStripMenuItem();
            ToolStripUpdateCrsSessionAttend = new ToolStripMenuItem();
            ToolStripDeleteCrsSessionAttend = new ToolStripMenuItem();
            ToolStripShowCrsSessionAttend = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripInstructors, toolStripDepartment, toolStripStudent, toolStripCourse, toolStripCourseSession, ToolStripCourseSessionAttendance });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(671, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripInstructors
            // 
            toolStripInstructors.DropDownItems.AddRange(new ToolStripItem[] { toolStripAddIns, toolStripUpdateIns, toolStripDeleteIns, toolStripShowIns });
            toolStripInstructors.Name = "toolStripInstructors";
            toolStripInstructors.Size = new Size(86, 24);
            toolStripInstructors.Text = "Instructos";
            // 
            // toolStripAddIns
            // 
            toolStripAddIns.Name = "toolStripAddIns";
            toolStripAddIns.Size = new Size(146, 26);
            toolStripAddIns.Text = "Add";
            toolStripAddIns.Click += toolStripAddIns_Click;
            // 
            // toolStripUpdateIns
            // 
            toolStripUpdateIns.Name = "toolStripUpdateIns";
            toolStripUpdateIns.Size = new Size(146, 26);
            toolStripUpdateIns.Text = "Update";
            toolStripUpdateIns.Click += toolStripUpdateIns_Click;
            // 
            // toolStripDeleteIns
            // 
            toolStripDeleteIns.Name = "toolStripDeleteIns";
            toolStripDeleteIns.Size = new Size(146, 26);
            toolStripDeleteIns.Text = "Delete";
            toolStripDeleteIns.Click += toolStripDeleteIns_Click;
            // 
            // toolStripShowIns
            // 
            toolStripShowIns.Name = "toolStripShowIns";
            toolStripShowIns.Size = new Size(146, 26);
            toolStripShowIns.Text = "ShowAll";
            toolStripShowIns.Click += toolStripShowIns_Click;
            // 
            // toolStripDepartment
            // 
            toolStripDepartment.DropDownItems.AddRange(new ToolStripItem[] { toolStripAddDept, toolStripUpdateDept, toolStripDeleteDept, toolStripShowDept });
            toolStripDepartment.Name = "toolStripDepartment";
            toolStripDepartment.Size = new Size(109, 24);
            toolStripDepartment.Text = "Departments";
            // 
            // toolStripAddDept
            // 
            toolStripAddDept.Name = "toolStripAddDept";
            toolStripAddDept.Size = new Size(146, 26);
            toolStripAddDept.Text = "Add";
            toolStripAddDept.Click += toolStripAddDept_Click;
            // 
            // toolStripUpdateDept
            // 
            toolStripUpdateDept.Name = "toolStripUpdateDept";
            toolStripUpdateDept.Size = new Size(146, 26);
            toolStripUpdateDept.Text = "Update";
            toolStripUpdateDept.Click += toolStripUpdateDept_Click;
            // 
            // toolStripDeleteDept
            // 
            toolStripDeleteDept.Name = "toolStripDeleteDept";
            toolStripDeleteDept.Size = new Size(146, 26);
            toolStripDeleteDept.Text = "Delete";
            toolStripDeleteDept.Click += toolStripDeleteDept_Click;
            // 
            // toolStripShowDept
            // 
            toolStripShowDept.Name = "toolStripShowDept";
            toolStripShowDept.Size = new Size(146, 26);
            toolStripShowDept.Text = "ShowAll";
            toolStripShowDept.Click += toolStripShowDept_Click;
            // 
            // toolStripStudent
            // 
            toolStripStudent.DropDownItems.AddRange(new ToolStripItem[] { toolStripAddStud, toolStripUpdateStud, toolStripDeleteStud, toolStripShowStud });
            toolStripStudent.Name = "toolStripStudent";
            toolStripStudent.Size = new Size(80, 24);
            toolStripStudent.Text = "Students";
            // 
            // toolStripAddStud
            // 
            toolStripAddStud.Name = "toolStripAddStud";
            toolStripAddStud.Size = new Size(146, 26);
            toolStripAddStud.Text = "Add";
            toolStripAddStud.Click += toolStripAddStud_Click;
            // 
            // toolStripUpdateStud
            // 
            toolStripUpdateStud.Name = "toolStripUpdateStud";
            toolStripUpdateStud.Size = new Size(146, 26);
            toolStripUpdateStud.Text = "Update";
            toolStripUpdateStud.Click += toolStripUpdateStud_Click;
            // 
            // toolStripDeleteStud
            // 
            toolStripDeleteStud.Name = "toolStripDeleteStud";
            toolStripDeleteStud.Size = new Size(146, 26);
            toolStripDeleteStud.Text = "Delete";
            toolStripDeleteStud.Click += toolStripDeleteStud_Click;
            // 
            // toolStripShowStud
            // 
            toolStripShowStud.Name = "toolStripShowStud";
            toolStripShowStud.Size = new Size(146, 26);
            toolStripShowStud.Text = "ShowAll";
            toolStripShowStud.Click += toolStripShowStud_Click;
            // 
            // toolStripCourse
            // 
            toolStripCourse.DropDownItems.AddRange(new ToolStripItem[] { toolStripAddCrs, toolStripUpdateCrs, toolStripDeleteCrs, toolStripShowCrs });
            toolStripCourse.Name = "toolStripCourse";
            toolStripCourse.Size = new Size(74, 24);
            toolStripCourse.Text = "Courses";
            // 
            // toolStripAddCrs
            // 
            toolStripAddCrs.Name = "toolStripAddCrs";
            toolStripAddCrs.Size = new Size(146, 26);
            toolStripAddCrs.Text = "Add";
            toolStripAddCrs.Click += toolStripAddCrs_Click;
            // 
            // toolStripUpdateCrs
            // 
            toolStripUpdateCrs.Name = "toolStripUpdateCrs";
            toolStripUpdateCrs.Size = new Size(146, 26);
            toolStripUpdateCrs.Text = "Update";
            toolStripUpdateCrs.Click += toolStripUpdateCrs_Click;
            // 
            // toolStripDeleteCrs
            // 
            toolStripDeleteCrs.Name = "toolStripDeleteCrs";
            toolStripDeleteCrs.Size = new Size(146, 26);
            toolStripDeleteCrs.Text = "Delete";
            toolStripDeleteCrs.Click += toolStripDeleteCrs_Click;
            // 
            // toolStripShowCrs
            // 
            toolStripShowCrs.Name = "toolStripShowCrs";
            toolStripShowCrs.Size = new Size(146, 26);
            toolStripShowCrs.Text = "ShowAll";
            toolStripShowCrs.Click += toolStripShowCrs_Click;
            // 
            // toolStripCourseSession
            // 
            toolStripCourseSession.DropDownItems.AddRange(new ToolStripItem[] { toolStripAddCrsSession, toolStripUpdateCrsSession, toolStripDeleteCrsSession, toolStripShowCrsSession });
            toolStripCourseSession.Name = "toolStripCourseSession";
            toolStripCourseSession.Size = new Size(117, 24);
            toolStripCourseSession.Text = "CourseSession";
            // 
            // toolStripAddCrsSession
            // 
            toolStripAddCrsSession.Name = "toolStripAddCrsSession";
            toolStripAddCrsSession.Size = new Size(146, 26);
            toolStripAddCrsSession.Text = "Add";
            toolStripAddCrsSession.Click += toolStripAddCrsSession_Click;
            // 
            // toolStripUpdateCrsSession
            // 
            toolStripUpdateCrsSession.Name = "toolStripUpdateCrsSession";
            toolStripUpdateCrsSession.Size = new Size(146, 26);
            toolStripUpdateCrsSession.Text = "Update";
            toolStripUpdateCrsSession.Click += toolStripUpdateCrsSession_Click;
            // 
            // toolStripDeleteCrsSession
            // 
            toolStripDeleteCrsSession.Name = "toolStripDeleteCrsSession";
            toolStripDeleteCrsSession.Size = new Size(146, 26);
            toolStripDeleteCrsSession.Text = "Delete";
            toolStripDeleteCrsSession.Click += toolStripDeleteCrsSession_Click;
            // 
            // toolStripShowCrsSession
            // 
            toolStripShowCrsSession.Name = "toolStripShowCrsSession";
            toolStripShowCrsSession.Size = new Size(146, 26);
            toolStripShowCrsSession.Text = "ShowAll";
            toolStripShowCrsSession.Click += toolStripShowCrsSession_Click;
            // 
            // ToolStripCourseSessionAttendance
            // 
            ToolStripCourseSessionAttendance.DropDownItems.AddRange(new ToolStripItem[] { toolStripAddCrsSessionAttend, ToolStripUpdateCrsSessionAttend, ToolStripDeleteCrsSessionAttend, ToolStripShowCrsSessionAttend });
            ToolStripCourseSessionAttendance.Name = "ToolStripCourseSessionAttendance";
            ToolStripCourseSessionAttendance.Size = new Size(193, 24);
            ToolStripCourseSessionAttendance.Text = "CourseSessionAttendance";
            // 
            // toolStripAddCrsSessionAttend
            // 
            toolStripAddCrsSessionAttend.Name = "toolStripAddCrsSessionAttend";
            toolStripAddCrsSessionAttend.Size = new Size(146, 26);
            toolStripAddCrsSessionAttend.Text = "Add";
            toolStripAddCrsSessionAttend.Click += toolStripAddCrsSessionAttend_Click;
            // 
            // ToolStripUpdateCrsSessionAttend
            // 
            ToolStripUpdateCrsSessionAttend.Name = "ToolStripUpdateCrsSessionAttend";
            ToolStripUpdateCrsSessionAttend.Size = new Size(146, 26);
            ToolStripUpdateCrsSessionAttend.Text = "Update";
            ToolStripUpdateCrsSessionAttend.Click += ToolStripUpdateCrsSessionAttend_Click;
            // 
            // ToolStripDeleteCrsSessionAttend
            // 
            ToolStripDeleteCrsSessionAttend.Name = "ToolStripDeleteCrsSessionAttend";
            ToolStripDeleteCrsSessionAttend.Size = new Size(146, 26);
            ToolStripDeleteCrsSessionAttend.Text = "Delete";
            ToolStripDeleteCrsSessionAttend.Click += ToolStripDeleteCrsSessionAttend_Click;
            // 
            // ToolStripShowCrsSessionAttend
            // 
            ToolStripShowCrsSessionAttend.Name = "ToolStripShowCrsSessionAttend";
            ToolStripShowCrsSessionAttend.Size = new Size(146, 26);
            ToolStripShowCrsSessionAttend.Text = "ShowAll";
            ToolStripShowCrsSessionAttend.Click += ToolStripShowCrsSessionAttend_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(671, 368);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.ForeColor = Color.White;
            button1.Location = new Point(281, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripCourseSessionAttendance;
        private ToolStripMenuItem toolStripAddCrsSessionAttend;
        private ToolStripMenuItem ToolStripUpdateCrsSessionAttend;
        private ToolStripMenuItem ToolStripDeleteCrsSessionAttend;
        private ToolStripMenuItem ToolStripShowCrsSessionAttend;
        private ToolStripMenuItem toolStripInstructors;
        private ToolStripMenuItem toolStripAddIns;
        private ToolStripMenuItem toolStripUpdateIns;
        private ToolStripMenuItem toolStripDeleteIns;
        private ToolStripMenuItem toolStripShowIns;
        private ToolStripMenuItem toolStripDepartment;
        private ToolStripMenuItem toolStripAddDept;
        private ToolStripMenuItem toolStripUpdateDept;
        private ToolStripMenuItem toolStripDeleteDept;
        private ToolStripMenuItem toolStripShowDept;
        private ToolStripMenuItem toolStripStudent;
        private ToolStripMenuItem toolStripAddStud;
        private ToolStripMenuItem toolStripUpdateStud;
        private ToolStripMenuItem toolStripDeleteStud;
        private ToolStripMenuItem toolStripShowStud;
        private ToolStripMenuItem toolStripCourse;
        private ToolStripMenuItem toolStripAddCrs;
        private ToolStripMenuItem toolStripUpdateCrs;
        private ToolStripMenuItem toolStripDeleteCrs;
        private ToolStripMenuItem toolStripShowCrs;
        private ToolStripMenuItem toolStripCourseSession;
        private ToolStripMenuItem toolStripAddCrsSession;
        private ToolStripMenuItem toolStripUpdateCrsSession;
        private ToolStripMenuItem toolStripDeleteCrsSession;
        private ToolStripMenuItem toolStripShowCrsSession;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
