namespace Machine.Specifications.Mvc
{
    using System.Web.Mvc;

    public class ViewResultAnd
    {
        readonly ViewResult viewResult;

        public ViewResultAnd(ViewResult viewResult)
        {
            this.viewResult = viewResult;
        }

        public ViewResult And()
        {
            return this.viewResult;
        }
    }
}