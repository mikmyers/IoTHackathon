using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Repository.Interfaces;
using Hackathon.Entities;

namespace Hackathon.Repository.Repositories
{
    public partial class PharmacieRepository : RepositoryBase<EntityContext>, IPharmacieRepository
    {

        public Pharmacie One(int Id)
        {
            Pharmacie result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.Pharmacies
                    .Where(a => a.Id == Id)
                    .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public IEnumerable<Pharmacie> All()
        {
            IList<Pharmacie> result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.Pharmacies
                              .OrderBy(c => c.Name)
                              .ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

    }
}