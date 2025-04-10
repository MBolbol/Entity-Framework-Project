using Microsoft.EntityFrameworkCore;
using WFCRUD.Models;

namespace WFCRUD
{
    public partial class frmDepartment : Form
    {
        private readonly int? _departmentId;
        EFProjectContext db = new EFProjectContext();
        public frmDepartment(int? departmentId = null)
        {
            InitializeComponent();
            _departmentId = departmentId;
            LoadManagers();
            LoadDepartments();
            if (_departmentId.HasValue)
                LoadDepartmentData(_departmentId.Value);
        }

        private void LoadDepartments()
        {
            
            comboDept.DataSource = db.Departments.AsNoTracking().ToList();
            comboDept.DisplayMember = "Dept_Name";
            comboDept.ValueMember = "Dept_Id";
           
        }

        private void LoadDepartmentData(int id)
        {
            
            var department = db.Departments.AsNoTracking().FirstOrDefault(d => d.Dept_Id == id);
            if (department != null)
            {
                txtId.Text = department.Dept_Id.ToString();
                txtName.Text = department.Dept_Name;
                txtLocation.Text = department.Dept_Location;
                txtManagerId.Text = department.Dept_Manager?.ToString();
                comboManager.SelectedValue = department.Dept_Manager;
            }
            
        }
        private void comboDept_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtManagerId.Enabled = false;
            if (comboDept.SelectedValue is int id)
            {
                LoadDepartmentData(id);
            }
        }

        

        private void LoadManagers()
        {
            
            comboManager.DataSource = db.Instructors.AsNoTracking()
                .Select(i => new { i.Ins_Id, FullName = i.Ins_Fname + " " + i.Ins_Lname })
                .ToList(); 
            comboManager.DisplayMember = "FullName";
            comboManager.ValueMember = "Ins_Id";
            
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            
            var newDept = new Department
            {
                Dept_Name = txtName.Text,
                Dept_Location = txtLocation.Text,
                Dept_Manager = (int?)comboManager.SelectedValue
            };
            db.Departments.Add(newDept);
            db.SaveChanges();
            MessageBox.Show("Department added successfully!");
            ClarifyFields();
            Close();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;

           
            var department = db.Departments.Find(id);
            if (department != null)
            {
                department.Dept_Name = txtName.Text;
                department.Dept_Location = txtLocation.Text;
                //department.Dept_Manager = (int?)comboManager.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("Department updated successfully!");
                ClarifyFields();
                Close();
            }
            else
            {
                MessageBox.Show("Department not found!");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
                return;
            try
            {
                if (MessageBox.Show($"Are you sure you want to delete {txtName.Text}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   
                        // Check for instructors in this department
                    var instructors = db.Instructors.Where(i => i.Dept_Id == id).ToList();
                    if (instructors.Any())
                    {
                        // Move instructors to default department (or null if allowed)
                        foreach (var instructor in instructors)
                        {
                            instructor.Dept_Id = 1; // Assuming '1' is a default department
                        }
                        db.SaveChanges();
                    }

                    var department = db.Departments.Find(id);
                    if (department != null)
                    {
                        db.Departments.Remove(department);
                        db.SaveChanges();
                        MessageBox.Show("Department deleted successfully!");
                        LoadDepartments(); // Refresh the list
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Department not found!");
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }
        private void ClarifyFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtLocation.Clear();
            comboManager.SelectedIndex = -1;
        }
    }
    
}
