using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewCustomer_Bill
    {
        partial void CreateNewCustomer_Bill_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.Customer_BillProperty = new Customer_Bill();
        }

        partial void CreateNewCustomer_Bill_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.Customer_BillProperty);
        }

        partial void CreateNewCustomer_Bill_Created()
        {
            // Write your code here.
            Customer_BillProperty.Bill_Amount = 0;
        }
    }
}