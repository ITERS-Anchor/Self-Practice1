using ASP.NET_webapi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ASP.NET_webapi.Data
{
    public class CarRepository
    {
        //use Singleton
        
        private CarRepository _instance;

        public CarRepository Instance
        {            
            get {
                if (_instance==null)
                {
                    _instance = new CarRepository();
                }
                return _instance;
            }
            
        }
        private List<CarDto> _carlist;

        private CarRepository()
        {
            _carlist = ProcessCars();
        }

        private List<CarDto> ProcessCars()
        {
            //Reading file get data
            var path = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/fuel.csv");
            var query =
                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(x => x.Length > 1)
                    .ToCarDto();//add extention method

            return query.ToList();
        }
    }
}