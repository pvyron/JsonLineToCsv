using JsonLineToCsv.UIFramework.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonLineToCsv.UIFramework.Workers
{
    public static class Converter
    {
        public static OutputObject ToOutputObject(this SourceObject sourceObject)
        {
            OutputObject outputObject = new OutputObject()
            {
                SeriesId = sourceObject.Series_id,
                Name = sourceObject.Name,
                Units = sourceObject.Units,
                LastUpdate = sourceObject.Last_Updated
            };

            foreach (var token in sourceObject.Data)
            {
                try
                {
                    OutputObjectLine outputObjectLine = GetLineFromToken(token);

                    outputObject.Lines.Add(outputObjectLine);
                }
                catch (Exception ex)
                {

                }
            }

            return outputObject;
        }

        private static OutputObjectLine GetLineFromToken(JToken token)
        {
            DateTime? period;

            if (token[0] is null)
            {
                period = null;
            }
            else if (DateTime.TryParseExact(token[0].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime periodOut))
            {
                period = periodOut;
            }
            else if (DateTime.TryParseExact(token[0].ToString(), "yyyyMM", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out periodOut))
            {
                period = periodOut;
            }
            else if (token[0].ToString().Contains("Q"))
            {
                period = DateTime.ParseExact(token[0].ToString().Substring(0, 4), "yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                period = DateTime.ParseExact(token[0].ToString(), "yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            double? value = (double?)token[1];

            OutputObjectLine outputObjectLine = new OutputObjectLine()
            {
                Period = period,
                Value = value
            };
            return outputObjectLine;
        }

        public static List<CsvLine> GetCsvLines(this OutputObject outputObject)
        {
            List<CsvLine> csvLines = new List<CsvLine>();

            foreach (var line in outputObject.Lines)
            {
                CsvLine csvLine = new CsvLine()
                {
                    series_id = outputObject.SeriesId,
                    name = outputObject.Name,
                    units = outputObject.Units,
                    updated = outputObject.LastUpdate.ToString("MM/dd/yyyy"),
                    Period = line.Period?.ToString("MM/dd/yyyy") ?? "",
                    Value = line.Value?.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-GB")) ?? ""
                };

                csvLines.Add(csvLine);
            }

            return csvLines;
        }

        public static void SaveAs(this List<CsvLine> csvLines, string fullPath)
        {
            if (!Directory.Exists(Path.GetFullPath(fullPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
            }

            File.WriteAllText(fullPath, string.Join(Environment.NewLine, csvLines));
        }
    }
}
