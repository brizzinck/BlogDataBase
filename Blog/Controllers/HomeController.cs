using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Logic.UsersDB;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UsersModel model)
        {
            if (ModelState.IsValid)
            {
                CreateUser(model.age, model.name, model.surname, model.Email, model.Password);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult ViewUsers()
        {
            var data = LoadUsers();
            List<UsersModel> users = new List<UsersModel>();
            foreach (var user in data)
            {
                users.Add(new UsersModel
                {
                    age = user.age,
                    name = user.name,
                    surname = user.surname,
                    Email = user.email,
                    Password = user.password,
                });
            }
            return View(users);
        }
    }
}