using System;
using System.Collections.Generic;
using Telerik.Everlive.Sdk.Core;
using Xamarin.Forms;

namespace XamarinFormsTelerik
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		void submitClicked(object sender, EventArgs args)
		{
			SubmitData(entryFirstName.Text, entryLastName.Text, entryAddress.Text, entryCity.Text, entryState.Text, entryZip.Text);
		}

		private void SubmitData(string strFirstName, string strLastName, string strAddress, string strCity, string strState, string strZip)
		{
			var backend = new EverliveApp("Y3R4NJJ5Y3eGh8eT");

			var customerData = backend.WorkWith().Data<Customer>();

			Customer cust = new Customer()
			{
				FirstName = strFirstName,
				LastName = strLastName,
				Address = strAddress,
				City = strCity,
				State = strState,
				Zip = strZip
			};

			customerData.Create(cust).ExecuteSync();

		}

		void resetClicked(object sender, EventArgs args)
		{
			entryFirstName.Text = null;
			entryLastName.Text = null;
			entryAddress.Text = null; 
			entryCity.Text = null; 
			entryState.Text = null; 
			entryZip.Text = null; 
		}

	}
}

