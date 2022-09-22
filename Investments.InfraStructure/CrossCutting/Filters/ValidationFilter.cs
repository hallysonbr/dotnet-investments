using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Investments.InfraStructure.CrossCutting.Filters
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var message = context.ModelState
                                .SelectMany(ms => ms.Value.Errors)
                                .Select(e => e.ErrorMessage)
                                .ToList();

                context.Result = new BadRequestObjectResult(message);
            }
        }
    }
}