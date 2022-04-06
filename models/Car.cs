using System.ComponentModel.DataAnnotations;


namespace gregslist_sharp.models
{
  public class Car
  {
    public string Id { get; set; }
    public string? Model { get; set; }

    [Required]
    public string Make { get; set; }

    [Range(1950, 2022)]
    public int? Year { get; set; }

    public Car()
    {
      Id = Guid.NewGuid().ToString();
    }
    public Car(string make, string? model, int? year)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
    }
  }

}