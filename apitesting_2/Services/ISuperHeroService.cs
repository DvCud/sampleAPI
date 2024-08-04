namespace apitesting_2.Services
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetSuperHeroesAsync();
        Task<SuperHero?> GetSuperHeroeByIdAsync(int id);
        Task<List<SuperHero>> UpdtaeSuperHeroesAsync(int id, SuperHero hero);
        Task<List<SuperHero>?> UpdateSuperHeroAsync(int id, SuperHero newHero);
        Task<List<SuperHero>?> DeleteSuperHeroAsync(int id);
        Task<SuperHero?> GetSuperHeroByIdAsync(int id);
        Task<object?> AddSuperHeroesAsync(SuperHero hero);
        Task UpdtaeSuperHeroAsync(int id, SuperHero newHero);
        Task UpdateSuperHeroesAsync(int id, SuperHero newHero);
    }
}
