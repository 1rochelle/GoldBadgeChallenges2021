using ChallengeTwoClaimsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeTwoClaimsUnitTest
{
    [TestClass]
    public class ClaimsUnitTest
    {
        //Testing the Create method
        [TestMethod]
        public void AddClaimToQueue_ShouldAddClaim()
        {
            //can't seem to seed DateTime values***************
            Claims newClaim = new Claims(1, ClaimType.Car, "in auto accident", 32.01, new DateTime(2009,2,1), new DateTime(2009,9,5));
            ClaimsRepo _claimsTest = new ClaimsRepo();
            bool addResult = _claimsTest.AddClaimToQueue(newClaim);
            Assert.IsTrue(addResult);
        }
        //Here's some private fields
        private ClaimsRepo _claimsTest;
        private Claims _newClaimOne;
        private Claims _newClaimTwo;
    }
}
