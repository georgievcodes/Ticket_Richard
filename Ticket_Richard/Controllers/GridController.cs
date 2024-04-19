using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket_Richard.Data;
using Ticket_Richard.Models;

namespace Ticket_Richard.Controllers
{
    public class GridController : Controller
    {
        public ActionResult Orders_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = new OrdersCollection().Get_OrdersSet();

            var dsResult = result.ToDataSourceResult(request);
            return Json(dsResult);
        }

        public ActionResult DropDownListData([DataSourceRequest] DataSourceRequest request)
        {
            var result = new OrdersCollection().Get_OrdersSet().Select(x => x.ShipCity).Distinct();
            return Json(result.ToList());
        }
    }
}
