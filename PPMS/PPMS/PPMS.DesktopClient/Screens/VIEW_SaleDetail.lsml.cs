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
    public partial class VIEW_SaleDetail
    {
        partial void Sale_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Sale);
        }

        partial void Sale_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Sale);
        }

        partial void VIEW_SaleDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Sale);
        }
    }
}