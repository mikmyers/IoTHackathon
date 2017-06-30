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
  public class PrimaryCareCentreRepository : IPrimaryCareCentreRepository
    {
    private HSEContext _context;

    public PrimaryCareCentreRepository(HSEContext context)
    {
      _context = context;
    }

    public IEnumerable<PrimaryCareCentre> GetAll()
    {
      return _context.PrimaryCareCentres
                .OrderBy(c => c.name)
                .ToList();
    }

        //public DentalPractice Get(int id)
        //{
        //    return _context.PrimaryCareCentres
        //      .Where(c => c.Id == id)
        //      .FirstOrDefault();
        //}

    }
}
