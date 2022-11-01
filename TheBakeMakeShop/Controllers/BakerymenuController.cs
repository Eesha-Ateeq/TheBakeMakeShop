using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using THE_BAKE_MAKE_SHOPWEB.Model;
using THE_BAKE_MAKE_SHOPWEB.Services;

namespace TheBakeMakeShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BakerymenuController : ControllerBase
    {

        JsonBakerymenuFile BakerymenuService { get; }
        public BakerymenuController(JsonBakerymenuFile bakerymenuservice)
        {
            this.BakerymenuService = bakerymenuservice;
        }

        public IEnumerable<bakerymenu> Get()
        {
            return BakerymenuService.getBakerymenuData();
        }
    }
}

