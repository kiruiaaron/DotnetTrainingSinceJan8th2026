
namespace BlazingPizzaSite.Data;

public class Pizza
{
    public int PizzaId { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public bool Vegetarian { get; set; }

    public bool Vegan { get; set; }

    public int MinimumSize { get; set; }

    public int MaximumSize { get; set; }

    public int Size { get; set; }

    public static int DefaultSize { get; set; } = 12;

    public string GetFormattedTotalPrice() => (Price * Size / 12).ToString("0.00");
     
    public PizzaSpecial Special { get; set; }

  public class PizzaTopping
  {
    public string Name { get; set; }
    public string Ingredients { get; set; }
  }

  public List<PizzaTopping> Toppings { get; set; } = new List<PizzaTopping>();
  public int SpecialId  { get; set; }
}