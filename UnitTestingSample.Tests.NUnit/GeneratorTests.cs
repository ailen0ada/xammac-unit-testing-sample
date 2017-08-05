using System;
using System.Text.RegularExpressions;
using UnitTestingSample.Models;
using NUnit.Framework;

namespace UnitTestingSample.Tests
{
    [TestFixture]
    public class GeneratorTests
    {
        [Test]
        public void GeneratingTest()
        {
            var expectedPattern = @"^[0-9]{4}-[0-9]{2}-[0-9]{2}_[0-9]{6}_[0-9a-z]{7}$";

            var generator = new TempFileNameGenerator();
            var actual = generator.Generate();

            Assert.True(Regex.IsMatch(actual, expectedPattern));
        }
    }
}
