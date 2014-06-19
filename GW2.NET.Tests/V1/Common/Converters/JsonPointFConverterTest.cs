﻿namespace GW2DotNET.V1.Common.Converters
{
    using System.Drawing;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>The json point f converter test.</summary>
    [TestFixture]
    public class JsonPointFConverterTest
    {
        /// <summary>The json point f converter_ Read_ both nil_ returns default.</summary>
        [Test]
        [Category("Converters")]
        public void Read_BothNil_ReturnsDefault()
        {
            const string input = "[0.0,0.0]";
            PointF expected = default(PointF);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ Read_ empty array_ returns default.</summary>
        [Test]
        [Category("Converters")]
        public void Read_EmptyArray_ReturnsDefault()
        {
            const string input = "[]";
            PointF expected = default(PointF);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ read empty_ exception is thrown for value type.</summary>
        [Test]
        [Category("Converters")]
        [ExpectedException(typeof(JsonSerializationException))]
        public void Read_Empty_ExceptionIsThrownForValueType()
        {
            string input = string.Empty;
            JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());
        }

        /// <summary>The json point f converter_ read empty_ returns null for nullable type.</summary>
        [Test]
        [Category("Converters")]
        public void Read_Empty_ReturnsNullForNullableType()
        {
            string input = string.Empty;
            var output = JsonConvert.DeserializeObject<PointF?>(input, new JsonPointFConverter());

            Assert.IsNull(output);
        }

        /// <summary>The json point f converter_ read more than two values_ converter throws json serialization exception.</summary>
        [Test]
        [Category("Converters")]
        [ExpectedException(typeof(JsonSerializationException))]
        public void Read_MoreThanTwoValues_ConverterThrowsJsonSerializationException()
        {
            const string input = "[1.2,3.4,5.6]";
            JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());
        }

        /// <summary>The json point f converter_ read negative extremes_ point f reflects input.</summary>
        [Test]
        [Category("Converters")]
        public void Read_NegativeExtremes_PointFReflectsInput()
        {
            const string input = "[-2147483648.0,-2147483648.0]";
            var expected = new PointF(int.MinValue, int.MinValue);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ read negative values_ point f refects input.</summary>
        [Test]
        [Category("Converters")]
        public void Read_NegativeValues_PointFRefectsInput()
        {
            const string input = "[-1.2,-3.4]";
            var expected = new PointF(-1.2F, -3.4F);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ read null_ returns default for value type.</summary>
        [Test]
        [Category("Converters")]
        public void Read_Null_ReturnsDefaultForValueType()
        {
            const string input = "null";
            PointF expected = default(PointF);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ read null_ returns null for nullable type.</summary>
        [Test]
        [Category("Converters")]
        public void Read_Null_ReturnsNullForNullableType()
        {
            const string input = "null";
            var output = JsonConvert.DeserializeObject<PointF?>(input, new JsonPointFConverter());

            Assert.IsNull(output);
        }

        /// <summary>The json point f converter_ read positive extremes_ point f reflects input.</summary>
        [Test]
        [Category("Converters")]
        public void Read_PositiveExtremes_PointFReflectsInput()
        {
            const string input = "[2147483647.0,2147483647.0]";
            var expected = new PointF(int.MaxValue, int.MaxValue);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ read positive values_ point f refects input.</summary>
        [Test]
        [Category("Converters")]
        public void Read_PositiveValues_PointFRefectsInput()
        {
            const string input = "[1.2,3.4]";
            var expected = new PointF(1.2F, 3.4F);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ read single nil_ returns default.</summary>
        [Test]
        [Category("Converters")]
        public void Read_SingleNil_ReturnsDefault()
        {
            const string input = "[0.0]";
            PointF expected = default(PointF);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ read single value_ converter assumes value is x.</summary>
        [Test]
        [Category("Converters")]
        public void Read_SingleValue_ConverterAssumesValueIsX()
        {
            const string input = "[1.2]";
            var expected = new PointF(1.2F, 0F);
            var actual = JsonConvert.DeserializeObject<PointF>(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ write default point f_ json reflects input.</summary>
        [Test]
        [Category("Converters")]
        public void Write_DefaultPointF_JsonReflectsInput()
        {
            const string expected = "[0.0,0.0]";
            PointF input = default(PointF);
            string actual = JsonConvert.SerializeObject(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ write negative extremes_ json reflects input.</summary>
        [Test]
        [Category("Converters")]
        public void Write_NegativeExtremes_JsonReflectsInput()
        {
            const string expected = "[-2147483648.0,-2147483648.0]";
            var input = new PointF(int.MinValue, int.MinValue);
            string actual = JsonConvert.SerializeObject(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ write negative values_ json reflects input.</summary>
        [Test]
        [Category("Converters")]
        public void Write_NegativeValues_JsonReflectsInput()
        {
            const string expected = "[-1.2,-3.4]";
            var input = new PointF(-1.2F, -3.4F);
            string actual = JsonConvert.SerializeObject(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ write positive extremes_ json reflects input.</summary>
        [Test]
        [Category("Converters")]
        [Ignore("Known bug: this test fails due to loss of accuracy in floating point numbers when working with large numbers.")]
        public void Write_PositiveExtremes_JsonReflectsInput()
        {
            const string expected = "[2147483647.0,2147483647.0]";
            var input = new PointF(int.MaxValue, int.MaxValue);
            string actual = JsonConvert.SerializeObject(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The json point f converter_ write positive values_ json reflects input.</summary>
        [Test]
        [Category("Converters")]
        public void Write_PositiveValues_JsonReflectsInput()
        {
            const string expected = "[1.2,3.4]";
            var input = new PointF(1.2F, 3.4F);
            string actual = JsonConvert.SerializeObject(input, new JsonPointFConverter());

            Assert.AreEqual(expected, actual);
        }
    }
}