using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Repository.Interfaces;
using Hackathon.Entities;

namespace Hackathon.Repository.Repositories
{
    public partial class GPPracticeRepository : RepositoryBase<EntityContext>, IGPPracticeRepository
    {

        public GPPractice One(int Id)
        {
            GPPractice result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.GPPractices
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

        public IEnumerable<GPPractice> All()
        {
            IList<GPPractice> result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.GPPractices
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