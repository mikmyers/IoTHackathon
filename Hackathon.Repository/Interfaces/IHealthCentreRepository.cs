using System.Collections.Generic;
using System.Threading.Tasks;
using Hackathon.Entities;

namespace Hackathon.Repository.Interfaces
{
  public interface IHealthCentreRepository
    {

        IEnumerable<HealthCentre> All();
        HealthCentre One(int Id);

    }
}