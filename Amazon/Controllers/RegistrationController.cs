using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Amazon.Models;

namespace Amazon.Controllers
{
    public class RegistrationController : Controller
    {
        StoreDbContext dc = new StoreDbContext();

        public ViewResult UserRegister()
        {
            Registration re = new Registration();
            return View(re);
        }
        [HttpPost]
        public string AddUser(Registration registration)
        {
            dc.Registrations.Add(registration);
            dc.SaveChanges();
            return "User added successfully";
        }
    }
}