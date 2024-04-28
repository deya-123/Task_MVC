using Microsoft.AspNetCore.Mvc.Rendering;

namespace Task_one.Extensions
{
  
    
        public static class HtmlExtensions
        {
            public static bool ShouldShowElement(this IHtmlHelper htmlHelper, string controller, string action)
            {
                var currentController = htmlHelper.ViewContext.RouteData.Values["controller"]?.ToString();
                var currentAction = htmlHelper.ViewContext.RouteData.Values["action"]?.ToString();
                return string.Equals(currentController, controller, StringComparison.OrdinalIgnoreCase) &&
                       string.Equals(currentAction, action, StringComparison.OrdinalIgnoreCase);
            }
        }
    
}
