using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Loosing coupled
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        //Get All Cars
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [Route ("details")]
        [HttpGet]
        public IActionResult GetCarDetail()
        {
            var result = _carService.GetCarDetails();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [Route ("getbyid")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [Route("getbybrand")]
        [HttpGet]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _carService.GetAllByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [Route("delete")]
        [HttpPost]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [Route("update")]
        [HttpPost]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [Route("add")]
        [HttpPost]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
