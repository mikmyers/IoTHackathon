using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Repository.Interfaces;
using Hackathon.Entities;

namespace Hackathon.Repository.Repositories
{
    public partial class DentalPracticeRepository : RepositoryBase<EntityContext>, IDentalPracticeRepository
    {

        public DentalPractice One(int Id)
        {
            DentalPractice result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.DentalPractices
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

        public IEnumerable<DentalPractice> All()
        {
            IList<DentalPractice> result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.DentalPractices
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