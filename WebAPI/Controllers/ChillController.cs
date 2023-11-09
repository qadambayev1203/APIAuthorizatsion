using Entities.DTO.Chill;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ChillController : ControllerBase
    {
        private readonly JsonDeserializer desirial;

        public ChillController()
        {
            desirial = new JsonDeserializer();
        }

        // Boshqa API dan ma'lumot olish==========================

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<DailyTaskDTO>> GetDailyTask()
        {
            var client = new RestClient($"http://www.boredapi.com/api/activity/");
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                var result = desirial.Deserialize<DailyTaskDTO>(response);
                return Ok(result);
            }
            return BadRequest("Something wrong with API");
        }

        //========================================================

        [Authorize(Roles ="Admin")]
        [HttpGet("adminText")]
        public string AdminText() 
        {
            return "this is Admin";
        }
    }
}
