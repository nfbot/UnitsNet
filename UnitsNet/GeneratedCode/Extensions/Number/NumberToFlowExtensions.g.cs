﻿// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToFlow
{
    public static class NumberToFlowExtensions
    {
        #region CentilitersPerMinute

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double)"/>
        public static Flow CentilitersPerMinute(this int value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double?)"/>
        public static Flow? CentilitersPerMinute(this int? value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double)"/>
        public static Flow CentilitersPerMinute(this long value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double?)"/>
        public static Flow? CentilitersPerMinute(this long? value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double)"/>
        public static Flow CentilitersPerMinute(this double value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double?)"/>
        public static Flow? CentilitersPerMinute(this double? value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double)"/>
        public static Flow CentilitersPerMinute(this float value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double?)"/>
        public static Flow? CentilitersPerMinute(this float? value) => Flow.FromCentilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double)"/>
        public static Flow CentilitersPerMinute(this decimal value) => Flow.FromCentilitersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromCentilitersPerMinute(double?)"/>
        public static Flow? CentilitersPerMinute(this decimal? value) => Flow.FromCentilitersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicDecimeterPerMinute

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double)"/>
        public static Flow CubicDecimetersPerMinute(this int value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double?)"/>
        public static Flow? CubicDecimetersPerMinute(this int? value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double)"/>
        public static Flow CubicDecimetersPerMinute(this long value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double?)"/>
        public static Flow? CubicDecimetersPerMinute(this long? value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double)"/>
        public static Flow CubicDecimetersPerMinute(this double value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double?)"/>
        public static Flow? CubicDecimetersPerMinute(this double? value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double)"/>
        public static Flow CubicDecimetersPerMinute(this float value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double?)"/>
        public static Flow? CubicDecimetersPerMinute(this float? value) => Flow.FromCubicDecimetersPerMinute(value);

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double)"/>
        public static Flow CubicDecimetersPerMinute(this decimal value) => Flow.FromCubicDecimetersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromCubicDecimetersPerMinute(double?)"/>
        public static Flow? CubicDecimetersPerMinute(this decimal? value) => Flow.FromCubicDecimetersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicFootPerSecond

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double)"/>
        public static Flow CubicFeetPerSecond(this int value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double?)"/>
        public static Flow? CubicFeetPerSecond(this int? value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double)"/>
        public static Flow CubicFeetPerSecond(this long value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double?)"/>
        public static Flow? CubicFeetPerSecond(this long? value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double)"/>
        public static Flow CubicFeetPerSecond(this double value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double?)"/>
        public static Flow? CubicFeetPerSecond(this double? value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double)"/>
        public static Flow CubicFeetPerSecond(this float value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double?)"/>
        public static Flow? CubicFeetPerSecond(this float? value) => Flow.FromCubicFeetPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double)"/>
        public static Flow CubicFeetPerSecond(this decimal value) => Flow.FromCubicFeetPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromCubicFeetPerSecond(double?)"/>
        public static Flow? CubicFeetPerSecond(this decimal? value) => Flow.FromCubicFeetPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicMeterPerHour

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double)"/>
        public static Flow CubicMetersPerHour(this int value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double?)"/>
        public static Flow? CubicMetersPerHour(this int? value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double)"/>
        public static Flow CubicMetersPerHour(this long value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double?)"/>
        public static Flow? CubicMetersPerHour(this long? value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double)"/>
        public static Flow CubicMetersPerHour(this double value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double?)"/>
        public static Flow? CubicMetersPerHour(this double? value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double)"/>
        public static Flow CubicMetersPerHour(this float value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double?)"/>
        public static Flow? CubicMetersPerHour(this float? value) => Flow.FromCubicMetersPerHour(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double)"/>
        public static Flow CubicMetersPerHour(this decimal value) => Flow.FromCubicMetersPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromCubicMetersPerHour(double?)"/>
        public static Flow? CubicMetersPerHour(this decimal? value) => Flow.FromCubicMetersPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicMeterPerSecond

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double)"/>
        public static Flow CubicMetersPerSecond(this int value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double?)"/>
        public static Flow? CubicMetersPerSecond(this int? value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double)"/>
        public static Flow CubicMetersPerSecond(this long value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double?)"/>
        public static Flow? CubicMetersPerSecond(this long? value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double)"/>
        public static Flow CubicMetersPerSecond(this double value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double?)"/>
        public static Flow? CubicMetersPerSecond(this double? value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double)"/>
        public static Flow CubicMetersPerSecond(this float value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double?)"/>
        public static Flow? CubicMetersPerSecond(this float? value) => Flow.FromCubicMetersPerSecond(value);

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double)"/>
        public static Flow CubicMetersPerSecond(this decimal value) => Flow.FromCubicMetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromCubicMetersPerSecond(double?)"/>
        public static Flow? CubicMetersPerSecond(this decimal? value) => Flow.FromCubicMetersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecilitersPerMinute

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double)"/>
        public static Flow DecilitersPerMinute(this int value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double?)"/>
        public static Flow? DecilitersPerMinute(this int? value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double)"/>
        public static Flow DecilitersPerMinute(this long value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double?)"/>
        public static Flow? DecilitersPerMinute(this long? value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double)"/>
        public static Flow DecilitersPerMinute(this double value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double?)"/>
        public static Flow? DecilitersPerMinute(this double? value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double)"/>
        public static Flow DecilitersPerMinute(this float value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double?)"/>
        public static Flow? DecilitersPerMinute(this float? value) => Flow.FromDecilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double)"/>
        public static Flow DecilitersPerMinute(this decimal value) => Flow.FromDecilitersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromDecilitersPerMinute(double?)"/>
        public static Flow? DecilitersPerMinute(this decimal? value) => Flow.FromDecilitersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilolitersPerMinute

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double)"/>
        public static Flow KilolitersPerMinute(this int value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double?)"/>
        public static Flow? KilolitersPerMinute(this int? value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double)"/>
        public static Flow KilolitersPerMinute(this long value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double?)"/>
        public static Flow? KilolitersPerMinute(this long? value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double)"/>
        public static Flow KilolitersPerMinute(this double value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double?)"/>
        public static Flow? KilolitersPerMinute(this double? value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double)"/>
        public static Flow KilolitersPerMinute(this float value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double?)"/>
        public static Flow? KilolitersPerMinute(this float? value) => Flow.FromKilolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double)"/>
        public static Flow KilolitersPerMinute(this decimal value) => Flow.FromKilolitersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromKilolitersPerMinute(double?)"/>
        public static Flow? KilolitersPerMinute(this decimal? value) => Flow.FromKilolitersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region LitersPerHour

        /// <inheritdoc cref="Flow.FromLitersPerHour(double)"/>
        public static Flow LitersPerHour(this int value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double?)"/>
        public static Flow? LitersPerHour(this int? value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double)"/>
        public static Flow LitersPerHour(this long value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double?)"/>
        public static Flow? LitersPerHour(this long? value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double)"/>
        public static Flow LitersPerHour(this double value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double?)"/>
        public static Flow? LitersPerHour(this double? value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double)"/>
        public static Flow LitersPerHour(this float value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double?)"/>
        public static Flow? LitersPerHour(this float? value) => Flow.FromLitersPerHour(value);

        /// <inheritdoc cref="Flow.FromLitersPerHour(double)"/>
        public static Flow LitersPerHour(this decimal value) => Flow.FromLitersPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromLitersPerHour(double?)"/>
        public static Flow? LitersPerHour(this decimal? value) => Flow.FromLitersPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region LitersPerMinute

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double)"/>
        public static Flow LitersPerMinute(this int value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double?)"/>
        public static Flow? LitersPerMinute(this int? value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double)"/>
        public static Flow LitersPerMinute(this long value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double?)"/>
        public static Flow? LitersPerMinute(this long? value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double)"/>
        public static Flow LitersPerMinute(this double value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double?)"/>
        public static Flow? LitersPerMinute(this double? value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double)"/>
        public static Flow LitersPerMinute(this float value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double?)"/>
        public static Flow? LitersPerMinute(this float? value) => Flow.FromLitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double)"/>
        public static Flow LitersPerMinute(this decimal value) => Flow.FromLitersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromLitersPerMinute(double?)"/>
        public static Flow? LitersPerMinute(this decimal? value) => Flow.FromLitersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrolitersPerMinute

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double)"/>
        public static Flow MicrolitersPerMinute(this int value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double?)"/>
        public static Flow? MicrolitersPerMinute(this int? value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double)"/>
        public static Flow MicrolitersPerMinute(this long value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double?)"/>
        public static Flow? MicrolitersPerMinute(this long? value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double)"/>
        public static Flow MicrolitersPerMinute(this double value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double?)"/>
        public static Flow? MicrolitersPerMinute(this double? value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double)"/>
        public static Flow MicrolitersPerMinute(this float value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double?)"/>
        public static Flow? MicrolitersPerMinute(this float? value) => Flow.FromMicrolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double)"/>
        public static Flow MicrolitersPerMinute(this decimal value) => Flow.FromMicrolitersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromMicrolitersPerMinute(double?)"/>
        public static Flow? MicrolitersPerMinute(this decimal? value) => Flow.FromMicrolitersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillilitersPerMinute

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double)"/>
        public static Flow MillilitersPerMinute(this int value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double?)"/>
        public static Flow? MillilitersPerMinute(this int? value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double)"/>
        public static Flow MillilitersPerMinute(this long value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double?)"/>
        public static Flow? MillilitersPerMinute(this long? value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double)"/>
        public static Flow MillilitersPerMinute(this double value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double?)"/>
        public static Flow? MillilitersPerMinute(this double? value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double)"/>
        public static Flow MillilitersPerMinute(this float value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double?)"/>
        public static Flow? MillilitersPerMinute(this float? value) => Flow.FromMillilitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double)"/>
        public static Flow MillilitersPerMinute(this decimal value) => Flow.FromMillilitersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromMillilitersPerMinute(double?)"/>
        public static Flow? MillilitersPerMinute(this decimal? value) => Flow.FromMillilitersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillionUsGallonsPerDay

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double)"/>
        public static Flow MillionUsGallonsPerDay(this int value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double?)"/>
        public static Flow? MillionUsGallonsPerDay(this int? value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double)"/>
        public static Flow MillionUsGallonsPerDay(this long value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double?)"/>
        public static Flow? MillionUsGallonsPerDay(this long? value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double)"/>
        public static Flow MillionUsGallonsPerDay(this double value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double?)"/>
        public static Flow? MillionUsGallonsPerDay(this double? value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double)"/>
        public static Flow MillionUsGallonsPerDay(this float value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double?)"/>
        public static Flow? MillionUsGallonsPerDay(this float? value) => Flow.FromMillionUsGallonsPerDay(value);

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double)"/>
        public static Flow MillionUsGallonsPerDay(this decimal value) => Flow.FromMillionUsGallonsPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromMillionUsGallonsPerDay(double?)"/>
        public static Flow? MillionUsGallonsPerDay(this decimal? value) => Flow.FromMillionUsGallonsPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanolitersPerMinute

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double)"/>
        public static Flow NanolitersPerMinute(this int value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double?)"/>
        public static Flow? NanolitersPerMinute(this int? value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double)"/>
        public static Flow NanolitersPerMinute(this long value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double?)"/>
        public static Flow? NanolitersPerMinute(this long? value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double)"/>
        public static Flow NanolitersPerMinute(this double value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double?)"/>
        public static Flow? NanolitersPerMinute(this double? value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double)"/>
        public static Flow NanolitersPerMinute(this float value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double?)"/>
        public static Flow? NanolitersPerMinute(this float? value) => Flow.FromNanolitersPerMinute(value);

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double)"/>
        public static Flow NanolitersPerMinute(this decimal value) => Flow.FromNanolitersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromNanolitersPerMinute(double?)"/>
        public static Flow? NanolitersPerMinute(this decimal? value) => Flow.FromNanolitersPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region OilBarrelsPerDay

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double)"/>
        public static Flow OilBarrelsPerDay(this int value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double?)"/>
        public static Flow? OilBarrelsPerDay(this int? value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double)"/>
        public static Flow OilBarrelsPerDay(this long value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double?)"/>
        public static Flow? OilBarrelsPerDay(this long? value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double)"/>
        public static Flow OilBarrelsPerDay(this double value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double?)"/>
        public static Flow? OilBarrelsPerDay(this double? value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double)"/>
        public static Flow OilBarrelsPerDay(this float value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double?)"/>
        public static Flow? OilBarrelsPerDay(this float? value) => Flow.FromOilBarrelsPerDay(value);

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double)"/>
        public static Flow OilBarrelsPerDay(this decimal value) => Flow.FromOilBarrelsPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromOilBarrelsPerDay(double?)"/>
        public static Flow? OilBarrelsPerDay(this decimal? value) => Flow.FromOilBarrelsPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsGallonsPerMinute

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double)"/>
        public static Flow UsGallonsPerMinute(this int value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double?)"/>
        public static Flow? UsGallonsPerMinute(this int? value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double)"/>
        public static Flow UsGallonsPerMinute(this long value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double?)"/>
        public static Flow? UsGallonsPerMinute(this long? value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double)"/>
        public static Flow UsGallonsPerMinute(this double value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double?)"/>
        public static Flow? UsGallonsPerMinute(this double? value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double)"/>
        public static Flow UsGallonsPerMinute(this float value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double?)"/>
        public static Flow? UsGallonsPerMinute(this float? value) => Flow.FromUsGallonsPerMinute(value);

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double)"/>
        public static Flow UsGallonsPerMinute(this decimal value) => Flow.FromUsGallonsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Flow.FromUsGallonsPerMinute(double?)"/>
        public static Flow? UsGallonsPerMinute(this decimal? value) => Flow.FromUsGallonsPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif