using System;
using System.Web.Http.Filters;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.ActionFilters.Http
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class AutoMapAttribute : ActionFilterAttribute
    {
    }
}
