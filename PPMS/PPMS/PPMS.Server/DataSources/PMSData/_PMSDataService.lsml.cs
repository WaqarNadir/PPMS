using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class PMSDataService
    {
        partial void Purchase_Details_Inserted(Purchase_Detail entity)
        {
            //============== product Stock is changing here =======================
            entity.Product.Stock_In_hand += entity.Quantity;

            //adds this quantity to previous stock 


        }
        Purchase update_total(Purchase entity)
        {
            //========== changing the value of total ===========================================

            var PDetail = from val in entity.Purchase_Details
                          select val;
            foreach (var value in PDetail)
            {
                entity.Total += value.Item_total;
                // Item amounts are updated in total 
            }
            return entity;
            //======================================================================================
        }

        partial void Purchase_Details_Updating(Purchase_Detail entity)
        {
            var value = (from val in Purchases
                         where val.Purchase_ID.Equals(entity.Purchase.Purchase_ID)
                         select val).FirstOrDefault();
            value.Total = 0;
            entity.Purchase = update_total(value);        //if product detail value is changed then recount total and update it.
        
        }

        partial void Purchases_Inserting(Purchase entity)
        {
            update_total(entity);// change total to bill total
        }

        partial void Sales_Inserting(Sale entity)
        {
            // UPDATING MACHINE READING 
            foreach (Sale_Detail sd in entity.Sale_Details)
            {
                sd.Machine.Machine_Reading = sd.CLosing_sale;
            }
            calculateTotal(entity);

        }
        Sale calculateTotal(Sale entity)
        {
            var value = from val in entity.Sale_Details
                        select val;
            foreach (var val in value)
            {
                entity.Total += val.Sale_total;
            }
            return entity;

        }

        partial void Machines_Inserting(Machine entity)
        {
            if (entity.Machine_Reading == null)
            {
                entity.Machine_Reading = 0;
            }
        }

        partial void Products_Inserting(Product entity)
        {
            entity.Sales_Rate = decimal.Round(entity.Sales_Rate, 2);
        }

        partial void Sale_Details_Updating(Sale_Detail entity)
        {
            var value = (from val in Sales
                         where val.Sale_ID.Equals(entity.Sale.Sale_ID)
                         select val).FirstOrDefault();
            value.Total = 0;
            entity.Sale = calculateTotal(value);        //if sale detail value is changed then 
                                                        //recount total and update it.
        
        }

        partial void Customer_Bills_Inserting(Customer_Bill entity)
        {
            var detail= from val in entity.Bill_Details
                                 select val;
            foreach (var value in detail)
            {
                entity.Bill_Amount += value.Item_Amount;
            }

            Customer_Bill customer_bill = (from value in this.DataWorkspace.PMSData.Customer_Bills
                                where value.Customer.Customer_ID == entity.Customer.Customer_ID
                                orderby value.Bill_ID descending
                                select value ).FirstOrDefault();
            if (customer_bill != null)
            {
                entity.Total = customer_bill.Total + (decimal)entity.Bill_Amount;
                // adding current bill amount to previous total of customer 
            }
            else
            {
                entity.Total =  (decimal)entity.Bill_Amount;
            }
            entity.Customer.Amount_Remaining = entity.Total;    // ... copying total to customer 
        }
        


       
        
    }
}
