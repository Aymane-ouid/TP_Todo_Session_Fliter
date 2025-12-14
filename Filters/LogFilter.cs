using Microsoft.AspNetCore.Mvc.Filters;
using Todo_SRP_DIP.Services;

namespace Todo_SRP_DIP.Filters
{
    public class LogFilter : IActionFilter
    {
        private readonly ILogService _logService;


        public LogFilter(ILogService logService)
        {
            _logService = logService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.Session.GetString("UserLogin") ?? "Anonymous";
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            _logService.Log($"{date} - {user} - {controller} - {action}");
        }

        public void OnActionExecuted(ActionExecutedContext context) { }

    }
}