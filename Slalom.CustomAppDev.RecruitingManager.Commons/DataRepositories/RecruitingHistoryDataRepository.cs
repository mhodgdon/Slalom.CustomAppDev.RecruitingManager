using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public class RecruitingHistoryDataRepository : IRecruitingHistoryDataRepository
    {
        public IEnumerable<DomainObjects.RecruitingHistory.RecruitingHistoryDomainObject> Retrieve(int id)
        {
            throw new NotImplementedException();
        }
    }
}
