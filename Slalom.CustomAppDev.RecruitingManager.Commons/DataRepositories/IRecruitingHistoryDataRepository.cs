using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public interface IRecruitingHistoryDataRepository
    {
        IEnumerable<DomainObjects.RecruitingHistory.RecruitingHistoryDomainObject> Retrieve(int id);
    }
}
