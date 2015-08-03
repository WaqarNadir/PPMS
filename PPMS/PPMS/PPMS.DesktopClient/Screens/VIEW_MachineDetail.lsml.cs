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
    public partial class VIEW_MachineDetail
    {
        partial void Machine_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Machine);
        }

        partial void Machine_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Machine);
        }

        partial void VIEW_MachineDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Machine);
        }
    }
}