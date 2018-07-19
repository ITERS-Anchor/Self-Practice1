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
    public class CitiesController : ApiController
    {
        // GET: api/Cities
        public IEnumerable<CityDto> Get()
        {
            return CityRepository.Instance.GetAll();
        }

        // GET: api/Cities/5
        public CityDto Get(int id)
        {
            return CityRepository.Instance.GetById(id);
        }

        // POST: api/Cities
        public CityDto Post(CityDto city)
        {
            
            CityRepository.Instance.Add(city);
            return city;
        }

        // PUT: api/Cities/5
        public IEnumerable<CityDto> Put(int id, CityDto c)
        {
            c.Id = id;
            if (CityRepository.Instance.Update(c))
            {
                return CityRepository.Instance.GetAll();
            }
            else
            {
                return null;
            }
        }

        // DELETE: api/Cities/5
        public bool Delete(int id)
        {
            return CityRepository.Instance.Delete(id);
        }
    }
}
