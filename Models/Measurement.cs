using System;

namespace TemperatureInformer.Models
{
    public class Measurement
    {
        public int SensorId { get; set; }
        public DateTime MeasurementDate { get; set; }
        public int Value { get; set; }
    }
}
