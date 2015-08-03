using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Bill_Detail
    {
        partial void Product_Changed()
        {
            Amount = Product.Sales_Rate;
        }

        partial void Quantity_Changed()
        {
            Item_Amount = Amount * (decimal)Quantity;
        }
    }
}
