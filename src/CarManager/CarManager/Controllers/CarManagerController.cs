using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCA.CarLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarManager.Controllers
{
    public class CarManagerController : Controller
    {
        private readonly CarRepository _carRepo = new CarRepository();

        // GET: CarManager
        public IActionResult Index()
        {
            return View(_carRepo.GetList());
        }

        // GET: CarManager/Details/5
        public IActionResult Details(int id)
        {
            return View(_carRepo.GetCarById(id));
        }

        // GET: CarManager/Create
        public IActionResult Create()
        {
            Car newCar = new Car
            {
                Year = DateTime.Now.Year
            };

            return View(newCar);
        }

        // POST: CarManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car newCar, IFormCollection collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _carRepo.AddCar(newCar);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(newCar);
                }

            }
            catch
            {
                return View(newCar);
            }
        }

        // GET: CarManager/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarManager/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}