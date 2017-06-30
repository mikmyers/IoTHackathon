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
  public class GPPracticeRepository : IGPPracticeRepository
    {
    private HSEContext _context;

    public GPPracticeRepository(HSEContext context)
    {
      _context = context;
    }

    public IEnumerable<GPPractice> GetAll()
    {
      return _context.GPPractices
                .OrderBy(c => c.name)
                .ToList();
    }

        //public DentalPractice Get(int id)
        //{
        //    return _context.GPPractices
        //      .Where(c => c.Id == id)
        //      .FirstOrDefault();
        //}

    }
}
