using Microsoft.AspNetCore.Mvc;
using Paranoid.Model;
using Paranoid.Service.Interfaces;
using static Paranoid.Model.LocationConfig;

namespace Paranoid
{
    public class RoundController
    {
        IRoundService _roundService;
        public RoundController(IRoundService roundService)
        {
            _roundService = roundService;
        }

        [HttpGet]
        [Route("get/locationConfig")]
        public LocationConfig GetLocationConfig()
        {
            return _roundService.GetLocationConfig();
        }

    }
}
