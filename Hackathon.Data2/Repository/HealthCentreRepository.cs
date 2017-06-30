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
  public class HealthCentreRepository : IHealthCentreRepository
    {
    private HSEContext _context;

    public HealthCentreRepository(HSEContext context)
    {
      _context = context;
    }

    public IEnumerable<HealthCentre> GetAll()
    {
      return _context.HealthCentres
                .OrderBy(c => c.name)
                .ToList();
    }

        //public DentalPractice Get(int id)
        //{
        //    return _context.HealthCentres
        //      .Where(c => c.Id == id)
        //      .FirstOrDefault();
        //}

    }
}
