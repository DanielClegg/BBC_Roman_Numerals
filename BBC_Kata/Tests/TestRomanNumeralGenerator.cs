using System;
using NUnit.Framework;
using RomanNumerals;

namespace Tests
{
    [TestFixture]
    public class TestRomanNumeralGenerator
    {
        private RomanNumeralGenerator _generator;

        [SetUp]
        public void Setup()
        {
            _generator = new RomanNumeralGenerator();
        }
        
        [Test]
        public void Test_ForValue_1_ShouldReturnI()
        {

            var result = _generator.Generate(1);
            
            Assert.IsTrue(result == "I");
        }
        
        [Test]
        public void Test_ForValue_4_ShouldReturnV()
        {
            var result = _generator.Generate(4);
            
            Assert.IsTrue(result == "IV");
        }
        
        [Test]
        public void Test_ForValue_5_ShouldReturnV()
        {
            var result = _generator.Generate(5);
            
            Assert.IsTrue(result == "V");
        }
        
        
        [Test]
        public void Test_ForValue_8_ShouldReturnVIII()
        {
            var result = _generator.Generate(8);
            
            Assert.IsTrue(result == "VIII");
        }
        
        [Test]
        public void Test_ForValue_10_ShouldReturnX()
        {
            var result = _generator.Generate(10);
            
            Assert.IsTrue(result == "X");
        }
        
        [Test]
        public void Test_ForValue_20_ShouldReturnXX()
        {
            var result = _generator.Generate(20);
            
            Assert.IsTrue(result == "XX");
        }
        
        [Test]
        public void Test_ForValue_21_ShouldReturnXXI()
        {
            var result = _generator.Generate(21);
            
            Assert.IsTrue(result == "XXI");
        }
        
        [Test]
        public void Test_ForValue_3999_ShouldReturnMMMCMXCIX()
        {
            var result = _generator.Generate(3999);
            
            Assert.IsTrue(result == "MMMCMXCIX(");
        }
    }
}