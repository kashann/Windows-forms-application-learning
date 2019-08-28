using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ListViewBasicSample.Annotations;
using ListViewBasicSample.Entities;

namespace ListViewBasicSample.ViewModels
{
    class MainFormViewModel : INotifyPropertyChanged
    {
        #region Properties
        public BindingList<Participant> Participants { get; set; }

        private string _lastName;
        private string _firstName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }
        public DateTime BirthDate { get; set; }
        #endregion

        public MainFormViewModel()
        {
            Participants = new BindingList<Participant>();
            BirthDate = DateTime.Now;
        }

        public void AddParticipant()
        {
            var participant = new Participant(LastName, FirstName, BirthDate);
            Participants.Add(participant);

            LastName = FirstName = string.Empty;
            BirthDate = DateTime.Now;
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName)
        //{
        //    var handler = PropertyChanged;
        //    if(handler != null)
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //}
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
