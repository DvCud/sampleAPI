
using apitesting_2.Data;

namespace apitesting_2.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly DataContext _datacontext;

        public SuperHeroService(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<List<SuperHero>> AddSuperHeroes(SuperHero hero)
        {
            await _datacontext.SuperHeroes.AddAsync(hero);
            await _datacontext.SaveChangesAsync();
            return await _datacontext.SuperHeroes.ToListAsync();
        }

        public Task<object?> AddSuperHeroesAsync(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SuperHero>?> DeleteSuperHeroAsync(int id)
        {
            SuperHero? superHero = await _datacontext.SuperHeroes.FindAsync(id);
            if (superHero == null)
                return null;
            _datacontext.SuperHeroes.Remove(superHero);
            await _datacontext.SaveChangesAsync();
            return await _datacontext.SuperHeroes.ToListAsync();
        }

        public Task<SuperHero?> GetSuperHeroByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SuperHero?> GetSuperHeroeByIdAsync(int id)
        {
            SuperHero? superHero = await _datacontext.SuperHeroes.FindAsync(id);
            if (superHero == null)
                return null;
            return superHero;
        }

        public async Task<List<SuperHero>> GetSuperHeroesAsync()
        {
            return await _datacontext.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHero>?> UpdateSuperHeroAsync(int id, SuperHero newHero)
        {
            SuperHero? superHero = await _datacontext.SuperHeroes.FindAsync(id);
            if (superHero == null)
                return null;
            superHero.Name = newHero.Name;
            superHero.FirsttName = newHero.FirsttName;
            superHero.LasttName = newHero.LasttName;
            superHero.Place = newHero.Place;
            await _datacontext.SaveChangesAsync();
            return await _datacontext.SuperHeroes.ToListAsync();
        }

        public Task UpdateSuperHeroesAsync(int id, SuperHero newHero)
        {
            throw new NotImplementedException();
        }

        public Task UpdtaeSuperHeroAsync(int id, SuperHero newHero)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuperHero>> UpdtaeSuperHeroesAsync(int id, SuperHero hero)
        {
            throw new NotImplementedException();
        }
    }
}
