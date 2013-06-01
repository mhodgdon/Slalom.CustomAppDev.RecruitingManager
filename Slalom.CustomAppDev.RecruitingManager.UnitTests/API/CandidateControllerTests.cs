using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slalom.CustomAppDev.RecruitingManager.API.Controllers;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;

namespace Slalom.CustomAppDev.RecruitingManager.UnitTests.API
{
    [TestClass]
    public class CandidateControllerTests
    {
        #region Fields
        
        private CandidateController candidateController = null;

        #endregion

        #region Setup / Teardown

        [TestInitialize]
        public void Setup()
        {
            candidateController = new CandidateController();
        }

        [TestCleanup]
        public void Teardown()
        {
            candidateController = null;
        }

        #endregion

        #region Test Methods

        [TestMethod]
        public void GetTestReturnsResults()
        {
            IEnumerable<CandidateDomainObject> candidates = candidateController.Get();

            Assert.IsNotNull(candidates);

            Assert.IsTrue(candidates.Count() > 0);
        }


        [TestMethod]
        public void GetTestReturnsNullResults()
        {
            IEnumerable<CandidateDomainObject> candidates = candidateController.Get();

            Assert.IsNull(candidates);

        }

        [TestMethod]
        public void GetTestReturnsEmptyResults()
        {
            IEnumerable<CandidateDomainObject> candidates = candidateController.Get();

            Assert.IsNotNull(candidates);

            Assert.IsTrue(candidates.Count() == 0);
        }

        #endregion
    }
}
