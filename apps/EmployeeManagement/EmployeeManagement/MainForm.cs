using System.Data;

namespace EmployeeManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            int id = Convert.ToInt32(IdTextBox.Text.Trim());
            string name = nameTextBox.Text.Trim();
            string Department = departmentTextBox.Text.Trim();
            string Phone = phoneTextBox.Text.Trim();
            string query = $"insert into Employee (Id, Name, Department, Phone) values ({id}, '{name}', '{Department}', '{Phone}')";

            int result = db.ExecuteSQLCommand(query);
            if (result != -1)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            Database db = new Database();
            DataTable dt = db.GetEmployeeData("Select * from Employee");
            empDataGridView.DataSource = dt;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            DataGridViewSelectedRowCollection col = empDataGridView.SelectedRows;
            if (col.Count > 0)
            {
                DataGridViewRow selectedRow = col[0];
                if (selectedRow.Cells[0].Value != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes) {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        Database db = new Database();
                        string query = $"delete from Employee where id = {id}";
                        int result = db.ExecuteSQLCommand(query);
                        ShowData();
                    }                    
                }
            }
        }
    }
}
