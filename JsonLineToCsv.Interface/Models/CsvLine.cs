using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLineToCsv.Interface.Models
{
    public class CsvLine
    {
        public string series_id { get; set; } = null!;
        public string name { get; set; } = null!;
        public string units { get; set; } = null!;
        public string updated { get; set; } = null!;
        public string Period { get; set; } = null!;
        public string Value { get; set; } = null!;

        public override string ToString()
        {
            return $"{series_id},{name},{units},{updated},{Period},{Value}";
        }
    }
}
