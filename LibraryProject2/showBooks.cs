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
    public partial class showBooks : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        string selected;
        public showBooks()
        {
            InitializeComponent();
            populateDgvBooks();
            populateCmb();


        }
        private void populateCmb() {
         
            cmb1.DisplayMember = "name";
            cmb1.ValueMember = "id";
            cmb1.DataSource = from Author in db.Authors
                              select Author;
        }
        private void populateDgvBooks() {

            dgvBooks.DataSource = from Book in db.Books select new {  Book.id, name = Book.name, Book.numberOfPages,libraryName =  Book.Author.name };
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
         
        }
        private void populateDgvBooks(string Aid)
        {

            dgvBooks.DataSource = from Book in db.Books
                                  where Book.AId == Aid
                                  select new { Book.id, Book.name, Book.numberOfPages, Book.AId };
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.libraryDataSet.Author);
            // TODO: This line of code loads data into the 'libraryDataSet.Library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter.Fill(this.libraryDataSet.Library);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = from Book in db.Books
                                       where Book.name.Contains(txtSearch.Text)
                                  select new { Book.id, Book.name, Book.numberOfPages, Book.AId };
        }

      
        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDgvBooks((string)cmb2.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateDgvBooks();
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedCells.Count != 0)
            {
                selected = dgvBooks.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dgvBooks.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dgvBooks.SelectedRows[0].Cells[2].Value.ToString();
                cmb1.SelectedValue = dgvBooks.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book a = (from Book in db.Books where Book.id == Int32.Parse(selected) select Book).First();

            a.name = textBox2.Text;
            a.numberOfPages = Int32.Parse(textBox3.Text);

            db.SubmitChanges();
            populateDgvBooks();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var c = (from Contain in db.Contains
                     where Contain.BId == Int32.Parse(selected)
                     select Contain).Count();
            if (c == 0)
            {
                Book a = (from Book in db.Books
                          where Book.id == Int32.Parse(selected)
                          select Book
                             ).First();
                db.Books.DeleteOnSubmit(a);
                db.SubmitChanges();
            }
            else MessageBox.Show("cannot delete");
            populateDgvBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book a = new Book();
            a.id = Int32.Parse(textBox1.Text);
            a.name = textBox2.Text;
            a.numberOfPages = Int32.Parse(textBox3.Text);
            a.AId = cmb1.SelectedValue.ToString();
            db.Books.InsertOnSubmit(a);
            db.SubmitChanges();
            populateDgvBooks();
        }
    }
}
