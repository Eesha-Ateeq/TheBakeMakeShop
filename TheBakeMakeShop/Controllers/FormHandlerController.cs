using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using THE_BAKE_MAKE_SHOPWEB.Model;
using THE_BAKE_MAKE_SHOPWEB.Services;

namespace TheBakeMakeShop.Controllers
{
    [Route("[Controller]")]
    public class FormHandlerController : Controller
    {
        JsonBakerymenuFile BakerymenuService;

        public FormHandlerController(JsonBakerymenuFile bakerymenuservice)
        {
            this.BakerymenuService = bakerymenuservice;
        }

        [HttpGet]
        public string Get(int id, string name, string image)
        {
            bakerymenu obj = new bakerymenu();
            obj.bakerymenu_id = id;
            obj.name = name;
            obj.image = image;

            IEnumerable<bakerymenu> bakerymenuData = BakerymenuService.getBakerymenuData();
            List<bakerymenu> listofbakerymenu = bakerymenuData.ToList();
            listofbakerymenu.Add(obj);

            return JsonSerializer.Serialize<List<bakerymenu>>(listofbakerymenu);
        }

    }
}
