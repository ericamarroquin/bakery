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
      return Quantity * 2;
    }
  }
}