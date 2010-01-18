Machine.Specifications.Mvc is a set of extensions for testing ASP.Net MVC specific types. 

It aims to ease the testing of ActionResult objects returned from MVC Controllers by providing an MSpec BDD syntax over these types.


Current Features:

-----------------------------------------------------------------------------------

ActionResult extensions

 - ShouldBeAView()

 e.g. result.ShouldBeAView();

 
 - ShouldBeARedirectToRoute()

 e.g. result.ShouldBeARedirectToRoute();


 - ShouldBeARedirect()

 e.g. result.ShouldBeARedirect();



Each expose the And() chaining command, returning the strongly typed ActionResult.


 - e.g. result.ShouldBeAView().And().ViewName.ShouldEqual("NotFound");

 - e.g. result.ShouldBeARedirect().And().Url.ShouldEqual("http://someurl.com");

 - e.g. result.ShouldBeARedirectToRoute().And().RouteName.ShouldEqual("RouteName");

-----------------------------------------------------------------------------------

ViewResult specific extensions

 - ShouldUseDefaultView()	

   e.g. result.ShouldBeAView().And().ShouldUseDefaultView();

 - ShouldHaveModelOfType<T>()

   e.g. result.ShouldBeAView().And().ShouldHaveModelOfType<Person>();

ShouldHaveModelOfType<T>() also exposes the And() chaining command, returning the model strongly typed as T

 - e.g. result.ShouldBeAView().And().ShouldHaveModelOfType<Person>().And().Id.ShouldEqual(1);

 
-----------------------------------------------------------------------------------

RedirectToRoute specific extensions

 - ControllerName()

 e.g. result.ShouldBeARedirectToRoute().And().ControllerName().ShouldEqual("Person");

 - ActionName()

 e.g. result.ShouldBeARedirectToRoute().And().ActionName().ShouldEqual("List");

-----------------------------------------------------------------------------------

Further ActionResult extensions

 - Model<T>()
  
   Provides a shortcut straight to the ViewData.Model property of an ActionResult cast as a ViewResult

   e.g. result.Model<Person>().Name.ShouldEqual("James Broome"); 


 - ShouldRedirectToAction<TController>(Expression<Action<TController>> action)

   Provides a strongly typed shortcut to check an ActionResult cast as a RedirectToRoute against Actions on Controllers

   e.g. result.ShouldRedirectToAction<HomeController>(x => x.Index());



