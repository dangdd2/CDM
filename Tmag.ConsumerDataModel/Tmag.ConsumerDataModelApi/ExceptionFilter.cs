using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using System;
using System.IO;
using System.Net;
using System.Text;
using Tmag.ConsumerDataModelApi.Helper;

namespace Tmag.ConsumerDataModelApi
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public ExceptionFilter(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnException(ExceptionContext context)
        {
            if (context == null || context.Exception == null)
            {
                return;
            }
            var msg = string.Empty;
            var ex = context.Exception;
            if (context.Exception is UnauthorizedAccessException)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }
            else
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                if (_hostingEnvironment.IsDevelopment())
                {
                    msg = ex.ToString();
                }
                else
                {
                    // msg = "A server error occurred. Please contact the administrator.";
                    msg = ValidationMessages.GenericServerError;
                }
            }
                     
            // record the http request
            // - User agent
            // - Request query, body
            Log.Information(GetHttpRequestDetails(context.HttpContext.Request));

            // log the error            
            Log.Error(ex.ToString());            

            //<TODO> email the error to the development team, administrator

            // handle result translation
            context.Result = new ObjectResult(new { Message = msg });
        }

        /// <summary>
        /// Get the http request details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private string GetHttpRequestDetails(HttpRequest request)
        {
            string baseUrl = $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString.Value}";
            StringBuilder sbHeaders = new StringBuilder();
            foreach (var header in request.Headers)
                sbHeaders.Append($"{header.Key}: {header.Value}\n");

            string body = "no-body";
            if (request.Body.CanSeek)
            {
                request.Body.Seek(0, SeekOrigin.Begin);
                using (StreamReader sr = new StreamReader(request.Body))
                    body = sr.ReadToEnd();
            }

            return $"{request.Protocol} {request.Method} {baseUrl}\n\n{sbHeaders}\n{body}";
        }
    }
}
