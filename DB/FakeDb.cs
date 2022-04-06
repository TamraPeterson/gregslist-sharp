using gregslist_sharp.models;

namespace gregslist_sharp.DB;

public static class FakeDb
{
  public static List<Car> Cars { get; set; } = new List<Car>() {
      new Car("Toyota", "Sienna", 2006),
      new Car("Ford", "Explorer", 2015)
     };
}