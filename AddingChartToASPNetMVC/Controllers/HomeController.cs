using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddingChartToASPNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AddingChartToASPNetMVC.Models.ChartModel myChartModel = new Models.ChartModel();

            //Data points to feed our first chart
            myChartModel.firstchart_point_a = "60";
            myChartModel.firstchart_point_b = "500";
            myChartModel.firstchart_point_c = "30";

            //Data points to feed First Dataset of our Second Chart
            myChartModel.secondchart_ds1_point_a = "10";
            myChartModel.secondchart_ds1_point_b = "20";
            myChartModel.secondchart_ds1_point_c = "30";
            myChartModel.secondchart_ds1_point_e = "40";
            myChartModel.secondchart_ds1_point_f = "50";

            //Data points to feed Second Dataset of our Second Chart
            myChartModel.secondchart_ds2_point_a = "15";
            myChartModel.secondchart_ds2_point_b = "25";
            myChartModel.secondchart_ds2_point_c = "37";
            myChartModel.secondchart_ds2_point_e = "48";
            myChartModel.secondchart_ds2_point_f = "53";



            return View("Index",myChartModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}