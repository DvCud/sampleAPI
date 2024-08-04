using apitesting_2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apitesting_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            this._superHeroService = superHeroService;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return Ok(await _superHeroService.GetSuperHeroesAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroeById(int id)
        {
            SuperHero? superHero = await _superHeroService.GetSuperHeroByIdAsync(id);
            if (superHero == null)
                return NotFound("SuperHero not found for this id");
            return Ok(superHero);
        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddSuperHeroes(SuperHero hero)
        {
            return Ok(await _superHeroService.AddSuperHeroesAsync(hero));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateSuperHero(int id, SuperHero newHero)
        {
            var heroes = await _superHeroService.UpdateSuperHeroAsync(id, newHero);
            if (heroes == null)
                return NotFound("SuperHero not found for this id");
            return Ok(heroes);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteSuperHero(int id)
        {
            var heroes = await _superHeroService.DeleteSuperHeroAsync(id);
            if (heroes == null)
                return NotFound("SuperHero not found for this id");
            return Ok(heroes);
        }
    }
}
