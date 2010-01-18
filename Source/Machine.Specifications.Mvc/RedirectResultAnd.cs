namespace Machine.Specifications.Mvc
{
    using System;
    using System.Web.Mvc;

    public class RedirectResultAnd
    {
        readonly RedirectResult redirectResult;

        public RedirectResultAnd(RedirectResult redirectResult)
        {
            this.redirectResult = redirectResult;
        }

        public RedirectResult And()
        {
            return this.redirectResult;
        }
    }
}