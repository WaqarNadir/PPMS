using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Purchase_Detail
    {
        partial void Purchase_Rate_Changed()
        {

            Item_total =Decimal.Round(Purchase_Rate * (decimal)Quantity, 2);
        }

        partial void Purchase_Rate_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (Purchase_Rate < 0)
            {
                results.AddPropertyError("Purchase Rate must be zero or greater than zero");
            }

        }

        partial void Quantity_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (Quantity < 0)
            {
                results.AddPropertyError("Quantity must be zero or greater than zero");
            }

        }
    }
}
