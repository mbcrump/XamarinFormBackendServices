// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace XamarinFormsTelerik {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MainPage : ContentPage {
        
        private Entry entryFirstName;
        
        private Entry entryLastName;
        
        private Entry entryAddress;
        
        private Entry entryCity;
        
        private Entry entryState;
        
        private Entry entryZip;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MainPage));
            entryFirstName = this.FindByName <Entry>("entryFirstName");
            entryLastName = this.FindByName <Entry>("entryLastName");
            entryAddress = this.FindByName <Entry>("entryAddress");
            entryCity = this.FindByName <Entry>("entryCity");
            entryState = this.FindByName <Entry>("entryState");
            entryZip = this.FindByName <Entry>("entryZip");
        }
    }
}
