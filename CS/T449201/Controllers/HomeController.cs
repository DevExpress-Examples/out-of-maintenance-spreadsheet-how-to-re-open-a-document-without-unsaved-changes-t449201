using DevExpress.Web.Mvc;
using DevExpress.Web.Office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T449201.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            return View();
        }

        public ActionResult SpreadsheetPartial() {
            return PartialView("_SpreadsheetPartial");
        }
        public ActionResult SpreadsheetCustomPartial() {
            string documentID = SpreadsheetExtension.GetDocumentId("Spreadsheet");
            SpreadsheetExtension.CloseDocument("Spreadsheet");
            return SpreadsheetExtension.Open("Spreadsheet", documentID);

        }
    }
}