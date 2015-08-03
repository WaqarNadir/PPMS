using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Sale_Detail
    {
        
        partial void Product_Changed(){
            Sales_Rate = Product.Sales_Rate;
            Opening_Sale = Machine.Machine_Reading.Value;
        }

        partial void CLosing_sale_Changed()
        {
            Quantity = CLosing_sale - Opening_Sale;
        }

        partial void Quantity_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (Quantity <= 0)
            {
                results.AddPropertyError("Quantity cannot be negative. Closing sale is not correctly entered ");
            }

        }


        partial void Sale_total_Compute(ref decimal result)
        {
            // Set result to the desired field value
            result = Decimal.Round(Sales_Rate * (decimal)Quantity,2);

        }

    }
}
