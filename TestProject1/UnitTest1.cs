using ClassLibrary1;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly StringCalculator _calculator;

        public UnitTest1()
        {
            _calculator = new StringCalculator();
        }

        [Fact]
        public void ZeroTest()
        {
            Assert.Equal(0, _calculator.Add(""));
        }

        [Theory]
        [InlineData("2",2)]
        [InlineData("3", 3)]
        [InlineData("33", 33)]
        [InlineData("4511", 4511)]
        public void WhenStringProvided_ItShouldReturnItsValue(string input, int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }

        [Theory]
        [InlineData("2,2", 4)]
        [InlineData("3,2", 5)]
        [InlineData("33,44", 77)]
        [InlineData("451,5", 456)]
        public void WhenStringWithOneCOmaProvided_ItShouldReturnSumOfValues(string input, int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }
        [Theory]
        [InlineData("2\n2", 4)]
        [InlineData("3\n2", 5)]
        [InlineData("33\n44", 77)]
        [InlineData("451\n5", 456)]
        public void WhenStringWithOneEnterProvided_ItShouldReturnSumOfValues(string input, int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }
        [Theory]
        [InlineData("2,2\n2", 6)]
        [InlineData("3\n7,2", 12)]
        [InlineData("33\n44\n1", 78)]
        [InlineData("451\n5,1", 457)]
        public void WhenStringWithThreeNumbersProvided_ItShouldReturnSumOfValues(string input, int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }
        [Theory]
        [InlineData("2,-12\n2")]
        [InlineData("3,-12")]
        [InlineData("-33\n44\n11")]
        [InlineData("4511\n-5,1")]
        public void WhenStringWithNegativeNumbersProvided_ItShouldThrowException(string input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Add(input));
        }
        [Theory]
        [InlineData("2,2000",2)]
        [InlineData("3,12,1001",15)]
        [InlineData("33\n44\n1001",77)]
        [InlineData("4511\n5,1",6)]
        public void WhenStringWithNumbersgreaterThen1000Provided_ItShouldignoreThem(string input,int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }
    }
}