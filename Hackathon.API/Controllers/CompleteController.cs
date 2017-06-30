using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hackathon.API.Core;
using Hackathon.Repository.Repositories;
using Hackathon.Entities;

namespace Hackathon.API.Controllers
{
    public class CompleteController : BaseApiController
    {
        DentalPracticeRepository dentalPracticeRepository = null;
        GPPracticeRepository gPPracticeRepository = null;
        HealthCentreRepository healthCentreRepository = null;
        HospitalRepository hospitalRepository = null;
        NursingHomeRepository nursingHomeRepository = null;
        PharmacieRepository pharmacieRepository = null;
        PrimaryCareCentreRepository primaryCareCentreRepository = null;

        string reasonPhase = "Exception";

        public CompleteController()
        {
            dentalPracticeRepository = new DentalPracticeRepository();
            gPPracticeRepository = new GPPracticeRepository();
            healthCentreRepository = new HealthCentreRepository();
            hospitalRepository = new HospitalRepository();
            nursingHomeRepository = new NursingHomeRepository();
            pharmacieRepository = new PharmacieRepository();
            primaryCareCentreRepository = new PrimaryCareCentreRepository();


        }

        private List<Location> AddCollections(List<Location> list1, List<Location> list2)
        {
            List<Location> newResults = new List<Location>(list1.Count + list2.Count);
            newResults.AddRange(list1);
            newResults.AddRange(list2);

            return newResults;
        }

        public IEnumerable<Location> Get()
        {
            List<Location> results = null;
            List<Location> workingResults = null;

            try
            {
                //List<Location> dentalPractices = null;

                results = dentalPracticeRepository.All().Select(x => new Location() { Name = x.Name, Address =x.Address, Eircode = x.Eircode, Id = x.Id, Phone = x.Phone, XCoOrd = x.XCoOrd, YCoOrd = x.YCoOrd  }).ToList();

                workingResults = gPPracticeRepository.All().Select(x => new Location() { Name = x.Name, Address = x.Address, Eircode = x.Eircode, Id = x.Id, Phone = x.Phone, XCoOrd = x.XCoOrd, YCoOrd = x.YCoOrd }).ToList();
                results = AddCollections(results, workingResults);

                workingResults = healthCentreRepository.All().Select(x => new Location() { Name = x.Name, Address = x.Address, Eircode = x.Eircode, Id = x.Id, Phone = x.Phone, XCoOrd = x.XCoOrd, YCoOrd = x.YCoOrd }).ToList();
                results = AddCollections(results, workingResults);

                workingResults = hospitalRepository.All().Select(x => new Location() { Name = x.Name, Address = x.Address, Eircode = x.Eircode, Id = x.Id, Phone = x.Phone, XCoOrd = x.XCoOrd, YCoOrd = x.YCoOrd }).ToList();
                results = AddCollections(results, workingResults);

                workingResults = nursingHomeRepository.All().Select(x => new Location() { Name = x.Name, Address = x.Address, Eircode = x.Eircode, Id = x.Id, Phone = x.Phone, XCoOrd = x.XCoOrd, YCoOrd = x.YCoOrd }).ToList();
                results = AddCollections(results, workingResults);

                workingResults = pharmacieRepository.All().Select(x => new Location() { Name = x.Name, Address = x.Address, Eircode = x.Eircode, Id = x.Id, Phone = x.Phone, XCoOrd = x.XCoOrd, YCoOrd = x.YCoOrd }).ToList();
                results = AddCollections(results, workingResults);

                workingResults = primaryCareCentreRepository.All().Select(x => new Location() { Name = x.Name, Address = x.Address, Eircode = x.Eircode, Id = x.Id, Phone = x.Phone, XCoOrd = x.XCoOrd, YCoOrd = x.YCoOrd }).ToList();
                results = AddCollections(results, workingResults);

            }
            catch (Exception ex)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = reasonPhase
                });
            }
            return results;
        }
    }
}
