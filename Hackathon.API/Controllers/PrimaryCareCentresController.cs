﻿using System;
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
    public class PrimaryCareCentresController : BaseApiController
    {
        PrimaryCareCentreRepository repository = null;
        string reasonPhase = "Exception";

        public PrimaryCareCentresController()
        {
            repository = new PrimaryCareCentreRepository();
        }

        public PrimaryCareCentre GetById(int Id)
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

        public IEnumerable<PrimaryCareCentre> Get()
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
