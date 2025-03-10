//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.Helpers;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of SpecificVolume.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificVolumeTestsBase : QuantityTestsBase
    {
        protected abstract double CubicFeetPerPoundInOneCubicMeterPerKilogram { get; }
        protected abstract double CubicMetersPerKilogramInOneCubicMeterPerKilogram { get; }
        protected abstract double MillicubicMetersPerKilogramInOneCubicMeterPerKilogram { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicFeetPerPoundTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double MillicubicMetersPerKilogramTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(SpecificVolumeUnit unit)
        {
            return unit switch
            {
                SpecificVolumeUnit.CubicFootPerPound => (CubicFeetPerPoundInOneCubicMeterPerKilogram, CubicFeetPerPoundTolerance),
                SpecificVolumeUnit.CubicMeterPerKilogram => (CubicMetersPerKilogramInOneCubicMeterPerKilogram, CubicMetersPerKilogramTolerance),
                SpecificVolumeUnit.MillicubicMeterPerKilogram => (MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, MillicubicMetersPerKilogramTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { SpecificVolumeUnit.CubicFootPerPound },
            new object[] { SpecificVolumeUnit.CubicMeterPerKilogram },
            new object[] { SpecificVolumeUnit.MillicubicMeterPerKilogram },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new SpecificVolume();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.PositiveInfinity, SpecificVolumeUnit.CubicMeterPerKilogram));
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.NegativeInfinity, SpecificVolumeUnit.CubicMeterPerKilogram));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.NaN, SpecificVolumeUnit.CubicMeterPerKilogram));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SpecificVolume(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new SpecificVolume(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (SpecificVolume) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void SpecificVolume_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new SpecificVolume(1, SpecificVolumeUnit.CubicMeterPerKilogram);

            QuantityInfo<SpecificVolumeUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(SpecificVolume.Zero, quantityInfo.Zero);
            Assert.Equal("SpecificVolume", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<SpecificVolumeUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void CubicMeterPerKilogramToSpecificVolumeUnits()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.CubicFeetPerPound, CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = SpecificVolume.From(1, SpecificVolumeUnit.CubicFootPerPound);
            AssertEx.EqualTolerance(1, quantity00.CubicFeetPerPound, CubicFeetPerPoundTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, quantity00.Unit);

            var quantity01 = SpecificVolume.From(1, SpecificVolumeUnit.CubicMeterPerKilogram);
            AssertEx.EqualTolerance(1, quantity01.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, quantity01.Unit);

            var quantity02 = SpecificVolume.From(1, SpecificVolumeUnit.MillicubicMeterPerKilogram);
            AssertEx.EqualTolerance(1, quantity02.MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, quantity02.Unit);

        }

        [Fact]
        public void FromCubicMetersPerKilogram_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.NegativeInfinity));
        }

        [Fact]
        public void FromCubicMetersPerKilogram_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.NaN));
        }

        [Fact]
        public void As()
        {
            var cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.CubicFootPerPound), CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.CubicMeterPerKilogram), CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.MillicubicMeterPerKilogram), MillicubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new SpecificVolume(value: 1, unit: SpecificVolume.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = SpecificVolume.Parse("1 ft³/lb", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CubicFeetPerPound, CubicFeetPerPoundTolerance);
                Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = SpecificVolume.Parse("1 m³/kg", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
                Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = SpecificVolume.Parse("1 mm³/kg", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
                Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(SpecificVolume.TryParse("1 ft³/lb", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CubicFeetPerPound, CubicFeetPerPoundTolerance);
                Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, parsed.Unit);
            }

            {
                Assert.True(SpecificVolume.TryParse("1 m³/kg", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
                Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, parsed.Unit);
            }

            {
                Assert.True(SpecificVolume.TryParse("1 mm³/kg", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
                Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = SpecificVolume.ParseUnit("ft³/lb", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = SpecificVolume.ParseUnit("m³/kg", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = SpecificVolume.ParseUnit("mm³/kg", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(SpecificVolume.TryParseUnit("ft³/lb", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, parsedUnit);
            }

            {
                Assert.True(SpecificVolume.TryParseUnit("m³/kg", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, parsedUnit);
            }

            {
                Assert.True(SpecificVolume.TryParseUnit("mm³/kg", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(SpecificVolumeUnit unit)
        {
            var inBaseUnits = SpecificVolume.From(1.0, SpecificVolume.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(SpecificVolumeUnit unit)
        {
            var quantity = SpecificVolume.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(SpecificVolumeUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = SpecificVolume.Units.First(u => u != SpecificVolume.BaseUnit);

            var quantity = SpecificVolume.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(SpecificVolumeUnit unit)
        {
            var quantity = default(SpecificVolume);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(1, SpecificVolume.FromCubicFeetPerPound(cubicmeterperkilogram.CubicFeetPerPound).CubicMetersPerKilogram, CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromCubicMetersPerKilogram(cubicmeterperkilogram.CubicMetersPerKilogram).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromMillicubicMetersPerKilogram(cubicmeterperkilogram.MillicubicMetersPerKilogram).CubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificVolume v = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(3)-v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(10)/5).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, SpecificVolume.FromCubicMetersPerKilogram(10)/SpecificVolume.FromCubicMetersPerKilogram(5), CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificVolume oneCubicMeterPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            SpecificVolume twoCubicMetersPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(2);

            Assert.True(oneCubicMeterPerKilogram < twoCubicMetersPerKilogram);
            Assert.True(oneCubicMeterPerKilogram <= twoCubicMetersPerKilogram);
            Assert.True(twoCubicMetersPerKilogram > oneCubicMeterPerKilogram);
            Assert.True(twoCubicMetersPerKilogram >= oneCubicMeterPerKilogram);

            Assert.False(oneCubicMeterPerKilogram > twoCubicMetersPerKilogram);
            Assert.False(oneCubicMeterPerKilogram >= twoCubicMetersPerKilogram);
            Assert.False(twoCubicMetersPerKilogram < oneCubicMeterPerKilogram);
            Assert.False(twoCubicMetersPerKilogram <= oneCubicMeterPerKilogram);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Equal(0, cubicmeterperkilogram.CompareTo(cubicmeterperkilogram));
            Assert.True(cubicmeterperkilogram.CompareTo(SpecificVolume.Zero) > 0);
            Assert.True(SpecificVolume.Zero.CompareTo(cubicmeterperkilogram) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentException>(() => cubicmeterperkilogram.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterperkilogram.CompareTo(null));
        }

        [Theory]
        [InlineData(1, SpecificVolumeUnit.CubicMeterPerKilogram, 1, SpecificVolumeUnit.CubicMeterPerKilogram, true)]  // Same value and unit.
        [InlineData(1, SpecificVolumeUnit.CubicMeterPerKilogram, 2, SpecificVolumeUnit.CubicMeterPerKilogram, false)] // Different value.
        [InlineData(2, SpecificVolumeUnit.CubicMeterPerKilogram, 1, SpecificVolumeUnit.CubicFootPerPound, false)] // Different value and unit.
        [InlineData(1, SpecificVolumeUnit.CubicMeterPerKilogram, 1, SpecificVolumeUnit.CubicFootPerPound, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, SpecificVolumeUnit unitA, double valueB, SpecificVolumeUnit unitB, bool expectEqual)
        {
            var a = new SpecificVolume(valueA, unitA);
            var b = new SpecificVolume(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = SpecificVolume.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.True(v.Equals(SpecificVolume.FromCubicMetersPerKilogram(1), CubicMetersPerKilogramTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificVolume.Zero, CubicMetersPerKilogramTolerance, ComparisonType.Relative));
            Assert.True(SpecificVolume.FromCubicMetersPerKilogram(100).Equals(SpecificVolume.FromCubicMetersPerKilogram(120), (double)0.3m, ComparisonType.Relative));
            Assert.False(SpecificVolume.FromCubicMetersPerKilogram(100).Equals(SpecificVolume.FromCubicMetersPerKilogram(120), (double)0.1m, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(SpecificVolume.FromCubicMetersPerKilogram(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificVolumeUnit)).Cast<SpecificVolumeUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SpecificVolume.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 ft³/lb", new SpecificVolume(1, SpecificVolumeUnit.CubicFootPerPound).ToString());
            Assert.Equal("1 m³/kg", new SpecificVolume(1, SpecificVolumeUnit.CubicMeterPerKilogram).ToString());
            Assert.Equal("1 mm³/kg", new SpecificVolume(1, SpecificVolumeUnit.MillicubicMeterPerKilogram).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 ft³/lb", new SpecificVolume(1, SpecificVolumeUnit.CubicFootPerPound).ToString(swedishCulture));
            Assert.Equal("1 m³/kg", new SpecificVolume(1, SpecificVolumeUnit.CubicMeterPerKilogram).ToString(swedishCulture));
            Assert.Equal("1 mm³/kg", new SpecificVolume(1, SpecificVolumeUnit.MillicubicMeterPerKilogram).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s1"));
            Assert.Equal("0.12 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s2"));
            Assert.Equal("0.123 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s3"));
            Assert.Equal("0.1235 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s1", culture));
            Assert.Equal("0.12 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s2", culture));
            Assert.Equal("0.123 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s3", culture));
            Assert.Equal("0.1235 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(SpecificVolume)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(SpecificVolumeUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(SpecificVolume.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(SpecificVolume.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(new {SpecificVolume.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(value);
            Assert.Equal(SpecificVolume.FromCubicMetersPerKilogram(-value), -quantity);
        }
    }
}
