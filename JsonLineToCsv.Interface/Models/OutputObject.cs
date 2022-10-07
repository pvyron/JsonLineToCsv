using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLineToCsv.Interface.Models
{
    public class OutputObject
    {
        public OutputObject()
        {
            Lines = new();
        }

        /// <summary>
        /// series_id
        /// </summary>
        public string SeriesId { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// units
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// updated
        /// </summary>
        public DateTime LastUpdate { get; set; }


        public List<OutputObjectLine> Lines { get; set; }
    }
}
