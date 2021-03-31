using ChallengeTwoClaimsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoClaimsConsoleApp
{
    class ProgramUI
    {
        private readonly ClaimsRepo _claimsRepo = new ClaimsRepo();
        public void Run()
        {
            SeedClaimsList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Komodo Insurance Claims: \n" +
                    "1. See all claims \n" +
                    "2. Take care of next claim \n" +
                    "3. Enter a new claim" +
                    "4. Exit application");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid response between 1 and 4 \n" +
                            "Press any key to continue........");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void SeeAllClaims()
        {
            Console.Clear();
            List<Claims> listOfClaims = _claimsRepo.GetEntireList();
            foreach (Claims individualClaim in listOfClaims)
            {
                DisplayList(listOfClaims);
            }
        }
        private void DisplayList(Claims eachClaim)
        {
            //going to need some work to look like the instructions****************
            Console.WriteLine($"Claim ID: {eachClaim.ClaimID}\n" +
                                $"Claim Type: {eachClaim.ClaimType}\n" +
                                $"Description: {eachClaim.Description}\n" +
                                $"Claim Amount: {eachClaim.ClaimAmount}\n" +
                                $"Date of Incident: {eachClaim.DateOfIncident}\n" +
                                $"Date of Claim: {eachClaim.DateOfClaim}\n");
        }
        private void SeedClaimsList()
        {
            Claims stolenYappyDog = new Claims(1, Theft, "dog stolen from backyard", 1000.00, 6 / 5 / 19, 7 / 1 / 19);
            Claims beaterGotBeat = new Claims(2, Car, "beater car ran over nail", 500.00, 2 / 8 / 21, 2 / 15 / 21);
            Claims wallpaperExplosion = new Claims(3, Home, "wallpaper, glue, walls... there was an explosion", 5000.00, 1 / 1 / 20, 2 / 3 / 30);

            _claimsRepo.AddClaimToList(stolenYappyDog);
            _claimsRepo.AddClaimToList(beaterGotBeat);
            _claimsRepo.AddClaimToList(wallpaperExplosion);

        }
    }
}
