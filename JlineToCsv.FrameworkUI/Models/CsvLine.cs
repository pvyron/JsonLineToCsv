namespace JsonLineToCsv.UIFramework.Models
{
    public class CsvLine
    {
        public string series_id { get; set; }
        public string name { get; set; }
        public string units { get; set; }
        public string updated { get; set; }
        public string Period { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{series_id},{name},{units},{updated},{Period},{Value}";
        }
    }
}
