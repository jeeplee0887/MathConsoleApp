using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace MathConsoleApp
{
    class Shape
    {
        public string Name {get; set;}
        public double Perimeter { get; set; }
        public double SurfaceArea { get; set; }

        public void StoreShape()
        {
            var json = JsonSerializer.Serialize(this);
            if (!String.IsNullOrEmpty(json))
            {
                File.WriteAllText(@"c:\test.json", json);
            }
        }
    }
}
