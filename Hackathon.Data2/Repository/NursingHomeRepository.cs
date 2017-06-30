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
  public class NursingHomeRepository : INursingHomeRepository
    {
    private HSEContext _context;

    public NursingHomeRepository(HSEContext context)
    {
      _context = context;
    }

    public IEnumerable<NursingHome> GetAll()
    {
      return _context.NursingHomes
                .OrderBy(c => c.name)
                .ToList();
    }

        //public DentalPractice Get(int id)
        //{
        //    return _context.NursingHomes
        //      .Where(c => c.Id == id)
        //      .FirstOrDefault();
        //}

    }
}
