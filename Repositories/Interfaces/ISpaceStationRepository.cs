using SoftUniSpaceConsoleWebApp.Data.Entities;

using SoftUniSpaceConsoleWebApp.Models.SpaceStation;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ISpaceStationRepository
    {

        void Add(SpaceStation spaceStation);

        IEnumerable<SpaceStation> GetAll();

        void Delete(int id);

        SpaceStation Get(int id);
            




      //  void Add(Crew crew);
      //
      //  IEnumerable<Crew> GetAll(); //138
      //
      //  // void Delete(Crew crew);
      //  void Delete(int id);
      //
      //  CrewViewModel Get(int id);



    }
}
