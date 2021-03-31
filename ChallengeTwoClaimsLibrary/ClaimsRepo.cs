using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoClaimsLibrary
{
    public class ClaimsRepo
    {
        protected readonly List<Claims> _currentClaims = new List<Claims>();
        
        //Create new claim
        public bool AddClaimToList(Claims newClaim)
        {
            int startingCount = _currentClaims.Count;
            _currentClaims.Add(newClaim);
            bool wasAdded = (_currentClaims.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read all claims
        public List<Claims> GetEntireList()
        {
            return _currentClaims;
        }

        //Update, no update needed
        //Delete a claim from the list
        public bool DeleteClaim(Claims existingClaim)
        {
            bool removeClaim = _currentClaims.Remove(existingClaim);
            return removeClaim;
        }
    }
}
