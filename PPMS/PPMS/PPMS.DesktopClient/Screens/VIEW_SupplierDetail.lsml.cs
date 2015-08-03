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
    public partial class VIEW_SupplierDetail
    {
        partial void Supplier_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Supplier);
        }

        partial void Supplier_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Supplier);
        }

        partial void VIEW_SupplierDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Supplier);
        }

       
    }
}