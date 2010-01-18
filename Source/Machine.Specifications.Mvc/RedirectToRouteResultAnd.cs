namespace Machine.Specifications.Mvc
{
    using System.Web.Mvc;

    public class RedirectToRouteResultAnd
    {
        readonly RedirectToRouteResult redirectToRouteResult;

        public RedirectToRouteResultAnd(RedirectToRouteResult redirectToRouteResult)
        {
            this.redirectToRouteResult = redirectToRouteResult;
        }

        public RedirectToRouteResult And()
        {
            return this.redirectToRouteResult;
        }
    }
}