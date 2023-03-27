using AutoMarketPresentationWeb.Data.Interface;
using AutoMarketPresentationWeb.Data.Models;

namespace AutoMarketPresentationWeb.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get { 
                return new List<Category> {
                    new Category { CategoryName = "Электромобили", Description="Современный вид транспорта" },
                    new Category { CategoryName = "Класические автомобили", Description = "Автомобили на двигателе внутреннего сгорания" },
                    };
            }
        }
    }
}
