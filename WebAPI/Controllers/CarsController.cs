using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public List<Car> Get()
        {
            return new List<Car>
            {
                new Car{Id=12, Description="Mini"},
                new Car{Id=18, Description="Porsche"},
            };
        }
    }
}
