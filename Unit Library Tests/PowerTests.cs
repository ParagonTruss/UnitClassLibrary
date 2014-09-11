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
            wattsToHorsepower.Should().BeApproximately(0.024406602, 0.024406602 * 0.000001); // TODO: change second arg to accepted deviation value FOR ALL OF THESE
            wattsToFootPoundsPerSecond.Should().BeApproximately(13.42363111685, 13.42363111685 * 0.000001);
            wattsToMetricHorsepower.Should().BeApproximately(0.02474511, 0.02474511 * 0.000001);
            wattsToErgsPerSecond.Should().BeApproximately(182000000, 182000000 * 0.000001);

            horsepowerToWatts.Should().BeApproximately(13571.7376628, 13571.7376628 * 0.000001);
            horsepowerToFootPoundsPerSecond.Should().BeApproximately(10010, 10010 * 0.000001);
            horsepowerToMetricHorsepower.Should().BeApproximately(18.45242983, 18.45242983 * 0.000001);
            horsepowerToErgsPerSecond.Should().BeApproximately(135717376628, 135717376628 * 0.000001);

            footPoundsPerSecondToWatts.Should().BeApproximately(24.67588665963, 24.67588665963 * 0.000001);
            footPoundsPerSecondToHorsepower.Should().BeApproximately(0.03309090909091, 0.03309090909091 * 0.000001);
            footPoundsPerSecondToMetricHorsepower.Should().BeApproximately(0.0335498689, 0.0335498689 * 0.000001);
            footPoundsPerSecondToErgsPerSecond.Should().BeApproximately(246758866.5963, 246758866.5963 * 0.000001);

            metricHorsepowerToWatts.Should().BeApproximately(13386.0772, 13386.0772 * 0.000001);
            metricHorsepowerToHorsepower.Should().BeApproximately(17.9510253, 17.9510253 * 0.000001);
            metricHorsepowerToFootPoundsPerSecond.Should().BeApproximately(9873.06391, 9873.06391 * 0.000001);
            metricHorsepowerToErgsPerSecond.Should().BeApproximately(133860772500, 133860772500 * 0.000001);

            ergsPerSecondToWatts.Should().Be(182);
            ergsPerSecondToHorsepower.Should().BeApproximately(0.2440660203063, 0.2440660203063 * 0.000001);
            ergsPerSecondToFootPoundsPerSecond.Should().BeApproximately(134.2363111685, 134.2363111685 * 0.000001);
            ergsPerSecondToMetricHorsepower.Should().BeApproximately(0.24745112, 0.24745112 * 0.000001);
        }
    }
}
