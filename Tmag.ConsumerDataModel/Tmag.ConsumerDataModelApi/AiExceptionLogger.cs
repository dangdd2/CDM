using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Tmag.ConsumerDataModelApi
{
    public class AiExceptionLogger : Microsoft.AspNetCore.Mvc.Filters.IExceptionFilter
    {
        public  void OnException(ExceptionContext context)
        {
            if (context != null && context.Exception != null)
            {
                //https://docs.microsoft.com/en-us/azure/azure-monitor/app/api-custom-events-metrics
                //Azure Application Insight
                //Logging exceptions for diagnosis. Trace where they occur in relation to other events and examine stack traces.
                //or reuse instance (recommended!). see note above
                var ai = new TelemetryClient();
                ai.TrackException(context.Exception);
            }
        }
    }
}
