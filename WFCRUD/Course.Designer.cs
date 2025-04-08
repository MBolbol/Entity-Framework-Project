namespace WFCRUD
{
    partial class frmCourse
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
            label1 = new Label();
            comboDepartment = new ComboBox();
            lblInsFullName = new Label();
            comboIns = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnInsert = new Button();
            txtDept_Id = new TextBox();
            txtDuration = new TextBox();
            txtName = new TextBox();
            lblPhone = new Label();
            lblLName = new Label();
            lblFName = new Label();
            txtIns_Id = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboCourse = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(558, 220);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 46;
            label1.Text = "Department";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(528, 252);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(151, 28);
            comboDepartment.TabIndex = 45;
            // 
            // lblInsFullName
            // 
            lblInsFullName.AutoSize = true;
            lblInsFullName.Location = new Point(544, 100);
            lblInsFullName.Name = "lblInsFullName";
            lblInsFullName.Size = new Size(140, 20);
            lblInsFullName.TabIndex = 44;
            lblInsFullName.Text = "Instructor_FullName";
            // 
            // comboIns
            // 
            comboIns.FormattingEnabled = true;
            comboIns.Location = new Point(533, 139);
            comboIns.Name = "comboIns";
            comboIns.Size = new Size(151, 28);
            comboIns.TabIndex = 43;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(558, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(326, 383);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(311, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 40;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(131, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 39;
            lblId.Text = "ID";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(119, 383);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 38;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // txtDept_Id
            // 
            txtDept_Id.Location = new Point(311, 246);
            txtDept_Id.Name = "txtDept_Id";
            txtDept_Id.Size = new Size(125, 27);
            txtDept_Id.TabIndex = 37;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(311, 167);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(125, 27);
            txtDuration.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Location = new Point(311, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 35;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(119, 253);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(61, 20);
            lblPhone.TabIndex = 34;
            lblPhone.Text = "Dept_Id";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(119, 167);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(67, 20);
            lblLName.TabIndex = 33;
            lblLName.Text = "Duration";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(118, 100);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(49, 20);
            lblFName.TabIndex = 32;
            lblFName.Text = "Name";
            // 
            // txtIns_Id
            // 
            txtIns_Id.Location = new Point(310, 304);
            txtIns_Id.Name = "txtIns_Id";
            txtIns_Id.Size = new Size(125, 27);
            txtIns_Id.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 311);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 47;
            label2.Text = "Ins_Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 9);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 50;
            label3.Text = "Course";
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(533, 41);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(151, 28);
            comboCourse.TabIndex = 49;
            comboCourse.SelectedIndexChanged += comboCourse_SelectedIndexChanged;
            // 
            // frmCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboCourse);
            Controls.Add(txtIns_Id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboDepartment);
            Controls.Add(lblInsFullName);
            Controls.Add(comboIns);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnInsert);
            Controls.Add(txtDept_Id);
            Controls.Add(txtDuration);
            Controls.Add(txtName);
            Controls.Add(lblPhone);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Name = "frmCourse";
            Text = "Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboDepartment;
        private Label lblInsFullName;
        private ComboBox comboIns;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtId;
        private Label lblId;
        private Button btnInsert;
        private TextBox txtDept_Id;
        private TextBox txtDuration;
        private TextBox txtName;
        private Label lblPhone;
        private Label lblLName;
        private Label lblFName;
        private TextBox txtIns_Id;
        private Label label2;
        private Label label3;
        private ComboBox comboCourse;
    }
}