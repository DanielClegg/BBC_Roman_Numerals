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
        public void Test_ForValue_1_Should_Return_I()
        {

            var result = _generator.Generate(1);
            
            Assert.IsTrue(result == "I");
        }
        
        [Test]
        public void Test_ForValue_4_Should_Return_IV()
        {
            var result = _generator.Generate(4);
            
            Assert.IsTrue(result == "IV");
        }
        
        [Test]
        public void Test_ForValue_5_Should_Return_V()
        {
            var result = _generator.Generate(5);
            
            Assert.IsTrue(result == "V");
        }
        
        
        [Test]
        public void Test_ForValue_8_Should_Return_VIII()
        {
            var result = _generator.Generate(8);
            
            Assert.IsTrue(result == "VIII");
        }
        
        [Test]
        public void Test_ForValue_9_Should_Return_IX()
        {
            var result = _generator.Generate(9);
            
            Assert.IsTrue(result == "IX");
        }
        
        [Test]
        public void Test_ForValue_10_Should_Return_X()
        {
            var result = _generator.Generate(10);
            
            Assert.IsTrue(result == "X");
        }
        
        [Test]
        public void Test_ForValue_20_Should_Return_XX()
        {
            var result = _generator.Generate(20);
            
            Assert.IsTrue(result == "XX");
        }
        
        [Test]
        public void Test_ForValue_21_Should_Return_XXI()
        {
            var result = _generator.Generate(21);
            
            Assert.IsTrue(result == "XXI");
        }
        
        [Test]
        public void Test_ForValue_3999_Should_Return_MMMCMXCIX()
        {
            var result = _generator.Generate(3999);
            
            Assert.IsTrue(result == "MMMCMXCIX");
        }
        
        [Test]
        public void Test_ForValue_GreaterThan3999_Should_Throw_ArgumentException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>_generator.Generate(4000));
        }
        
        [Test]
        public void Test_ForValue_0_Should_Return_nulla()
        {
            var result = _generator.Generate(0);
            
            Assert.IsTrue(result == "nulla");
        }
    }
}