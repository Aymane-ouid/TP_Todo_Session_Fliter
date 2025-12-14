using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Todo_SRP_DIP.Filters
{
    public class AuthFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.Session.GetString("UserLogin");
            var controller = context.RouteData.Values["controller"]?.ToString();
            var action = context.RouteData.Values["action"]?.ToString();

            if (string.IsNullOrEmpty(user))
            {
                if (controller?.Equals("User", StringComparison.OrdinalIgnoreCase) == true &&
                    action?.Equals("Index", StringComparison.OrdinalIgnoreCase) == true)
                {
                    return;
                }
                context.Result = new RedirectToActionResult("Index", "User", null);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
