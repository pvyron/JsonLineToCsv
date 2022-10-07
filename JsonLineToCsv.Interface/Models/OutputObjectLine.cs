using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLineToCsv.Interface.Models
{
    public class OutputObjectLine
    {
        /// <summary>
        /// Period
        /// </summary>
        public DateTime? Period { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public double? Value { get; set; }
    }
}
