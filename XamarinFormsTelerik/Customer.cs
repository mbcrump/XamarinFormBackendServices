using System;
using Telerik.Everlive.Sdk.Core.Model.Base;

namespace XamarinFormsTelerik
{
	public class Customer : DataItem
	{
		private string _firstName;
		private string _lastName;
		private string _address;
		private string _city;
		private string _state;
		private string _zip;

		public string FirstName
		{
			get { return _firstName; }
			set
			{
				if (value != _firstName)
				{
					_firstName = value;
					OnPropertyChanged("FirstName");
					OnPropertyChanged ("HasValidInput");
				}
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set
			{
				if (value != _lastName)
				{
					_lastName = value;
					OnPropertyChanged("LastName");
					OnPropertyChanged ("HasValidInput");
				}
			}
		}

		public string Address
		{
			get { return _address; }
			set
			{
				if (value != _address)
				{
					_address = value;
					OnPropertyChanged("Address");
				}
			}
		}

		public string City
		{
			get { return _city; }
			set
			{
				if (value != _city)
				{
					_city = value;
					OnPropertyChanged("City");
				}
			}
		}

		public string State
		{
			get { return _state; }
			set
			{
				if (value != _state)
				{
					_state = value;
					OnPropertyChanged("State");
				}
			}
		}

		public string Zip
		{
			get { return _zip; }
			set
			{
				if (value != _zip)
				{
					_zip = value;
					OnPropertyChanged("Zip");
				}
			}
		}
	}
}

