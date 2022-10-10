using JsonLineToCsv.UIFramework.Models;
using System.Collections.Generic;
using System.IO;

namespace JsonLineToCsv.UIFramework.Workers
{
    public class InputFileConverter
    {
        private readonly string _inputFilePath;

        public InputFileConverter(string inputFilePath)
        {
            _inputFilePath = inputFilePath;
        }

        public List<SourceObject> GetSourceObjects()
        {
            List<SourceObject> sourceObjects = new List<SourceObject>();

            using (var reader = new StreamReader(_inputFilePath))
            {
                string line;
                while (!((line = reader.ReadLine()) is null))
                {
                    SourceObject sourceObject = Newtonsoft.Json.JsonConvert.DeserializeObject<SourceObject>(line);

                    if (sourceObject?.Series_id is null)
                        continue;

                    sourceObjects.Add(sourceObject);
                }
            }

            return sourceObjects;
        }
    }
}
