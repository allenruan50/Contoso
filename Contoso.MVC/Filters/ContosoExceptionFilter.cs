using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;

namespace Contoso.MVC.Filters
{
    public class ContosoExceptionFilter : HandleErrorAttribute
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public ContosoExceptionFilter()
        {

        }
        public override void OnException(ExceptionContext filterContext)
        {
            var controllerName = (string)filterContext.RouteData.Values["Controller"];
            var actionName = (string)filterContext.RouteData.Values["Action"];
            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);//we can put the model in shared view in error
            filterContext.Result = new ViewResult
            {
                ViewName = View,
                MasterName = Master,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                TempData = filterContext.Controller.TempData
            };
            string exceptionPath = filterContext.HttpContext.Request.Path + filterContext.HttpContext.Request.QueryString;

            //log exception info like 
            //1.exception: filterContext.Exception
            //2.inner message
            //3.DateTime: datetime.now
            //4.action name and controller name
            //5.the whole stack trace: filter.Exception.StackTraces
            //6.exception path(URL)
            //7.log above details using NLog to text files

            //manually create text file(not use)
            //third party libarary: 1.NLog(use this one which is also popular in .NET CORE)2. Log4Net

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;

            logger.Info(filterContext.Exception);
            //logger.Info(filterContext.Exception.InnerException);
            //logger.Info(DateTime.Now);
            //logger.Info(actionName + " " + controllerName);
            //logger.Info(filterContext.Exception.StackTrace);
            //logger.Info(filterContext.Exception.Source);

            base.OnException(filterContext);

        }
    }
}