using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using THE_BAKE_MAKE_SHOPWEB.Model;
using THE_BAKE_MAKE_SHOPWEB.Services;

namespace TheBakeMakeShop.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<bakerymenu>Bakerymenu { get; private set; }
        public JsonBakerymenuFile BakerymenuService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonBakerymenuFile bakerymenuService)
        {
            _logger = logger;
            BakerymenuService = bakerymenuService;
        }

        public void OnGet()
        {
             Bakerymenu= BakerymenuService.getBakerymenuData();
        }
    }
}
