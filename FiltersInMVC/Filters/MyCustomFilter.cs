using System;
using System.IO;
using System.Web.Mvc;

namespace FiltersInMVC.Filters
{
    public class MyCustomFilter : FilterAttribute, IActionFilter
    {
        //It execute when the request/action method execution completed
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            StreamWriter sw = new StreamWriter("D:\\CustomLogs.txt", true);
            sw.WriteLine("Action Method Execution completed on: "+DateTime.Now.ToString());
            sw.WriteLine("_________________________________________________________");
            sw.Close();
        }
        //It execute before the action method execution
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            StreamWriter sw = new StreamWriter("D:\\CustomLogs.txt", true);
            sw.WriteLine("Action Method Execution Starts on: " + DateTime.Now.ToString());
            sw.Close();
        }
    }
}