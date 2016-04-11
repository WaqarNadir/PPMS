using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Customer_Bill
    {
        partial void Customer_Changed()
        {
            Total = Customer.Amount_Remaining;
        }

        
    }
}
