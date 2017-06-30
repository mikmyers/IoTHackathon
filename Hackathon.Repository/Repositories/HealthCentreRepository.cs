using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Repository.Interfaces;
using Hackathon.Entities;

namespace Hackathon.Repository.Repositories
{
    public partial class HealthCentreRepository : RepositoryBase<EntityContext>, IHealthCentreRepository
    {

        public HealthCentre One(int Id)
        {
            HealthCentre result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.HealthCentres
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

        public IEnumerable<HealthCentre> All()
        {
            IList<HealthCentre> result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.HealthCentres
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