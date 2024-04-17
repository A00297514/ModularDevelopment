namespace SplitTheBill;

using System;
using System.Collections.Generic;
public class SpiltBill
{
    public decimal SplitTheAmount(decimal amount, int people){
        decimal splitAmount;
        if(people<1){
            throw new ArgumentException("Number of people should be at least 1 or more...!!");
        }

        else if(amount<=0){
            throw new ArgumentException("Amount must be more than 0...!!");
        }

        else{
             splitAmount = amount/people;
        }
        return splitAmount;       
    }

    
    public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        if(tipPercentage<0){
            throw new ArgumentException("Percenatage of tip must be >=0");
        }

        Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();

        decimal totalMealCost = 0;

        foreach (var kvp in mealCosts)
        {
            totalMealCost += kvp.Value;
        }

        foreach (var kvp in mealCosts)
        {
            decimal tipAmount = kvp.Value * Convert.ToDecimal(tipPercentage) / 100;
            decimal weightedTip = tipAmount * (kvp.Value / totalMealCost);
            tipAmounts.Add(kvp.Key, weightedTip);
        }

        return tipAmounts;
    }

    public decimal CalculateTipPerPerson(decimal price, int patrons, float tipPercentage)
    {
        if(price<0){
            throw new ArgumentException("Price must be >=0");
        }

        else if(patrons<1){
            throw new ArgumentException("Number of patrons should be at least 1 or more...!!");
        }

        else if(tipPercentage<0){
            throw new ArgumentException("Tip percentage can not be less than 0...!!");
        }

        else{
            decimal totalTipAmount = price * Convert.ToDecimal(tipPercentage) / 100;

            decimal tipPerPerson = totalTipAmount / patrons;

            return tipPerPerson;
        }        
    }
}
