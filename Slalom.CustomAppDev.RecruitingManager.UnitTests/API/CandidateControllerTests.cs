using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slalom.CustomAppDev.RecruitingManager.API.Controllers;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Candidate;
using Moq;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataRepositories;

namespace Slalom.CustomAppDev.RecruitingManager.UnitTests.API
{
    [TestClass]
    public class CandidateControllerTests
    {
        #region Fields
        
        private CandidateController candidateController;
        private Mock<ICandidateDataRepository> mockedCandidatedDataRepository;
        private Mock<ICompetencyDataRepository> mockedCompetencyDataRepository;
        private List<CandidateDomainObject> manyCandidates;
        private List<CandidateDomainObject> nullCandidates;
        private List<CandidateDomainObject> emptyCandidate;
        private CandidateDomainObject candidateObject;

        #endregion

        #region Setup / Teardown

        [TestInitialize]
        public void Setup()
        {
            mockedCandidatedDataRepository = new Mock<ICandidateDataRepository>();
            mockedCompetencyDataRepository = new Mock<ICompetencyDataRepository>();
            candidateController = new CandidateController(mockedCandidatedDataRepository.Object, mockedCompetencyDataRepository.Object);

            candidateObject = new CandidateDomainObject()
            {
                FirstName = "test",
                LastName = "user",
                Id = 1,
                EmailAddress = "tuser@slalom.com",
                HireCandidate = true,
                InterviewComplete = true,
                ResumeAddress = new Uri("http://resume.com/tuser")
            };

            manyCandidates = new List<CandidateDomainObject>()
            {
                new CandidateDomainObject() { Id = 99 },
                new CandidateDomainObject() { Id = 101 }
            };

            emptyCandidate = new List<CandidateDomainObject>();

            nullCandidates = null;
        }

        [TestCleanup]
        public void Teardown()
        {
            candidateController = null;
            mockedCandidatedDataRepository = null;
        }

        #endregion

        #region Get Test Methods

        [TestMethod]
        public void GetTestReturnsResults()
        {
            mockedCandidatedDataRepository.Setup(mock => mock.RetrieveAllCandidates()).Returns(manyCandidates);

            IEnumerable<CandidateDomainObject> candidates = candidateController.Get();

            mockedCandidatedDataRepository.Verify(mock => mock.RetrieveAllCandidates());
        }

        [TestMethod]
        public void GetTestReturnsNullResults()
        {
            mockedCandidatedDataRepository.Setup(mock => mock.RetrieveAllCandidates()).Returns(nullCandidates);

            IEnumerable<CandidateDomainObject> candidates = candidateController.Get();

            mockedCandidatedDataRepository.Verify(mock => mock.RetrieveAllCandidates());
        }

        [TestMethod]
        public void GetTestReturnsEmptyResults()
        {
            mockedCandidatedDataRepository.Setup(mock => mock.RetrieveAllCandidates()).Returns(emptyCandidate);

            IEnumerable<CandidateDomainObject> candidates = candidateController.Get();

            mockedCandidatedDataRepository.Verify(mock => mock.RetrieveAllCandidates());
        }

        #endregion

        #region Get(int) Test Methods

        [TestMethod]
        public void GetReturnsResponseFromGoodId()
        {
            mockedCandidatedDataRepository.Setup(mock => mock.RetrieveCandidate(candidateObject.Id)).Returns(candidateObject);

            CandidateDomainObject candidate = candidateController.Get(candidateObject.Id);

            mockedCandidatedDataRepository.Verify(mock => mock.RetrieveCandidate(candidateObject.Id));
        }

        [TestMethod]
        public void GetReturnsEmptyObjectFromBadId()
        {
            candidateObject = new CandidateDomainObject() { FirstName = "UNDEFINED USER", LastName = "UNDEFINED USER", Id = 52 };

            mockedCandidatedDataRepository.Setup(mock => mock.RetrieveCandidate(candidateObject.Id)).Returns(candidateObject);

            CandidateDomainObject candidate = candidateController.Get(candidateObject.Id);

            mockedCandidatedDataRepository.Verify(mock => mock.RetrieveCandidate(candidateObject.Id));
        }

        #endregion

        #region Put Test Methods

        [TestMethod]
        public void PutExecutesWithValidCandidateObject()
        {
            mockedCandidatedDataRepository.Setup(mock => mock.CreateCandidate(candidateObject));

            candidateController.Put(candidateObject);

            mockedCandidatedDataRepository.Verify(mock => mock.CreateCandidate(candidateObject));
       
        }

        [TestMethod]
        public void PutExecutesWithInvalidCandidateObject()
        {
            candidateObject = null;

            mockedCandidatedDataRepository.Setup(mock => mock.CreateCandidate(candidateObject));

            candidateController.Put(candidateObject);

            mockedCandidatedDataRepository.Verify(mock => mock.CreateCandidate(candidateObject));
        }


        #endregion
    }
}
