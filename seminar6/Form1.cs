using seminar6.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar6
{
    public partial class Form1 : Form
    {
        List<Participant> _participants { get; set; }

        public Form1()
        {
            InitializeComponent();
            _participants = new List<Participant>();
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if(tbLastName.Text.Trim() == string.Empty)
            {
                e.Cancel = true;
                epLastName.SetError(tbLastName, "The Last Name should not be empty!");
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            epLastName.Clear();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text.Trim() == string.Empty)
            {
                e.Cancel = true;
                epFirstName.SetError(tbFirstName, "The First Name should not be empty!");
            }
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            epFirstName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var isValid = true;
            if(tbLastName.Text.Trim() == string.Empty)
            {
                isValid = false;
                epLastName.SetError(tbLastName, "The Last Name should not be empty!");
            }
            if (tbFirstName.Text.Trim() == string.Empty)
            {
                isValid = false;
                epFirstName.SetError(tbFirstName, "The First Name should not be empty!");
            }
            if (!isValid)
            {
                MessageBox.Show("Please fix the errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var participant = new Participant(tbLastName.Text.Trim(), tbFirstName.Text.Trim(), dtpBirthDate.Value);
            _participants.Add(participant);
            DisplayParticipants();
        }

        void DisplayParticipants()
        {
            lvParticipants.Items.Clear();
            foreach(var participant in _participants)
            {
                var lviParticipant = new ListViewItem(participant.LastName);
                lviParticipant.SubItems.Add(participant.FirstName);
                lviParticipant.SubItems.Add(participant.BirthDate.ToShortDateString());

                lviParticipant.Tag = participant;

                lvParticipants.Items.Add(lviParticipant);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvParticipants.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a participant!");
                return;
            }

            if(MessageBox.Show("Are you sure?", "Delete Participant",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var selectedItem = lvParticipants.SelectedItems[0];
                Participant participant = (Participant)selectedItem.Tag;
                _participants.Remove(participant);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvParticipants.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a participant!");
                return;
            }

            var selectedItem = lvParticipants.SelectedItems[0];
            Participant participant = (Participant)selectedItem.Tag;

            EditForm editForm = new EditForm(participant);
            if (editForm.ShowDialog() == DialogResult.OK)
                DisplayParticipants();
        }
    }
}
