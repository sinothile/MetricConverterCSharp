using MetricConverterKata.Model;

namespace MetricConverterKataTests
{
    public class MetricConverterBuilder
    {
        private MetricConverterModel _metricConverter;

        public MetricConverterBuilder()
        {
            _metricConverter = new MetricConverterModel();
        }

        public MetricConverterBuilder WithKilogram(double kilogram)
        {
            _metricConverter.Kilogram = kilogram;
            return this;
        }

        public MetricConverterBuilder WithCelsius(double celsius)
        {
            _metricConverter.Celsius = celsius;
            return this;
        }

        public MetricConverterBuilder WithKilometers(double kilometers)
        {
            _metricConverter.Kilometers = kilometers;
            return this;
        }

        public MetricConverterBuilder WithLiters(double liters)
        {
            _metricConverter.Liters = liters;
            return this;
        }

        public MetricConverterBuilder WithTargetUnit(string targetUnit)
        {
            _metricConverter.TargetUnit = targetUnit;
            return this;
        }

        public MetricConverterModel Build()
        {
            return _metricConverter;
        }
    }
}
