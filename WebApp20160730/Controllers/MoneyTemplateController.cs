using System.Collections.Generic;
using System.Web.Mvc;
using WebApp20160730.Models;

namespace WebApp20160730.Controllers
{
    public class MoneyTemplateController : Controller
    {
        // GET: MoneyTemplate
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildAction()
        {
            List<MoneyTemplate> moneyTemplates = new List<MoneyTemplate>
            {
                new MoneyTemplate
                {
                    Category = "支出",
                    Money = 300.ToString("N0"),
                    Date = "2016-01-01",
                    Description = ""
                },
                new MoneyTemplate
                {
                    Category = "支出",
                    Money = 1600.ToString("N0"),
                    Date = "2016-01-02",
                    Description = ""
                },
                new MoneyTemplate
                {
                    Category = "支出",
                    Money = 500.ToString("N0"),
                    Date = "2016-01-03",
                    Description = ""
                }
            };

            return View(moneyTemplates);
        }
    }
}