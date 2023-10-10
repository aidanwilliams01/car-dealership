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
      Car newCar = new Car();
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  }
}