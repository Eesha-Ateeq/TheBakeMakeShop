using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using THE_BAKE_MAKE_SHOPWEB.Model;
using THE_BAKE_MAKE_SHOPWEB.Services;

namespace TheBakeMakeShop.Pages
{
    public class BakerymenuListModel : PageModel
    {
        JsonBakerymenuFile BakerymenuService;
        public IEnumerable<bakerymenu> Bakerymenu;

        public BakerymenuListModel(JsonBakerymenuFile bakerymenuservice)
        {
            this.BakerymenuService = bakerymenuservice;
        }
        public void OnGet()
        {
            Bakerymenu = BakerymenuService.getBakerymenuData();
        }
    }
}
