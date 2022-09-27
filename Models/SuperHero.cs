namespace APIAplikacija.Models;

public class SuperHero{
  public SuperHero(string? name, string? place, List<string> teams) {
    Name = name;
    Place = place;
    Teams = teams;
  }
  public string? Name { get; set; }
  public string? Place { get; set; }
  public List<string> Teams { get; set; }
}
