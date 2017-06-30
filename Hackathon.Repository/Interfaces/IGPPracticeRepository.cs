using System.Collections.Generic;
using System.Threading.Tasks;
using Hackathon.Entities;

namespace Hackathon.Repository.Interfaces
{
  public interface IGPPracticeRepository
    {

        IEnumerable<GPPractice> All();
        GPPractice One(int Id);

    }
}