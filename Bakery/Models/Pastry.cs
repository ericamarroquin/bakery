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
      int quantityDivisibleByTwo = Quantity % 3;
      int quantityDivisibleByThree = (Quantity - quantityDivisibleByTwo) / 3;
      return (quantityDivisibleByTwo * 2) + (quantityDivisibleByThree * 5);
    }
  }
}