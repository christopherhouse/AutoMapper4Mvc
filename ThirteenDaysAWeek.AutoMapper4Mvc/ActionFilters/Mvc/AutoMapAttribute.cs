using System;
using System.Web.Mvc;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.ActionFilters.Mvc
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class AutoMapAttribute : ActionFilterAttribute
    {
        public AutoMapAttribute(Type sourceType, Type destinationType)
        {
            if (sourceType == null)
            {
                throw new ArgumentNullException("sourceType");
            }

            if (destinationType == null)
            {
                throw new ArgumentNullException("destinationType");
            }

            SourceType = sourceType;

            DestinationType = destinationType;
        }

        public Type SourceType { get; private set; }

        public Type DestinationType { get; private set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            object model = filterContext.Controller.ViewData.Model;
            object viewModel = AutoMapper.Mapper.Map(model, SourceType, DestinationType);

            filterContext.Controller.ViewData.Model = viewModel;
        }
    }
}
