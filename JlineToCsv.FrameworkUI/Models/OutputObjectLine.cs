using System;

namespace JsonLineToCsv.UIFramework.Models
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
