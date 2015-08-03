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
    public partial class VIEW_CategoryDetail
    {
        partial void Category_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Category);
        }

        partial void Category_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Category);
        }

        partial void VIEW_CategoryDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Category);
        }
    }
}