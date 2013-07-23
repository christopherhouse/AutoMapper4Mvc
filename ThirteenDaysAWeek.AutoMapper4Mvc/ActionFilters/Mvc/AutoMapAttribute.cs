using System;
using System.Web.Mvc;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.ActionFilters.Mvc
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class AutoMapAttribute : ActionFilterAttribute
    {
    }
}
