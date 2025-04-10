namespace WFCRUD
{
    partial class frmDepartment
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
            lblName = new Label();
            lblLLocation = new Label();
            lblMgr = new Label();
            txtName = new TextBox();
            txtLocation = new TextBox();
            txtManagerId = new TextBox();
            btnInsert = new Button();
            lblDeptId = new Label();
            txtId = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblManager = new Label();
            comboManager = new ComboBox();
            comboDept = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(45, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(92, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Dept_Name ";
            // 
            // lblLLocation
            // 
            lblLLocation.AutoSize = true;
            lblLLocation.Location = new Point(46, 147);
            lblLLocation.Name = "lblLLocation";
            lblLLocation.Size = new Size(109, 20);
            lblLLocation.TabIndex = 1;
            lblLLocation.Text = "Dept_Location ";
            // 
            // lblMgr
            // 
            lblMgr.AutoSize = true;
            lblMgr.Location = new Point(46, 233);
            lblMgr.Name = "lblMgr";
            lblMgr.Size = new Size(111, 20);
            lblMgr.TabIndex = 2;
            lblMgr.Text = "Dept_Manager ";
            // 
            // txtName
            // 
            txtName.Location = new Point(238, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(238, 147);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 5;
            // 
            // txtManagerId
            // 
            txtManagerId.Location = new Point(238, 226);
            txtManagerId.Name = "txtManagerId";
            txtManagerId.Size = new Size(125, 27);
            txtManagerId.TabIndex = 6;
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
            btnInsert.Click += btnInsert_Click_1;
            // 
            // lblDeptId
            // 
            lblDeptId.AutoSize = true;
            lblDeptId.Location = new Point(58, 26);
            lblDeptId.Name = "lblDeptId";
            lblDeptId.Size = new Size(61, 20);
            lblDeptId.TabIndex = 10;
            lblDeptId.Text = "Dept_Id";
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
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
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
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Location = new Point(469, 38);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(68, 20);
            lblManager.TabIndex = 29;
            lblManager.Text = "Manager";
            // 
            // comboManager
            // 
            comboManager.FormattingEnabled = true;
            comboManager.Location = new Point(458, 77);
            comboManager.Name = "comboManager";
            comboManager.Size = new Size(151, 28);
            comboManager.TabIndex = 28;
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(458, 249);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(151, 28);
            comboDept.TabIndex = 30;
            comboDept.SelectedIndexChanged += comboDept_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 208);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 31;
            label1.Text = "Department";
            // 
            // frmDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(label1);
            Controls.Add(comboDept);
            Controls.Add(lblManager);
            Controls.Add(comboManager);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(lblDeptId);
            Controls.Add(btnInsert);
            Controls.Add(txtManagerId);
            Controls.Add(txtLocation);
            Controls.Add(txtName);
            Controls.Add(lblMgr);
            Controls.Add(lblLLocation);
            Controls.Add(lblName);
            Name = "frmDepartment";
            Text = "Department";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLLocation;
        private Label lblMgr;
        private TextBox txtName;
        private TextBox txtLocation;
        private TextBox txtManagerId;
        private Button btnInsert;
        private Label lblDeptId;
        private TextBox txtId;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblManager;
        private ComboBox comboManager;
        private ComboBox comboDept;
        private Label label1;
    }
}
