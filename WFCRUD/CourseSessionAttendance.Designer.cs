namespace WFCRUD
{
    partial class frmCourseSessionAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStud_Id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboCrs = new ComboBox();
            lblInsFullName = new Label();
            comboStud = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnInsert = new Button();
            txtCrs_Id = new TextBox();
            txtNote = new TextBox();
            txtGrade = new TextBox();
            lblPhone = new Label();
            lblLName = new Label();
            lblFName = new Label();
            comboSessionNote = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtStud_Id
            // 
            txtStud_Id.Location = new Point(266, 294);
            txtStud_Id.Name = "txtStud_Id";
            txtStud_Id.Size = new Size(125, 27);
            txtStud_Id.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 301);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 85;
            label2.Text = "Student_Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 236);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 84;
            label1.Text = "Course Session";
            // 
            // comboCrs
            // 
            comboCrs.FormattingEnabled = true;
            comboCrs.Location = new Point(512, 267);
            comboCrs.Name = "comboCrs";
            comboCrs.Size = new Size(186, 28);
            comboCrs.TabIndex = 83;
            // 
            // lblInsFullName
            // 
            lblInsFullName.AutoSize = true;
            lblInsFullName.Location = new Point(529, 115);
            lblInsFullName.Name = "lblInsFullName";
            lblInsFullName.Size = new Size(129, 20);
            lblInsFullName.TabIndex = 82;
            lblInsFullName.Text = "Student_FullName";
            // 
            // comboStud
            // 
            comboStud.FormattingEnabled = true;
            comboStud.Location = new Point(517, 162);
            comboStud.Name = "comboStud";
            comboStud.Size = new Size(151, 28);
            comboStud.TabIndex = 81;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(547, 373);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 80;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(282, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(267, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 78;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(87, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 77;
            lblId.Text = "ID";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(75, 373);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 76;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtCrs_Id
            // 
            txtCrs_Id.Location = new Point(267, 236);
            txtCrs_Id.Name = "txtCrs_Id";
            txtCrs_Id.Size = new Size(125, 27);
            txtCrs_Id.TabIndex = 75;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(229, 157);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(196, 27);
            txtNote.TabIndex = 74;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(242, 83);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(172, 27);
            txtGrade.TabIndex = 73;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(72, 239);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 20);
            lblPhone.TabIndex = 72;
            lblPhone.Text = "CrsSession_Id";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(76, 157);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(68, 20);
            lblLName.TabIndex = 71;
            lblLName.Text = "Crs_Note";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(75, 90);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(49, 20);
            lblFName.TabIndex = 70;
            lblFName.Text = "Grade";
            // 
            // comboSessionNote
            // 
            comboSessionNote.FormattingEnabled = true;
            comboSessionNote.Location = new Point(490, 61);
            comboSessionNote.Name = "comboSessionNote";
            comboSessionNote.Size = new Size(208, 28);
            comboSessionNote.TabIndex = 87;
            comboSessionNote.SelectedIndexChanged += comboSessionNote_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 24);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 88;
            label3.Text = "Session_Note";
            // 
            // frmCourseSessionAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboSessionNote);
            Controls.Add(txtStud_Id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboCrs);
            Controls.Add(lblInsFullName);
            Controls.Add(comboStud);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnInsert);
            Controls.Add(txtCrs_Id);
            Controls.Add(txtNote);
            Controls.Add(txtGrade);
            Controls.Add(lblPhone);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Name = "frmCourseSessionAttendance";
            Text = "CourseSessionAttendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtStud_Id;
        private Label label2;
        private Label label1;
        private ComboBox comboCrs;
        private Label lblInsFullName;
        private ComboBox comboStud;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtId;
        private Label lblId;
        private Button btnInsert;
        private TextBox txtCrs_Id;
        private TextBox txtNote;
        private TextBox txtGrade;
        private Label lblPhone;
        private Label lblLName;
        private Label lblFName;
        private ComboBox comboSessionNote;
        private Label label3;
    }
}