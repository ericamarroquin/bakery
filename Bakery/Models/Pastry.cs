namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int Cost() // 6
    {
      int quantityDivisibleByTwo = Quantity % 3; // 0 
      int quantityDivisibleByThree = (Quantity - quantityDivisibleByTwo) / 3; // (6 - 0) / 3 = 6 / 3 = 2
      return (quantityDivisibleByTwo * 2) + (quantityDivisibleByThree * 5); // (0*2)+(2*5) = 0+10 = 10
    }
  }
}

// Pastry: Buy 1 for $2 or 3 for $5. 
// Four pastries costs $7, five pastries costs $9, 
// and six pastries costs $10.