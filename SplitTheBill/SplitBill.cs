namespace SplitTheBill;

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
        Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();
        
        foreach (var entry in mealCosts)
        {
            decimal tipAmount = entry.Value * (decimal)(tipPercentage / 100);
            tipAmounts.Add(entry.Key, tipAmount);
        }
        
        return tipAmounts;
    }
}
