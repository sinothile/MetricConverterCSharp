using System;
using MetricConverterKata.Model;

namespace MetricConverterKata
{
    public class MetricConverter
    {
        private double converter;
        public double ConvertKilometersToMiles(MetricConverterModel _metricConverter)
        {
            converter = (_metricConverter.Kilometers* 0.621371);
            return converter;
        }

        public double ConvertCelsiusToFahrenheit(MetricConverterModel _metricConverter)
        {
            converter = (_metricConverter.Celsius * 1.8) + 32;
            return converter;
        }

        public double ConvertKilogramToPounds(MetricConverterModel _metricConverter)
        {
            converter = (_metricConverter.Kilogram / 0.45359237);
            return converter;
        }

        public double ConvertLitersToGallons(MetricConverterModel _metricConverter)
        {
            _metricConverter.TargetUnit = _metricConverter.TargetUnit.ToUpper();

            if (TargetUnitEqualsToUS(_metricConverter))
            {
                converter = _metricConverter.Liters * 3.785411784;
            }

            if (TargetUnitEqualsToUK(_metricConverter))
            {
                converter = _metricConverter.Liters * 4.54609;
            }

            return converter;
        }

        private bool TargetUnitEqualsToUK(MetricConverterModel _metricConverter)
        {
            return _metricConverter.TargetUnit == "UK";
        }

        private bool TargetUnitEqualsToUS(MetricConverterModel _metricConverter)
        {
            return _metricConverter.TargetUnit == "US";
        }
    }
}
