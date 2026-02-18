using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StockControl.Communication.Responses.Error;
using StockControl.Exceptions;
using StockControl.Exceptions.ExceptionsBase;
using System.Net;

namespace StockControl.API.Filters
{
    public class ExceptionsFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is StockControlException stockControlException)
                HandleProjectException(stockControlException, context);
            else
                ThrowUnknownErrorException(context);
        }

        private void HandleProjectException(StockControlException stockControlException, ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)stockControlException.GetStatusCode();
            context.Result = new ObjectResult(new ResponseErrorJson(stockControlException.GetErrorMessages()));
        }

        private void ThrowUnknownErrorException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorJson(ResourceMessagesExceptions.UNKNOWN_ERROR));
        }
    }
}
