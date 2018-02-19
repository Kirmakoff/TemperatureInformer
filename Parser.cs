using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureInformer.Models;
using System.IO;

namespace TemperatureInformer
{
    public class Parser
    {
        string _path;
        private readonly string _parserError = "Parser Error";
        private string _separator = Environment.NewLine;
        private const int _sensorID = 1; //Пока только один датчик :-)
        public Parser(string filePath)
        {
            _path = filePath;
        }

        public List<Measurement> GetAllMeasurements()
        {
            return null;
        }

        public Measurement GetLatestMeasurement(int amount = 0)
        {
            return null;
        }

        public List<Measurement> GetMeasurementSince(DateTime dateTime)
        {
            return null;
        }

        private void ReadFile(string data)
        {
            try
            {
                using (var reader = new StreamReader(_path))
                {
                    data = reader.ReadToEnd();
                }
            }
            catch
            {
                SimpleLogger.Write("Parser Error While Reading File " + DateTime.Now);
                data = _parserError;
            }
        }

        private string[] ParseFile(string data)
        {
            try
            {
                //TODO: дописать
                return null;
                //это всё не актуально, хвала регулярочкам 
                //string[] result = data.Split(new string[] { _separator }, StringSplitOptions.RemoveEmptyEntries);
                //string[] parsed;
                //if (result.Length < 2) throw new Exception("No data to parse");
                ////В первой строке заголовки, поэтому их всегда игнорируем. i = 1 в цикле это не ошибка. 
                //for (int i = 1; i < result.Length; i++)
                //{
                    
                //}
            }
            catch(Exception ex)
            {
                SimpleLogger.Write(ex.Message + " " + DateTime.Now);
                return null;
            }
        }

    }
}
