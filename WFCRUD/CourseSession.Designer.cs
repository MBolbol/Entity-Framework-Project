namespace WFCRUD
{
    partial class frmCourseSession
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
            label3 = new Label();
            comboSessionTitle = new ComboBox();
            txtIns_Id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboCrs = new ComboBox();
            lblInsFullName = new Label();
            comboIns = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnInsert = new Button();
            txtCrs_Id = new TextBox();
            txtDate = new TextBox();
            txtTitle = new TextBox();
            lblPhone = new Label();
            lblLName = new Label();
            lblFName = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 6);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 69;
            label3.Text = "Session_Title";
            // 
            // comboSessionTitle
            // 
            comboSessionTitle.FormattingEnabled = true;
            comboSessionTitle.Location = new Point(495, 43);
            comboSessionTitle.Name = "comboSessionTitle";
            comboSessionTitle.Size = new Size(208, 28);
            comboSessionTitle.TabIndex = 68;
            comboSessionTitle.SelectedIndexChanged += comboSessionTitle_SelectedIndexChanged;
            // 
            // txtIns_Id
            // 
            txtIns_Id.Location = new Point(299, 301);
            txtIns_Id.Name = "txtIns_Id";
            txtIns_Id.Size = new Size(125, 27);
            txtIns_Id.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 308);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 66;
            label2.Text = "Ins_Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(587, 215);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 65;
            label1.Text = "Course";
            // 
            // comboCrs
            // 
            comboCrs.FormattingEnabled = true;
            comboCrs.Location = new Point(517, 249);
            comboCrs.Name = "comboCrs";
            comboCrs.Size = new Size(186, 28);
            comboCrs.TabIndex = 64;
            // 
            // lblInsFullName
            // 
            lblInsFullName.AutoSize = true;
            lblInsFullName.Location = new Point(533, 97);
            lblInsFullName.Name = "lblInsFullName";
            lblInsFullName.Size = new Size(140, 20);
            lblInsFullName.TabIndex = 63;
            lblInsFullName.Text = "Instructor_FullName";
            // 
            // comboIns
            // 
            comboIns.FormattingEnabled = true;
            comboIns.Location = new Point(522, 144);
            comboIns.Name = "comboIns";
            comboIns.Size = new Size(151, 28);
            comboIns.TabIndex = 62;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(547, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(315, 380);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 60;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(300, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 59;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(120, 43);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 58;
            lblId.Text = "ID";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(108, 380);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 57;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtCrs_Id
            // 
            txtCrs_Id.Location = new Point(300, 243);
            txtCrs_Id.Name = "txtCrs_Id";
            txtCrs_Id.Size = new Size(125, 27);
            txtCrs_Id.TabIndex = 56;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(262, 164);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(196, 27);
            txtDate.TabIndex = 55;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(275, 90);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(172, 27);
            txtTitle.TabIndex = 54;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(108, 250);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 20);
            lblPhone.TabIndex = 53;
            lblPhone.Text = "Crs_Id";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(108, 164);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(67, 20);
            lblLName.TabIndex = 52;
            lblLName.Text = "Crs_Date";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(107, 97);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(38, 20);
            lblFName.TabIndex = 51;
            lblFName.Text = "Title";
            // 
            // frmCourseSession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboSessionTitle);
            Controls.Add(txtIns_Id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboCrs);
            Controls.Add(lblInsFullName);
            Controls.Add(comboIns);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnInsert);
            Controls.Add(txtCrs_Id);
            Controls.Add(txtDate);
            Controls.Add(txtTitle);
            Controls.Add(lblPhone);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Name = "frmCourseSession";
            Text = "CourseSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboSessionTitle;
        private TextBox txtIns_Id;
        private Label label2;
        private Label label1;
        private ComboBox comboCrs;
        private Label lblInsFullName;
        private ComboBox comboIns;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtId;
        private Label lblId;
        private Button btnInsert;
        private TextBox txtCrs_Id;
        private TextBox txtDate;
        private TextBox txtTitle;
        private Label lblPhone;
        private Label lblLName;
        private Label lblFName;
    }
}