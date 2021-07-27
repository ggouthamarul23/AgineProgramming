using System;
using System.Collections.Generic;
using System.Text;

namespace Agnie.Domain
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Data
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }

    }
    public class Magazine
    {
        public List<Data> data { get; set; }
        public bool success { get; set; }
        public string token { get; set; }



    }
}