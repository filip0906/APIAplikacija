namespace APIAplikacija.Models;

public interface ISuperHeroService {
  IEnumerable<SuperHero> GetSuperHeroes();
  SuperHero GetSuperHero(string place);
  void AddSuperHero(SuperHero superHero);
}