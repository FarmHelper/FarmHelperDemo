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
            Transfer output = new Transfer(Champ.best(plant.pamant, plant.umiditate, plant.umiditate));
            return Ok();
        }

    }
}
