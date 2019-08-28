using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListViewBasicSample.Entities;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace ListViewBasicSample
{
	internal partial class MainForm : Form
	{
		#region Attributes
		private List<Participant> _participants;
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
				lvParticipants.Items.Add(listViewItem);
			}
		}
		#endregion

		#region Events
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text;
			string lastName = tbLastName.Text;
			DateTime birthDate = dtpBirthDate.Value;

			var participant = new Participant(lastName, firstName, birthDate);
			_participants.Add(participant);

			DisplayParticipants();
		}

        private void btnSerializeBinary_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _participants);
            };
        }

        private void btnDeserializeBinary_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _participants = (List<Participant>)formatter.Deserialize(stream);
                DisplayParticipants();
            };
        }

        private void btnSerializeXML_Click(object sender, EventArgs e)
        {
            var formatter = new XmlSerializer(typeof(List<Participant>));

            using (FileStream stream = File.Create("serialized.xml"))
            {
                formatter.Serialize(stream, _participants);
            }
        }

        private void btnDeserializeXML_Click(object sender, EventArgs e)
        {
            var formatter = new XmlSerializer(typeof(List<Participant>));

            using (FileStream stream = File.OpenRead("serialized.xml"))
            {
                _participants = (List<Participant>)formatter.Deserialize(stream);
                DisplayParticipants();
            };
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = "Export .csv";
            dialog.Filter = "CSV | *.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new StreamWriter(dialog.FileName))
                {
                    stream.WriteLine("LastName, FirstName, BirthDate");
                    foreach(var participant in _participants)
                    {
                        stream.WriteLine("{0}, {1}, {2}", participant.LastName, participant.FirstName, participant.BirthDate);
                    }
                }
            }
        }
        #endregion
    }
}
