using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Repository.Interfaces;
using Hackathon.Entities;

namespace Hackathon.Repository.Repositories
{
    public partial class NursingHomeRepository : RepositoryBase<EntityContext>, INursingHomeRepository
    {

        public NursingHome One(int Id)
        {
            NursingHome result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.NursingHomes
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

        public IEnumerable<NursingHome> All()
        {
            IList<NursingHome> result = null;

            try
            {
                using (var context = DataContext)
                {
                    result = context.NursingHomes
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