using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject2
{
    public partial class FormShowAllEmployee : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormShowAllEmployee(string LId)
        {
            InitializeComponent();
            populateDgvEmployees();

        }



        private void populateDgvEmployees() {
            dgvEmployees.DataSource = from Employee in db.Employees select new { Employee.userName, Employee.id,libraryName= Employee.Library.name };
        }


    }
}
