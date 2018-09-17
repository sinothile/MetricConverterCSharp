using System;
using MetricConverterKata;
using NUnit.Framework;

namespace MetricConverterKataTests
{
    [TestFixture]
    public class MetricConverterTests
    {
        [TestCase(1, 0.62137100000000001)]
        [TestCase(6, 3.7282260000000003d)]
        public void ConvertKilometersToMiles_GivenKilometer_ShouldReturnMiles(double input, double expected)
        {
            //Arrange
            var sut = CreateMetricConverter();
            var builder = CreateMetricConverterBuilder();
            var kilometer = builder.WithKilometers(input)
                                   .Build();

            //Act
            var actual = sut.ConvertKilometersToMiles(kilometer);

            //Assert
            Assert.AreEqual(expected, actual);
        }
            
        [TestCase(1, 33.799999999999997)]
        [TestCase(22.6, 72.680000000000007)]
        public void ConvertCelsiusToFahrenheit_GivenCelsius_ShouldReturnFahrenheit(double input, double expected)
        {
            //Arrange   
            var sut = CreateMetricConverter();
            var builder = CreateMetricConverterBuilder();
            var celsius = builder.WithCelsius(input)
                                 .Build();
            //Act
            var actual = sut.ConvertCelsiusToFahrenheit(celsius);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(55, 121.25424420168267)]
        [TestCase(9, 19.841603596638983d)]
        public void ConvertKilogramToPounds_GivenKilogram_ShouldReturnPound(double input, double expected)
        {
            //Arrange       
            var sut = CreateMetricConverter();
            var builder = CreateMetricConverterBuilder();
            var kilogram = builder.WithKilogram(input)
                                 .Build();
            //Act
            var actual = sut.ConvertKilogramToPounds(kilogram);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertLitersToGallons_GivenLitersAndTargetUnitIsUS_ShouldReturnGallonsForUS()
        {
            //Arrange       
            var sut = CreateMetricConverter();
            var builder = CreateMetricConverterBuilder();
            var input = builder.WithLiters(55)
                               .WithTargetUnit("US")
                               .Build();
            //Act
            var actual = sut.ConvertLitersToGallons(input);

            //Assert
            var expected = 208.19764812d;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertLitersToGallons_GivenLitersAndTargetUnitIsUK_ShouldReturnGallonsForUK()
        {
            //Arrange       
            var sut = CreateMetricConverter();
            var builder = CreateMetricConverterBuilder();
            var input = builder.WithLiters(55)
                .WithTargetUnit("UK")
                .Build();
            //Act
            var actual = sut.ConvertLitersToGallons(input);

            //Assert
            var expected = 250.03495000000001;
            Assert.AreEqual(expected, actual);
        }

        private MetricConverter CreateMetricConverter()
        {
            return new MetricConverter();
        }

        private MetricConverterBuilder CreateMetricConverterBuilder()
        {
            return new MetricConverterBuilder();
        }
    }
}
