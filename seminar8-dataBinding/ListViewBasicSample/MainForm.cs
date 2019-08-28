using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ListViewBasicSample.Entities;
using ListViewBasicSample.ViewModels;

namespace ListViewBasicSample
{
	internal partial class MainForm : Form
	{
		#region Attributes

	    private MainFormViewModel _viewModel;
		#endregion

		public MainForm()
		{
			InitializeComponent();

		    _viewModel = new MainFormViewModel();
		}

		#region Methods
		#endregion

		#region Events
		private void btnAdd_Click(object sender, EventArgs e)
		{
			_viewModel.AddParticipant();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvParticipants.DataSource = _viewModel.Participants;
            tbLastName.DataBindings.Add("Text", _viewModel, "LastName");
            tbFirstName.DataBindings.Add("Text", _viewModel, "FirstName");
            dtpBirthDate.DataBindings.Add("Value", _viewModel, "BirthDate");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvParticipants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a participant!");
                return;
            }

            Participant participant = (Participant)dgvParticipants.SelectedRows[0].DataBoundItem;
            _viewModel.Participants.Remove(participant);
        }
        #endregion

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _viewModel.Participants);
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _viewModel.Participants = (BindingList<Participant>)formatter.Deserialize(stream);
            }
        }
    }
}
