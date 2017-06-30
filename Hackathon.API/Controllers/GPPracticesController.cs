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
    public class GPPracticesController : BaseApiController
    {
        GPPracticeRepository repository = null;
        string reasonPhase = "Exception";

        public GPPracticesController()
        {
            repository = new GPPracticeRepository();
        }

        public GPPractice GetById(int Id)
        {
            try
            {
                return repository.One(Id);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = reasonPhase
                });
            }
        }

        public IEnumerable<GPPractice> Get()
        {
            try
            {
                return repository.All();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = reasonPhase
                });
            }
        }
    }
}
