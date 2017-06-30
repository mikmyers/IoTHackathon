using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Repository.Interfaces;
using Hackathon.Entities;

namespace Hackathon.Repository.Repositories
{
    public partial class PrimaryCareCentreRepository : RepositoryBase<EntityContext>, IPrimaryCareCentreRepository
    {

        public PrimaryCareCentre One(int Id)
        {
            PrimaryCareCentre result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.PrimaryCareCentres
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

        public IEnumerable<PrimaryCareCentre> All()
        {
            IList<PrimaryCareCentre> result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.PrimaryCareCentres
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