namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int Cost()
    {
      if (Quantity % 3 == 0)
      {
        return (Quantity * 5) - ((Quantity / 3) * 5);
      }
      else
      {
        return Quantity * 5;
      }
    }
  }
}