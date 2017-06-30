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
  public class PharmacieRepository : IPharmacieRepository
    {
    private HSEContext _context;

    public PharmacieRepository(HSEContext context)
    {
      _context = context;
    }

    public IEnumerable<Pharmacie> GetAll()
    {
      return _context.Pharmacies
                .OrderBy(c => c.name)
                .ToList();
    }

        //public DentalPractice Get(int id)
        //{
        //    return _context.Pharmacies
        //      .Where(c => c.Id == id)
        //      .FirstOrDefault();
        //}

    }
}
