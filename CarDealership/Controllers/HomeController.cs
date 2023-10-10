using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter() 
    { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable); 
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
    
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location1, string location2, string location3, string souvenir1, string souvenir2, string souvenir3)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location1 = location1;
      myLetterVariable.Location2 = location2;
      myLetterVariable.Location3 = location3;
      myLetterVariable.Souvenir1 = souvenir1;
      myLetterVariable.Souvenir2 = souvenir2;
      myLetterVariable.Souvenir3 = souvenir3;
      return View(myLetterVariable);
    }
  }
}