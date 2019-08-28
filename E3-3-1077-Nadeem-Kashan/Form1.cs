using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_3_1077_Nadeem_Kashan
{
    public partial class Form1 : Form
    {
        public List<Book> _books;
        public DateTime limitDate = new DateTime(1450, 1, 1);
        public Form1()
        {
            InitializeComponent();
            _books = new List<Book>();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            var name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                e.Cancel = true;
                errorProvider.SetError(tbName, "Mandatory field!");
            }
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void dtpPublication_Validating(object sender, CancelEventArgs e)
        {
            var date = dtpPublication.Value;
            if(date > DateTime.Now || date < limitDate)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpPublication, "Wrong date!");
            }
        }

        private void dtpPublication_Validated(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(tbName.Text.Trim(), dtpPublication.Value, decimal.Parse(tbPrice.Text.Trim()));
            _books.Add(book);
            DisplayBooks();
        }

        private void DisplayBooks()
        {
            listView.Items.Clear();
            SortList(_books);
            foreach(var book in _books)
            {
                var lvi = new ListViewItem(book.Name);
                lvi.SubItems.Add(book.Price.ToString());
                lvi.SubItems.Add(book.PublicationDate.ToString());
                listView.Items.Add(lvi);
            }
        }

        private void SortList(List<Book> books)
        {
            _books.Sort((x, y) => x.Price.CompareTo(y.Price));
        }

        private void btnImportBooks_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File (.txt)| *.txt|Excel File (comma separated .csv)| *.csv";
            ofd.Title = "Open file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string[] stringArray;
                    while (sr.Peek() >= 0)
                    {
                        stringArray = sr.ReadLine().Split(';');
                        var book = new Book(stringArray[0], DateTime.Parse(stringArray[1]), decimal.Parse(stringArray[2]));
                        _books.Add(book);
                    }
                }
                DisplayBooks();
            }
        }
    }
}
