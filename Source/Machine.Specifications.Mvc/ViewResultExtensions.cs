namespace Machine.Specifications.Mvc
{
    using System.Web.Mvc;

    public static class ViewResultExtensions
    {
        public static void ShouldUseDefaultView(this ViewResult viewResult)
        {
            viewResult.ViewName.ShouldBeEmpty();
        }

        public static ModelTypeAnd<T> ShouldHaveModelOfType<T>(this ViewResult viewResult)
        {
            viewResult.ViewData.Model.ShouldBeOfType<T>();
            return new ModelTypeAnd<T>((T) viewResult.ViewData.Model);
        }
    }
}