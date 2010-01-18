namespace Machine.Specifications.Mvc
{
    using System.Web.Mvc;

    public static class RedirectToRouteResultExtensions
    {
        public static string ControllerName(this RedirectToRouteResult redirectToRouteResult)
        {
            return redirectToRouteResult.RouteValues["Controller"].ToString();
        }

        public static string ActionName(this RedirectToRouteResult redirectToRouteResult)
        {
            return redirectToRouteResult.RouteValues["Action"].ToString();
        }
    }
}