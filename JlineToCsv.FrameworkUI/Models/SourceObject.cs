using Newtonsoft.Json.Linq;
using System;

namespace JsonLineToCsv.UIFramework.Models
{
    public class SourceObject
    {
        public string Series_id { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public string F { get; set; }
        public string UnitsShort { get; set; }
        public string Description { get; set; }
        public string Copyright { get; set; }
        public string Source { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public DateTime Last_Updated { get; set; }
        public JToken[] Data { get; set; }
    }
}
