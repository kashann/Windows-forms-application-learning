using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataBaseCommand.Entities;
using System.Data.OleDb;
using DatabaseCommand;

namespace DataBaseCommand
{
    public partial class MainForm : Form
    {
		#region Attributes
        private const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";
	    private readonly List<Participant> _participants;
        #endregion

        public MainForm()
        {
            InitializeComponent();

			_participants = new List<Participant>();
        }

		#region Methods
		public void DisplayParticipants()
		{
			lvParticipants.Items.Clear();

			foreach (Participant participant in _participants)
			{
				var listViewItem = new ListViewItem(participant.LastName);
				listViewItem.SubItems.Add(participant.FirstName);
				listViewItem.SubItems.Add(participant.BirthDate.ToShortDateString());

				listViewItem.Tag = participant;

				lvParticipants.Items.Add(listViewItem);
			}
		}

		public void LoadParticipants()
		{
            const string queryString = "SELECT * FROM Participant";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                OleDbDataReader sqlReader = sqlCommand.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        var participant = new Participant(
                            (int)sqlReader["Id"],
                            (string)sqlReader["LastName"],
                            (string)sqlReader["FirstName"],
                            (DateTime)sqlReader["BirthDate"]);
                        _participants.Add(participant);
                    }
                }
                finally
                {
                    sqlReader.Close();
                }
            }
		}

		public void AddParticipant(Participant participant)
		{
            var queryString = "INSERT into Participant(LastName, FirstName, BirthDate) values (@lastName, @firstName, @birthDate);";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var insertCommand = new OleDbCommand(queryString, connection);

                var lastNameParameter = new OleDbParameter("@lastName", participant.LastName);
                var firstNameParameter = new OleDbParameter("@firstName", participant.FirstName);
                var birthDateParameter = new OleDbParameter("@birthDate", participant.BirthDate.Date);
                insertCommand.Parameters.Add(lastNameParameter);
                insertCommand.Parameters.Add(firstNameParameter);
                insertCommand.Parameters.Add(birthDateParameter);

                insertCommand.ExecuteNonQuery();

                var getIdCommand = new OleDbCommand("SELECT @@Identity;", connection);
                participant.Id = (int)getIdCommand.ExecuteScalar();

                _participants.Add(participant);
            }
		}

		public void DeleteParticipant(Participant participant)
	    {
            const string queryString = "DELETE FROM Participant WHERE Id=@id";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                var idParameter = new OleDbParameter("@id", participant.Id);
                sqlCommand.Parameters.Add(idParameter);

                sqlCommand.ExecuteNonQuery();

                _participants.Remove(participant);
            }
		}
		#endregion

		#region Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				LoadParticipants();
				DisplayParticipants();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var lastName = tbLastName.Text;
			var firstName = tbFirstName.Text;
			var birthDate = dtpBirthDate.Value;

			var participant = new Participant(lastName, firstName, birthDate);

			try
			{
				AddParticipant(participant);
				DisplayParticipants();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lvParticipants.SelectedItems.Count == 0)
			{
				MessageBox.Show("Choose a participant");
				return;
			}

			if (MessageBox.Show("Are you sure?", "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
				DialogResult.Yes)
			{
				try
				{
					DeleteParticipant((Participant) lvParticipants.SelectedItems[0].Tag);
					DisplayParticipants();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvParticipants.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvParticipants.SelectedItems[0];
                Participant participant = (Participant)selectedItem.Tag;

                EditForm editForm = new EditForm(participant);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayParticipants();
                }
            }
            else
                MessageBox.Show("Select only one participant!", "Error");
        }
        #endregion
    }
}