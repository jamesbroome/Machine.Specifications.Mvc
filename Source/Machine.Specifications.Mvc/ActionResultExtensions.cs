namespace Machine.Specifications.Mvc
{
    using System;
    using System.Linq.Expressions;
    using System.Web.Mvc;

    public static class ActionResultExtensions
    {
        public static ViewResultAnd ShouldBeAView(this ActionResult actionResult)
        {
            actionResult.ShouldBeOfType<ViewResult>();
            return new ViewResultAnd(actionResult as ViewResult);
        }

        public static RedirectToRouteResultAnd ShouldBeARedirectToRoute(this ActionResult actionResult)
        {
            actionResult.ShouldBeOfType<RedirectToRouteResult>();
            return new RedirectToRouteResultAnd(actionResult as RedirectToRouteResult);
        }

        public static T Model<T>(this ActionResult actionResult)
        {
            return actionResult.ShouldBeAView().And().ShouldHaveModelOfType<T>().And();
        }

        public static RedirectResultAnd ShouldBeARedirect(this ActionResult actionResult)
        {
            actionResult.ShouldBeOfType<RedirectResult>();
            return new RedirectResultAnd(actionResult as RedirectResult);
        }

        public static void ShouldRedirectToAction<TController>(this ActionResult actionResult, Expression<Action<TController>> action) where TController : Controller
        {
            actionResult.ShouldBeARedirectToRoute()
            .And().ControllerName().ToLower().ShouldEqual(ControllerExtensions.RoutingName<TController>().ToLower());

            actionResult.ShouldBeARedirectToRoute()
                .And().ActionName().ToLower().ShouldEqual(action.GetMethodBodyName().ToLower());
        }
    }
}