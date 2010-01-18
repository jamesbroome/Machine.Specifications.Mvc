namespace Machine.Specifications.Mvc
{
    using System;
    using System.Linq.Expressions;
    using System.Web.Mvc;

    public static class ExpressionActionExtensions
    {
        public static string GetMethodBodyName<TController>(this Expression<Action<TController>> action) where TController : Controller
        {
            action.ShouldNotBeNull();
            action.Body.ShouldBeOfType<MethodCallExpression>();
            return ((MethodCallExpression)action.Body).Method.Name;
        }
    }
}