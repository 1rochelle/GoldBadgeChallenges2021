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
        public void AddClaimToList_ShouldAddClaim()
        {
            //can't seem to seed DateTime values***************
            Claims newClaim = new Claims(1, Car, "in auto accident", 32.01, 8/31/2009 10:03:29 AM, 9/5/2009 9:51:37 PM);
            ClaimsRepo _claimsTest = new ClaimsRepo();
            bool addResult = _claimsTest.AddClaimToList(newClaim);           
        }
        //Here's some private fields
        private ClaimsRepo _claimsTest;
        private Claims _newClaimOne;
        private Claims _newClaimTwo;
    }
}
