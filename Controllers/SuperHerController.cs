using Microsoft.AspNetCore.Mvc;
using System.Collections;
using APIAplikacija.Models;

namespace ConfApp.Controllers;

[Route("api/[controller]")]
public class SuperHerosController : ControllerBase {

  private readonly ISuperHeroService SuperHeroService;

  public SuperHerosController(ISuperHeroService SuperHeroService) {
    this.SuperHeroService = SuperHeroService;
  }

  [HttpGet]
  public IActionResult GetSuperHeros() {
    try {
      IEnumerable results = SuperHeroService.GetSuperHeroes();
      return Ok(results);
    } catch (Exception) {
      return StatusCode(StatusCodes.Status500InternalServerError, "Error while retrieving data");
    }
  }

  [HttpGet("{place}")]
  public ActionResult<SuperHero> Get(string place) {
    var SuperHero = SuperHeroService.GetSuperHero(place);
    if (SuperHero != null) {
      return Ok(SuperHero);
    } else {
      return NotFound("Can't find it");
    }
  }

  [HttpPost]
  public IActionResult Post(string title, string place) {
    var SuperHero = new SuperHero(title, place, new List<string>());
    SuperHeroService.AddSuperHero(SuperHero);
    return Created("/1", SuperHero);
  }
}
