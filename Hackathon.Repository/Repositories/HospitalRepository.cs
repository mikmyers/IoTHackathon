using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Repository.Interfaces;
using Hackathon.Entities;

namespace Hackathon.Repository.Repositories
{
    public partial class HospitalRepository : RepositoryBase<EntityContext>, IHospitalRepository
    {

        public Hospital One(int Id)
        {
            Hospital result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.Hospitals
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
        public IEnumerable<Hospital> All()
        {
            IList<Hospital> result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.Hospitals
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