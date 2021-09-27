namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int Cost()
    {
      // int quantityDivisibleByTwo = Quantity % 3;
      // int quantityDivisibleByThree = (Quantity - quantityDivisibleByTwo) / 3;
      // return (quantityDivisibleByTwo * 2) + (quantityDivisibleByThree * 5);
      return Quantity * 2;
    }
  }
}

// Pastry: Buy 1 for $2 or 3 for $5. 
// Four pastries costs $7, five pastries costs $9, 
// and six pastries costs $10.