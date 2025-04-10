namespace WFCRUD
{
    partial class frmStudent
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
            lblInsFullName = new Label();
            comboStud = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnInsert = new Button();
            txtPhone = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            lblPhone = new Label();
            lblLName = new Label();
            lblFName = new Label();
            SuspendLayout();
            // 
            // lblInsFullName
            // 
            lblInsFullName.AutoSize = true;
            lblInsFullName.Location = new Point(542, 58);
            lblInsFullName.Name = "lblInsFullName";
            lblInsFullName.Size = new Size(129, 20);
            lblInsFullName.TabIndex = 44;
            lblInsFullName.Text = "Student_FullName";
            // 
            // comboStud
            // 
            comboStud.FormattingEnabled = true;
            comboStud.Location = new Point(531, 97);
            comboStud.Name = "comboStud";
            comboStud.Size = new Size(151, 28);
            comboStud.TabIndex = 43;
            comboStud.SelectedIndexChanged += comboStud_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(558, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(326, 383);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
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
            btnInsert.BackColor = Color.Green;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(119, 383);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 38;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(311, 246);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 37;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(311, 167);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(125, 27);
            txtLname.TabIndex = 36;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(311, 93);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(125, 27);
            txtFname.TabIndex = 35;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(119, 253);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 34;
            lblPhone.Text = "Phone";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(119, 167);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(79, 20);
            lblLName.TabIndex = 33;
            lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(118, 100);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(80, 20);
            lblFName.TabIndex = 32;
            lblFName.Text = "First Name";
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInsFullName);
            Controls.Add(comboStud);
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
            Name = "frmStudent";
            Text = "Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsFullName;
        private ComboBox comboStud;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtId;
        private Label lblId;
        private Button btnInsert;
        private TextBox txtPhone;
        private TextBox txtLname;
        private TextBox txtFname;
        private Label lblPhone;
        private Label lblLName;
        private Label lblFName;
    }
}