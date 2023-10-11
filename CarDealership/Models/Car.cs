namespace CarDealership.Models
{
  public class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }

    public Car(string make, string model)
    {
      Make = make;
      Model = model;
    }
  }
}