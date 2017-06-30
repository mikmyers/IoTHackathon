using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hackathon.Data.Entities;
using Hackathon.Data.Repository.Interfaces;

namespace Hackathon.Data.Repository
{
  public class DentalPracticeRepository : IDentalPracticeRepository
  {
    private HSEContext _context;

    public DentalPracticeRepository(HSEContext context)
    {
      _context = context;
    }

    public IEnumerable<DentalPractice> GetAll()
    {
      return _context.DentalPractices
                .OrderBy(c => c.name)
                .ToList();
    }

        //public DentalPractice Get(int id)
        //{
        //    return _context.DentalPractices
        //      .Where(c => c.Id == id)
        //      .FirstOrDefault();
        //}

    }
}
