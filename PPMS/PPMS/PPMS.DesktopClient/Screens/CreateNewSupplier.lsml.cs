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
    public partial class CreateNewSupplier
    {
        partial void CreateNewSupplier_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.SupplierProperty = new Supplier();
        }

        partial void CreateNewSupplier_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.SupplierProperty);
        }

        partial void CreateNewSupplier_Created()
        {
            // Write your code here.
            SupplierProperty.country = "Pakistan";

        }
    }
}