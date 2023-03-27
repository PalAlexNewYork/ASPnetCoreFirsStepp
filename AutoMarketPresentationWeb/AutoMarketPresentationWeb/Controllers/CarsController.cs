using AutoMarketPresentationWeb.Data.Interface;
using AutoMarketPresentationWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMarketPresentationWeb.Controlers
{
    public class CarsController :  Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _carsCategory = carsCategory;
        }

        public ViewResult List() {
            ViewBag.Titlle = "Страница с автомобилями";
            CarListViewModel obj = new CarListViewModel();
            obj.AllCars = _allCars.cars;
            obj.currCategory = "Все Автомобили";
            return View(obj);
        }

    }
}
