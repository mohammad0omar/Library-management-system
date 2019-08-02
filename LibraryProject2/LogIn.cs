using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace LibraryProject2
{
    public partial class LogIn : Form
    {
        SqlConnection conn;
        public LogIn()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-9FSM0GCO\DATASERVER;Initial Catalog=Library;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select userName,LId from Employee where id = '" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'",conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Main m = new Main(reader[0].ToString(),reader[1].ToString(), txtUserName.Text);
                    MessageBox.Show("Welcome "+reader[0]);

                    this.Hide();
                    m.ShowDialog();

                    this.Close();
                }
                else
                    MessageBox.Show("Wrong id or password!");


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }
    }
}
