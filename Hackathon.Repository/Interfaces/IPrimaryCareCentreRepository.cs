using System.Collections.Generic;
using System.Threading.Tasks;
using Hackathon.Entities;

namespace Hackathon.Repository.Interfaces
{
  public interface IPrimaryCareCentreRepository
    {

        IEnumerable<PrimaryCareCentre> All();
        PrimaryCareCentre One(int Id);

    }
}