using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using THE_BAKE_MAKE_SHOPWEB.Model;

namespace THE_BAKE_MAKE_SHOPWEB.Services
{
    public class JsonBakerymenuFile
    {
        public JsonBakerymenuFile(IWebHostEnvironment webHostEnvironment)
        {

            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "bakerymenu.json");
            }
        }

        public IEnumerable<bakerymenu> getBakerymenuData()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<bakerymenu[]>(json_file.ReadToEnd());
            }
        }
    }
}