using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Viatrax_Trial_Project.Controllers
{
    public class GoogleMapController : Controller
    {
        // GET: GoogleMap
        public ActionResult Index()
        {
            return View();
        }





        public ActionResult ShowDeviceLocationOnMap(float latitude, float longitude)
        {
            //Get Gps Coordinates (Latitude , Longitude) values
            if (latitude != 0 && longitude != 0)
            {
                Session["latitude"] = latitude;
                Session["longitude"] = longitude;
   
            }
            return View();
        }


    }
}