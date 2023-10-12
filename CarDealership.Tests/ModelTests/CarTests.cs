using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;
using System.Collections.Generic;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests : IDisposable
  {

    public void Dispose()
    {
      Car.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarList()
    {
      List<Car> newList = new List<Car> { };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsCars_CarList()
    {
      string make01 = "honda";
      string make02 = "kia";
      string model01 = "element";
      string model02 = "nero";
      Car newCar1 = new Car(make01, model01);
      Car newCar2 = new Car(make02, model02);
      List<Car> newList = new List<Car> { newCar1, newCar2 };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}