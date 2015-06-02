using System;
using System.Windows.Input;
using Xamarin.Forms;
using Telerik.Everlive.Sdk.Core;
using Telerik.Everlive.Sdk.Core.Model.Base;

namespace XamarinFormsTelerik.ViewModels
{
	public class MainPageViewModel : Customer
	{

		public ICommand ShowNameCommand { get; private set;}
		public ICommand ResetFieldsCommand { get; private set;}

		public bool HasValidInput { get { return !String.IsNullOrEmpty (FirstName) && !String.IsNullOrEmpty(LastName); } }

		public MainPageViewModel ()
		{
			
			ShowNameCommand = new Command (() => {

				var backend = new EverliveApp("Y3R4NJJ5Y3eGh8eT");

				var customerData = backend.WorkWith().Data<Customer>();

				customerData.Create(this).ExecuteSync();

				ResetFieldsCommand.Execute(null);

			});

			ResetFieldsCommand = new Command (() => {

				FirstName = null;
				LastName = null;
				Address  = null;
				City  = null;
				State  = null;
				Zip  = null;
			});


			//Note: Make sure to thank Ed in the article
		}


	}
}

