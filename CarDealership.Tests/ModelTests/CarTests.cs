using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests
  {

    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      Car newCar = new Car("Honda", "Element");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
    
    [TestMethod]
    public void GetMake_ReturnsMake_String()
    {
      string make = "Honda";
      Car newCar = new Car(make, "Element");
      string result = newCar.Make;
      Assert.AreEqual(make, result);
    }

    [TestMethod]
    public void SetMake_SetMake_Void()
    {
      string make = "Honda";
      Car newCar = new Car(make, "Element");
      string updatedMake = "Honda2";
      newCar.Make = updatedMake;
      string result = newCar.Make;
      Assert.AreEqual(updatedMake, result);
    }

    [TestMethod]
    public void GetModel_ReturnsModel_String()
    {
      string model = "Element";
      Car newCar = new Car("Honda", model);
      string result = newCar.Model;
      Assert.AreEqual(model, result);
    }

    [TestMethod]
    public void SetModel_SetModel_Void()
    {
      string model = "Element";
      Car newCar = new Car("Honda", model);
      string updatedModel = "Civic";
      newCar.Model = updatedModel;
      string result = newCar.Model;
      Assert.AreEqual(updatedModel, result);
    }
  }
}