﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories
{
    public interface ICompetencyDataRepository
    {
        void RetrieveCompetency(int id, DomainObjects.Competency.CompetencyArea area);

        void UpdateCompetency(int id, DomainObjects.Competency.CompetencyDomainObject UpdateCompetency);
    }
}