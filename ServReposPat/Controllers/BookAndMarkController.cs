using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServReposPat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServReposPat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAndMarkController : ControllerBase
    {
        private readonly IBookAndMarkService _bookAndMarkService;

        public BookAndMarkController(IBookAndMarkService bams)
        {
            _bookAndMarkService = bams;
        }

        [HttpGet]
        public BookAndMark GetBookAndMark()
        {
            return _bookAndMarkService.GetBookAndMark();
        }
    }
}
