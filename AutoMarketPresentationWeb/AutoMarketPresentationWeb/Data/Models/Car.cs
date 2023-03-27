namespace AutoMarketPresentationWeb.Data.Models
{
    public class Car
    {
        public int  Id { set; get; }
        public string Name { set; get; }
        public string ShortDescr { set; get; }
        public string LongDescr { set; get; }
        public string Img { set; get; }
        public decimal Price { set; get; }
        public bool IsFavorite { set; get; }
        public bool Available { set; get; }
        public virtual Category Category { set; get; }

    }
}
