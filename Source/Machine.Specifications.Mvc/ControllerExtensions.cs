namespace Machine.Specifications.Mvc
{
    using System;
    using System.Web.Mvc;

    public static class ControllerExtensions
    {
        public static string RoutingName(this Controller controller)
        {
            return GetRoutingName(controller.GetType().Name);
        }

        public static string RoutingName<TController>() where TController : Controller
        {
            return GetRoutingName(typeof(TController).Name);
        }

        private static string GetRoutingName(string controllerName)
        {
            controllerName.EndsWith("Controller", StringComparison.OrdinalIgnoreCase).ShouldBeTrue();

            controllerName = controllerName.Substring(0, controllerName.Length - "Controller".Length);

            controllerName.ShouldNotBeEmpty();

            return controllerName;
        }
    }
}