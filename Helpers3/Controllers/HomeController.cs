using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers3.Models;
using System.Text;

namespace Helpers3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            SampleDBContext db = new SampleDBContext();
            List<SelectListItem> listSelectListItem = new List<SelectListItem>();

            foreach(City city in db.Cities)
            {
                listSelectListItem.Add(new SelectListItem { Text = city.Name, Value = city.ID.ToString(), Selected = city.IsSelected });
            }

            CitiesViewModel citiesViewModel = new CitiesViewModel();
            citiesViewModel.Cities = listSelectListItem;

            return View(citiesViewModel);
        }

        [HttpPost]
        public string Index(IEnumerable<string> selectedCities)
        {
            if(selectedCities == null)
            {
                return "You did not select any cities";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected - " + string.Join(",", selectedCities));

                return sb.ToString();
            }
        }
    }
}