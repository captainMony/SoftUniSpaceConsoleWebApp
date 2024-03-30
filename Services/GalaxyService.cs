
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SoftUniSpaceConsoleWebApp.Data.Entities;

using SoftUniSpaceConsoleWebApp.Models.Galaxy;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class GalaxyService : IGalaxyService
    {
        private readonly IGalaxyReposiotry galaxyReposiotry;

        public GalaxyService(IGalaxyReposiotry galaxyReposiotry)
        {
            this.galaxyReposiotry = galaxyReposiotry;
        }

        public void Add(CreateGalaxyViewModel galaxy)
        {
            var GalaxyEntity = new Galaxy(galaxy.Name,galaxy.Color,galaxy.UniverseGroup); //Gen ctor in Entities maybe be fix for SolarSystem
            galaxyReposiotry.Add(GalaxyEntity);

        }

        public IEnumerable<GalaxyViewModel> GetAll()
        {
            var GalaxyEntities = galaxyReposiotry.GetAll();
            var galaxy = GalaxyEntities.Select(G => new GalaxyViewModel(G.Id,G.Name,G.Color,G.UniverseGroup));
            return galaxy; // if red wrong viewmodels... must be same duh!

        }
        public void Delete(int id)
            => galaxyReposiotry.Delete(id);

        public GalaxyViewModel Get(int id)
        {
            var galaxyId = galaxyReposiotry.Get(id);
                return new GalaxyViewModel(id); //MAKE CONSTRUCTOR WITH ID ONLY
        }

        
    }




}

