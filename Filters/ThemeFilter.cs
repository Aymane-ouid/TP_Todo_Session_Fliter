using Microsoft.AspNetCore.Mvc.Filters;

namespace Todo_SRP_DIP.Filters
{
    public class ThemeFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var theme = context.HttpContext.Request.Cookies["theme"];
            context.HttpContext.Items["Theme"] = theme ?? "light";
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
