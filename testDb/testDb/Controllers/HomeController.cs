using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testDb.Models;
using testDb.ViewModel;

namespace testDb.Controllers
{
    public class HomeController : Controller
    {
        TestDb db = new TestDb();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Cars);
        }
        /// <summary>
        /// Get Add Car
        /// </summary>
        /// <returns></returns>
        public ActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCar(AddNewCar NewCar)
        {
            if (ModelState.IsValid)
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var ca = new Car {
                    Image = "/Images/" + NewCar.Image.FileName.ToString(),
                    CarName = NewCar.CarName,
                    Model = NewCar.Model,
                    Price = NewCar.Price
                };
                NewCar.Image.SaveAs(path + ca.Image);
                db.Cars.Add(ca);
                db.SaveChanges();
            }
            return RedirectToAction("ShowCars");
        }

        public ActionResult ShowCars()
        {
          //  var cars = db.Cars.OrderBy(x => x.Price).ToList();
            return View(db.Cars);

        }

        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult DeletCar(int id)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            Car st = db.Cars.Find(id);
          //  st.Image.Remove(id);
            db.Cars.Remove(st);
            db.SaveChanges();
            return RedirectToAction("ShowCars");
        }
    }
}