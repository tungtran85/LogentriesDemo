using log4net;
using System;
using System.Web.Mvc;

namespace LogentriesDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog loggerLe = LogManager.GetLogger(typeof(HomeController));

        // GET: Home
        public ActionResult Index()
        {
            for(int i=0; i< 100; i++)
            {
                loggerLe.Info("This is a test message  1 - " + DateTime.UtcNow.Ticks);
                loggerLe.Debug("This is a test message  2 - " + DateTime.UtcNow.Ticks);
                loggerLe.Error("This is a test message  3 - " + DateTime.UtcNow.Ticks);
                loggerLe.Fatal("This is a test message  4 - " + DateTime.UtcNow.Ticks);
                loggerLe.Info("This is a test message  5 - " + DateTime.UtcNow.Ticks);
                loggerLe.Warn("This is a test message  6 - " + DateTime.UtcNow.Ticks);
                loggerLe.Debug("This is a test message  7 - " + DateTime.UtcNow.Ticks);
                loggerLe.Error("This is a test message  8 - " + DateTime.UtcNow.Ticks);
                loggerLe.Fatal("This is a test message  9 - " + DateTime.UtcNow.Ticks);
                System.Threading.Thread.Sleep(2000);
            }           
            return View();
        }
    }
}