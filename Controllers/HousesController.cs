using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sharpList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _housesService;

        public HousesController(HousesService housesService)
        {
            _housesService = housesService;
        }

        [HttpGet]
        public ActionResult<List<House>> Find()
        {
            try
            {
                List<House> houses = _housesService.find();
                return Ok(houses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}