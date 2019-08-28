﻿using System;

namespace ListViewBasicSample.Entities
{
    [Serializable]
    public class Participant
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }
	
        public Participant() { }

		public Participant(string lastName, string firstName, DateTime birthDate)
		{
			LastName = lastName;
			FirstName = firstName;
			BirthDate = birthDate;
		}
	}
}
