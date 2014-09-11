using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClassLibrary;
using FluentAssertions;

namespace Unit_Library_Tests
{
    [TestClass]
    public class PowerTests
    {
        [TestMethod]
        public void Power_Constructors()
        {
            // Set values
            Power wattPower = new Power(PowerType.Watt, 18.2);
            Power horsepowerPower = new Power(PowerType.Horsepower, 18.2);
            Power footPoundsPerSecondPower = new Power(PowerType.FootPoundsPerSecond, 18.2);
            Power metricHorsepowerPower = new Power(PowerType.MetricHorsepower, 18.2);
            Power ergsPerSecondPower = new Power(PowerType.ErgsPerSecond, 1820000000);

            // Get values in different form from which they were instantiated
            double wattsToHorsepower = wattPower.Horsepower;
            double wattsToFootPoundsPerSecond = wattPower.FootPoundsPerSecond;
            double wattsToMetricHorsepower = wattPower.MetricHorsepower;
            double wattsToErgsPerSecond = wattPower.ErgsPerSecond;

            double horsepowerToWatts = horsepowerPower.Watt;
            double horsepowerToFootPoundsPerSecond = horsepowerPower.FootPoundsPerSecond;
            double horsepowerToMetricHorsepower = horsepowerPower.MetricHorsepower;
            double horsepowerToErgsPerSecond = horsepowerPower.ErgsPerSecond;

            double footPoundsPerSecondToWatts = footPoundsPerSecondPower.Watt;
            double footPoundsPerSecondToHorsepower = footPoundsPerSecondPower.Horsepower;
            double footPoundsPerSecondToMetricHorsepower = footPoundsPerSecondPower.MetricHorsepower;
            double footPoundsPerSecondToErgsPerSecond = footPoundsPerSecondPower.ErgsPerSecond;

            double metricHorsepowerToWatts = metricHorsepowerPower.Watt;
            double metricHorsepowerToHorsepower = metricHorsepowerPower.Horsepower;
            double metricHorsepowerToFootPoundsPerSecond = metricHorsepowerPower.FootPoundsPerSecond;
            double metricHorsepowerToErgsPerSecond = metricHorsepowerPower.ErgsPerSecond;

            double ergsPerSecondToWatts = ergsPerSecondPower.Watt;
            double ergsPerSecondToHorsepower = ergsPerSecondPower.Horsepower;
            double ergsPerSecondToFootPoundsPerSecond = ergsPerSecondPower.FootPoundsPerSecond;
            double ergsPerSecondToMetricHorsepower = ergsPerSecondPower.MetricHorsepower;

            // Assert that gotten values are correct
            wattsToHorsepower.Should().Be(0.02440660203063);
            wattsToFootPoundsPerSecond.Should().Be(13.42363111685);
            wattsToMetricHorsepower.Should().Be(0.02474511);
            wattsToErgsPerSecond.Should().Be(182000000);

            horsepowerToWatts.Should().Be(13571.7376628);
            horsepowerToFootPoundsPerSecond.Should().Be(10010);
            horsepowerToMetricHorsepower.Should().Be(18.45242983);
            horsepowerToErgsPerSecond.Should().Be(135717376628);

            footPoundsPerSecondToWatts.Should().Be(24.67588665963);
            footPoundsPerSecondToHorsepower.Should().Be(0.03309090909091);
            footPoundsPerSecondToMetricHorsepower.Should().Be(0.0335498689);
            footPoundsPerSecondToErgsPerSecond.Should().Be(246758866.5963);

            metricHorsepowerToWatts.Should().Be(13386.0772);
            metricHorsepowerToHorsepower.Should().Be(17.9510253);
            metricHorsepowerToFootPoundsPerSecond.Should().Be(9873.06391);
            metricHorsepowerToErgsPerSecond.Should().Be(133860772500);

            ergsPerSecondToWatts.Should().Be(182);
            ergsPerSecondToHorsepower.Should().Be(0.2440660203063);
            ergsPerSecondToFootPoundsPerSecond.Should().Be(134.2363111685);
            ergsPerSecondToMetricHorsepower.Should().Be(0.24745112);
        }
    }
}
