using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.Data.Entities;
using Hackathon.Data.Repository.Interfaces;

namespace Hackathon.Data.Repository
{
  public class HospitalRepository : IHospitalRepository
    {
    private HSEContext _context;

    public HospitalRepository(HSEContext context)
    {
      _context = context;
    }

    public IEnumerable<Hospital> GetAll()
    {
      return _context.Hospitals
                .OrderBy(c => c.name)
                .ToList();
    }

        //public DentalPractice Get(int id)
        //{
        //    return _context.Hospitals
        //      .Where(c => c.Id == id)
        //      .FirstOrDefault();
        //}

    }
}
