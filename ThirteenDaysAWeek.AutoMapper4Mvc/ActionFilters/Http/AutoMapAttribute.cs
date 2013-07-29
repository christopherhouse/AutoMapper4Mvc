using System;
using System.Net.Http;
using System.Web.Http.Filters;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.ActionFilters.Http
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

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception == null)
            {
                if (!(actionExecutedContext.Response.Content is ObjectContent))
                {
                    throw new InvalidOperationException("AutoMapAttribute can only operate on messages with an ObjectContent respose");
                }

                ObjectContent response = actionExecutedContext.Response.Content as ObjectContent;

                object output = AutoMapper.Mapper.Map(response.Value, SourceType, DestinationType);
                actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(actionExecutedContext.Response.StatusCode, output);
            }
        }
    }
}
