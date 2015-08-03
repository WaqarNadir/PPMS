using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Machine
    {
        partial void Machine_Reading_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (Machine_Reading == null)
            {
                Machine_Reading = 0;
            }

        }
    }
}
