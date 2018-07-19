using ASP.NET_webapi.Data;
using ASP.NET_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_webapi.Controllers
{
    public class CarsController : ApiController
    {
        
        public IHttpActionResult Get()
        {
            CarRepository instance =CarRepository.Instance;
            List<CarDto> cars=instance.GetAll();
            return Ok();
        }
        public IHttpActionResult Get(int id)
        {           
            return Ok(CarRepository.Instance.GetById(id));
        }
    }
}
