using AutoMarketPresentationWeb.Data.Models;

namespace AutoMarketPresentationWeb.Data.Interface
{
    public interface IAllCars
    {
        IEnumerable<Car> cars { get; }
        IEnumerable <Car> getFavCars { set;get; }
        Car getObjCar(int CarId);
    }
}
