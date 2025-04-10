namespace WFCRUD
{
    partial class frmInstructor
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
            lblFName = new Label();
            lblLName = new Label();
            lblPhone = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtPhone = new TextBox();
            btnInsert = new Button();
            lblId = new Label();
            txtId = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblInsFullName = new Label();
            comboIns = new ComboBox();
            comboDepartment = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(45, 80);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(80, 20);
            lblFName.TabIndex = 0;
            lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(46, 147);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(79, 20);
            lblLName.TabIndex = 1;
            lblLName.Text = "Last Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(46, 233);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(238, 73);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(125, 27);
            txtFname.TabIndex = 4;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(238, 147);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(125, 27);
            txtLname.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(238, 226);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Green;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(46, 363);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(58, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 10;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(238, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(253, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(485, 138);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblInsFullName
            // 
            lblInsFullName.AutoSize = true;
            lblInsFullName.Location = new Point(469, 38);
            lblInsFullName.Name = "lblInsFullName";
            lblInsFullName.Size = new Size(140, 20);
            lblInsFullName.TabIndex = 29;
            lblInsFullName.Text = "Instructor_FullName";
            // 
            // comboIns
            // 
            comboIns.FormattingEnabled = true;
            comboIns.Location = new Point(458, 77);
            comboIns.Name = "comboIns";
            comboIns.Size = new Size(151, 28);
            comboIns.TabIndex = 28;
            comboIns.SelectedIndexChanged += comboIns_SelectedIndexChanged;
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(439, 258);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(151, 28);
            comboDepartment.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 226);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 31;
            label1.Text = "Department";
            // 
            // frmInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(label1);
            Controls.Add(comboDepartment);
            Controls.Add(lblInsFullName);
            Controls.Add(comboIns);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnInsert);
            Controls.Add(txtPhone);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(lblPhone);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Name = "frmInstructor";
            Text = "Instructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFName;
        private Label lblLName;
        private Label lblPhone;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtPhone;
        private Button btnInsert;
        private Label lblId;
        private TextBox txtId;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblInsFullName;
        private ComboBox comboIns;
        private ComboBox comboDepartment;
        private Label label1;
    }
}
