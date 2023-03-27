using AutoMarketPresentationWeb.Data.Interface;
using AutoMarketPresentationWeb.Data.Models;

namespace AutoMarketPresentationWeb.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> cars {
            get { 
                return new List<Car> {
                    new Car { 
                        Id= 1, 
                        Name = "Tesla", ShortDescr="Tesla model XL", 
                        LongDescr="У меня Model X P100D. Разгон от 0-60mph это те же 2.8 секунды, что и моя Model S P90D и это самый быстрый " +
                        "серийный SUV в мире. И именно из-а того, что она выше на 25см ощущения и даже как вдавливает в кресла немного " +
                        "отличаются: машина больше и скорость не чувствуется так сильно. Я как выехал из магазина Tesla и поехал домой," +
                        " пристроился за девушкой на байке (она выезжала на хайвэй), ну и собственно задумался о чем-то она впереди маячит, я " +
                        "держу дистанцию. Посмотрел на спидометр - еду 155 (!! ##ять!), а педаль в пол даже не процентов на 30 не давил." +
                        " Охренел немного, тут же снизил до допустимой скорости и понял, что к машине нужно немного попривыкнуть, " +
                        "банально чтобы не остановила полиция. Попробовал разгон с места - по ощущениям, машина получает ГОРАЗДО " +
                        "больше мощности на разгоне - после 130 - динамика не угасает совершенно (выше тех самых хотя 155 не пробовал). " +
                        "То есть по-другому. Ну и лобовое, нету ощущения, что сидишь в машине.",
                        Img = "https://s.auto.drom.ru/i24231/r/photos/919560/big_1433837.jpg",
                        Available=true, Price=650000,  Category= _carsCategory.AllCategories.First()},
                    new Car { 
                        Id = 2, Name = "Geely Geometry C", 
                        ShortDescr = "Geometry C - вторая модель семейства Geometry, которая позиционируется как чисто электрический кроссовер C-класса. " +
                        "Эта модель унаследовала моду, технологии и динамизм дизайна семейства Geometric.", 
                        LongDescr = "Интерьер Geometry C сочетает в себе футуристические технологии и современный дизайн. Тем не менее, его " +
                        "лаконичный внешний вид полностью укомплектован высококачественным звуком и постоянно обновляемой " +
                        "информационно-развлекательной системой на базе ОС Android. Geometry C наследует концепцию дизайна «многомерного" +
                        " мобильного живого кузова» семейства Geometry и использует мобильность в качестве визуального восприятия, " +
                        "принимая во внимание «многомерность» цвета и пространства, чтобы сформировать текстуру «живого кузова».", 
                        Img = "https://geely-gomel.by/wp-content/uploads/2021/12/glavnoe-foto.jpg", IsFavorite = true, Available = true, Price = 450000, Category = _carsCategory.AllCategories.First() },
                    new Car { 
                        Id = 3, Name = "Audy Q5", 
                        ShortDescr = "The best auto Car", 
                        LongDescr = "Кроссовер Q5 построен на одной платформе с купе А5 и семейством А4. Главное достоинство платформы MLP " +
                        "(Modular Longitudinal Platform) — новая компоновка моторного отсека, которая позволила сдвинуть вперед переднюю ось, " +
                        "а двигатель и коробку передач сместить назад — ближе к центру масс. Это улучшило развесовку автомобиля и увеличило " +
                        "расстояние между передними и задними колесами. Колесная база составляет 2810 мм. С такими данными на заднем диване " +
                        "не тесно даже троим – запаса для ног здесь предостаточно. Кроме того, спинки заднего дивана регулируются по наклону, а за " +
                        "доплату диван можно «научить» передвигаться продольно в пределах 10 см. При поднятых спинках заднего сиденья полезное " +
                        "пространство багажника составляет 540 литров, сложив второй ряд, мы получаем 1560 литров.", 
                        Img = "https://img.salon.av.by/catalog/audi/q5/7e/a/7ea65169.jpeg", IsFavorite = true, Available = true, Price = 450000, Category = _carsCategory.AllCategories.First() }
                    };
            } }
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
