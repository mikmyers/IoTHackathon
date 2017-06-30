using System.Collections.Generic;
using System.Threading.Tasks;
using Hackathon.Entities;

namespace Hackathon.Repository.Interfaces
{
  public interface IPharmacieRepository
    {

        IEnumerable<Pharmacie> All();
        Pharmacie One(int Id);

    }
}