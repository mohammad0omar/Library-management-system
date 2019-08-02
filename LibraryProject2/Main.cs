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
    public partial class Main : Form
    {
        SqlConnection conn;
        string name;
        string LId,Eid;
        public Main(string name,string LId,string Eid)
        {
            InitializeComponent();
            this.Eid = Eid;
            this.name = name;
            this.LId = LId;
            conn = new SqlConnection(@"Data Source=LAPTOP-9FSM0GCO\DATASERVER;Initial Catalog=Library;Integrated Security=True");
            nameLable.Text = "employee name: "+name+"     |    ";
            library.Text = "library:  " + getLibraryName( LId);
        }
        private string getLibraryName(string LId) {

            try
            {
                conn.Open();
            string q = "Select name from Library where id='" + LId + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return reader[0].ToString();
                return "error";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }
            finally
            {
                conn.Close();
               
            }
        }
        private void ShowNewForm(object sender, EventArgs e)
        {

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnSellBook_Click(object sender, EventArgs e)
        {
            FormSellBook f = new FormSellBook(Eid,LId);
            f.Show();
        }

        private void btnShowAllAuthors_Click(object sender, EventArgs e)
        {
            Show_all_author f2 = new Show_all_author();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn i = new LogIn();
            this.Hide();
            i.ShowDialog();

            this.Close();
        }

        private void btnShowReceipts_Click(object sender, EventArgs e)
        {
            ShowAllReceipts r1 = new ShowAllReceipts();
            r1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormShowAllEmployee f1 = new FormShowAllEmployee(LId);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome ");
        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            showBooks s1 = new showBooks();
            s1.Show();
        }
    }
}
