using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string make, string model)
    {
      Make = make;
      Model = model;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}