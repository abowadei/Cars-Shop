using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testDb.ViewModel
{
    public class AddNewCar
    {
        [Required]
        public string CarName { get; set; }
        [Required]
        public HttpPostedFileBase Image { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Price { get; set; }
    }
}