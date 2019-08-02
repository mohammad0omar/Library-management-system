using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject2
{
    public partial class FormSellBook : Form
    {
        SqlConnection conn;
        string Eid ,Lid;
       int count = 0;
        public FormSellBook(string Eid,string Lid)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-9FSM0GCO\DATASERVER;Initial Catalog=Library;Integrated Security=True");
           
            this.Eid = Eid;
            this.Lid = Lid;
            populateLsvAccDisonnected("all");
            count =countSelled()+1;

        }

        private int countSelled() {
            try
            {
                conn.Open();
                string q = "Select count(*) from Selled ";
                SqlCommand cmd = new SqlCommand(q, conn);
                int c = (int)cmd.ExecuteScalar();
                return c;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();

            }
        }
        private void FormSellBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.libraryDataSet.Author);

        }
        private void populateLsvAccDisonnected(string Aid)
        {
            lsvBook.Items.Clear();

            try
            {
                conn.Open();
                string q;
                if (Aid == "all")
                q= "Select Book.id , Book.name , Contain.quatity from Book ,Contain where Book.id = Contain.Bid and Contain.Lid = '"+Lid+"'";
                else q = "Select Book.* from Book where Aid = '"+Aid+"'";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    string[] row = new string[3];
                    row[0] = dr[0].ToString();
                    row[1] = dr[1].ToString();
                    row[2] = dr[2].ToString();
                    ListViewItem lvi = new ListViewItem(row);
                    lsvBook.Items.Add(lvi);
                }

            }




            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateLsvAccDisonnected((string)listBox1.SelectedValue);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string q;
                q = "select count(*) from Contain where Bid = '" + lsvBook.SelectedItems[0].Text + "' and quatity >0";
                SqlCommand cmd = new SqlCommand(q, conn);
                int c = (int)cmd.ExecuteScalar();
                if (lsvBook.SelectedItems.Count != 0 && c!=0)
                {
                   q= "Insert into Selled(Bid,quantity,id) " +
                    "values('" + lsvBook.SelectedItems[0].Text + "',"
                    + (int)(numericUpDown1.Value) + ","
                    + count + ")";
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                    q = "insert into Bill(Eid,Sid) values('" + Eid + "','" + count + "')";
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                    q = "Select quatity from Contain where Bid = '" + lsvBook.SelectedItems[0].Text + "' and Lid ='" + Lid + "'";
                    cmd.CommandText = q;
                    c = (int)cmd.ExecuteScalar();
                    q = "update Contain Set quatity = " + (c - (int)(numericUpDown1.Value)) + "where Bid = '" + lsvBook.SelectedItems[0].Text + "' and Lid ='" + Lid + "'";
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Bill added");
                this.Close();
            }
        }
    }
}
