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
    public partial class EditForm : Form
    {
        Participant _participant;
        public EditForm(Participant participant)
        {
            _participant = participant;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbLastName.Text = _participant.LastName;
            tbFirstName.Text = _participant.FirstName;
            dtpBirthDate.Value = _participant.BirthDate;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _participant.LastName = tbLastName.Text;
            _participant.FirstName = tbFirstName.Text;
            _participant.BirthDate = dtpBirthDate.Value;
        }
    }
}
