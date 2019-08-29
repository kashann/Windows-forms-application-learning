using DataBaseCommand.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCommand
{
    public partial class EditForm : Form
    {
        private Participant _participant;
        private const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";

        public EditForm(Participant participant)
        {
            InitializeComponent();
            _participant = participant; 
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbLastName.Text = _participant.LastName;
            tbFirstName.Text = _participant.FirstName;
            dtpBirthDate.Value = _participant.BirthDate;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _participant.LastName = tbLastName.Text;
                _participant.FirstName = tbFirstName.Text;
                _participant.BirthDate = dtpBirthDate.Value;
                UpdateParticipant(_participant);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateParticipant(Participant participant)
        {
            const string queryString = "UPDATE Participant SET LastName=@lastName, FirstName=@firstName, BirthDate=@birthDate WHERE Id=@id";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);

                var lastNameParam = new OleDbParameter("@lastName", tbLastName.Text);
                var firstNameParam = new OleDbParameter("@firstName", tbFirstName.Text);
                var birthDateParam = new OleDbParameter("@birthDate", dtpBirthDate.Value);
                var idParam = new OleDbParameter("@id", participant.Id);
                sqlCommand.Parameters.Add(lastNameParam);
                sqlCommand.Parameters.Add(firstNameParam);
                sqlCommand.Parameters.Add(birthDateParam);
                sqlCommand.Parameters.Add(idParam);
                sqlCommand.ExecuteNonQuery();

                var getIdCommand = new OleDbCommand("SELECT @@Identity;", connection);
                participant.Id = (int)getIdCommand.ExecuteScalar();
            }
        }
    }
}
