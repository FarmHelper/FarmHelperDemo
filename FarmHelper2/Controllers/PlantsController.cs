using FarmHelper2.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmHelper2.Controllers
{
    public class PlantsController : ApiController
    {

        public IHttpActionResult Post(Parcela plant)
        {
            return Ok();
        }

    }
}
