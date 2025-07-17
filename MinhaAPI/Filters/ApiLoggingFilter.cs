using Microsoft.AspNetCore.Mvc.Filters;
using System.Data;

namespace MinhaAPI.Filters
{
    public class ApiLoggingFilter : IActionFilter
    {
        private readonly ILogger<ApiLoggingFilter> _logger;
        public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Executa antes da ação ser executada
            _logger.LogInformation("### Executando -> OnActionExecuting ###");
            _logger.LogInformation("#########################################");
            _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
            _logger.LogInformation($"Status Code : {context.HttpContext.Response.StatusCode}");
            _logger.LogInformation("#########################################");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Executa depois da ação ser executada
            _logger.LogInformation("### Executando -> OnActionExecuted ###");
            _logger.LogInformation("#########################################");
            _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
            _logger.LogInformation($"Status Code : {context.HttpContext.Response.StatusCode}");
            _logger.LogInformation("#########################################");
        }
    }
}
