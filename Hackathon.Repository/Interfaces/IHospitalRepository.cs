using System.Collections.Generic;
using System.Threading.Tasks;
using Hackathon.Entities;

namespace Hackathon.Repository.Interfaces
{
  public interface IHospitalRepository
    {

        IEnumerable<Hospital> All();
        Hospital One(int Id);

    }
}