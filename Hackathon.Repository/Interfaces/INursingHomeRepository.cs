using System.Collections.Generic;
using System.Threading.Tasks;
using Hackathon.Entities;

namespace Hackathon.Repository.Interfaces
{
  public interface INursingHomeRepository
    {

        IEnumerable<NursingHome> All();
        NursingHome One(int Id);

    }
}