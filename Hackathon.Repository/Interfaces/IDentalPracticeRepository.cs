using System.Collections.Generic;
using System.Threading.Tasks;
using Hackathon.Entities;

namespace Hackathon.Repository.Interfaces
{
  public interface IDentalPracticeRepository
  {
        IEnumerable<DentalPractice> All();

        DentalPractice One(int Id);

    }
}