using AutoMarketPresentationWeb.Data.Models;

namespace AutoMarketPresentationWeb.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> AllCars { set; get; }
        public string currCategory { set; get; }
    }
}
