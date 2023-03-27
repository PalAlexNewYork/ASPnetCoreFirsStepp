using AutoMarketPresentationWeb.Data.Models;

namespace AutoMarketPresentationWeb.Data.Interface
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
