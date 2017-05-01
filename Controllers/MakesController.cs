using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vega.Models;

namespace Vega.Controllers
{
    public class MakesController :  Controller
    {
        [HttpGet("/api/makes")]
        public IEnumerable<Make> GetMakes()
    }
}