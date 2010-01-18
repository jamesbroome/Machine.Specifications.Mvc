namespace Machine.Specifications.Mvc.Example
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();    
        }

        public ActionResult Show(int id)
        {
            if (id == 999)
            {
                return View("NotFound");
            }

            var person = new Person() { Id = id, Name = "James Broome" };

            return View(person);
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Update(Person person, bool loggedIn)
        {
            if (!loggedIn)
            {
                return new RedirectResult("http://openid.co.uk");
            }

            if (person.Id == 999)
            {
                // Error
                return new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Person", action = "Update" }));
            }

            // Update the person... 
            
            return new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Person", action = "List" }));
        }
    }
}