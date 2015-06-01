using System;
using Telerik.Everlive.Sdk.Core.Model.Base;

namespace XamarinFormsTelerik
{
	class Customer : DataItem
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
	}
}

