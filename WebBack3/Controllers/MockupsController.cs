using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBack3.Models;
namespace WebBack3.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Quiz(Questions question, string action)
        {


            if (!ModelState.IsValid) { ViewBag.Problem = question.problem; return View(question); }
            IdentityMap.Get().Last().yanswer = question.yanswer;
            if (IdentityMap.Get().Last().answer == Convert.ToInt32(question.yanswer)) IdentityMap.rights++;
           IdentityMap.alls++;
            if (action == "Finish") return RedirectToAction("QuizResult");
            Questions act = new Questions();
            ViewBag.Problem = act.problem;
            IdentityMap.AddAction(act);
            return View(act);
        }
        [HttpGet]
        public IActionResult Quiz()
        {
            Questions question = new Questions();
            ViewBag.Problem = question.problem;
            IdentityMap.AddAction(question);
            return View(question);
        }
        public IActionResult QuizResult()
        {
            return View(IdentityMap.Get());
        }        
        }
}
