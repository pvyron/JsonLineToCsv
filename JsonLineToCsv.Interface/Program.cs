using JsonLineToCsv.Interface.Models;
using JsonLineToCsv.Interface.Workers;

namespace JsonLineToCsv.Interface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = @"E:\pvyro\Downloads\Chris Liakopoulos\NG.txt";

            List<SourceObject> sourceObjects = new InputFileConverter(path).GetSourceObjects();
            List<OutputObject> outputObjects = sourceObjects.Select(o => o.ToOutputObject()).ToList();
            List<CsvLine> csvLines = outputObjects.SelectMany(o => o.GetCsvLines()).ToList();
            csvLines.SaveAs(@"E:\pvyro\Downloads\Chris Liakopoulos\output.csv");

            Console.WriteLine("Done");
            Console.ReadLine();
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}