namespace APIAplikacija.Models;

public class SuperHeroService : ISuperHeroService {
  public SuperHeroService() {
    SuperHeros = new List<SuperHero>();
    SuperHeros.AddRange(
      new SuperHero[] {
        new SuperHero("SpiderM+man", "NewYork", new List<string>()),
        new SuperHero("Betman", "Arkam", new List<string>())
      }
    );
  }

/*
  SuperHero GetSuperHero(string place);
  void AddSuperHero(SuperHero superHero);
*/

  public IEnumerable<SuperHero> GetSuperHeroes() {
    return SuperHeros;
  }

  public void AddSuperHero(SuperHero SuperHero) {
    SuperHeros.Add(SuperHero);
  }

  public SuperHero GetSuperHero(string place) {
    var SuperHero = from c in SuperHeros
      where c.Place == place
      select c;
    if (SuperHero.ToList().Count == 1) {
      return SuperHero.First();
    } else {
      return null;
    }
  }

  private List<SuperHero> SuperHeros;
}