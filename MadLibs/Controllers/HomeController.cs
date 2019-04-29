using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;
namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {   [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/")]
        public ActionResult introform() { return View(); }

        [Route("/journal")]
        public ActionResult Journal() { return View(); }

        [Route("/form")]
        public ActionResult Form() { return View();}

        [Route("/formtwo")]
        public ActionResult Form2() { return View();}

        [Route("/formthree")]
        public ActionResult Form3() { return View();}

        [Route("/madlibs")]
        public ActionResult MadLibs(string ex, string adv, string noun, string adj)
        {
            LetterVariable myLetterVariable = new LetterVariable(4);
            myLetterVariable.SetWord(ex);
            myLetterVariable.SetWord(adv);
            myLetterVariable.SetWord(noun);
            myLetterVariable.SetWord(adj);
            return View(myLetterVariable);
        }
        [Route("/madlibstwo")]
        public ActionResult MadLibstwo(string ex, string adv, string noun, string adj, string adj2)
        {
            LetterVariable myLetterVariable = new LetterVariable(6);
            myLetterVariable.SetWord(ex);
            myLetterVariable.SetWord(adv);
            myLetterVariable.SetWord(noun);
            myLetterVariable.SetWord(adj);
            myLetterVariable.SetWord(adj2);
            myLetterVariable.SetWord(noun);
            return View(myLetterVariable);
        }
        [Route("/madlibsthree")]
        public ActionResult MadLibsthree(string ex, string adv, string noun, string adj, string adj2, string noun2, string noun3)
        {
            LetterVariable myLetterVariable = new LetterVariable(7);
            myLetterVariable.SetWord(ex);
            myLetterVariable.SetWord(adv);
            myLetterVariable.SetWord(noun);
            myLetterVariable.SetWord(adj);
            myLetterVariable.SetWord(adj2);
            myLetterVariable.SetWord(noun2);
            myLetterVariable.SetWord(noun3);
            return View(myLetterVariable);
        }
    }

}
