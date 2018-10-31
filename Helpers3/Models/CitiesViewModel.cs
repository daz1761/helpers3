using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers3.Models
{
    public class CitiesViewModel
    {
        // A listbox is a collection of select list item objects
        public IEnumerable<SelectListItem> Cities { get; set; }
        public IEnumerable<string> SelectedCities { get; set; }

    }
}