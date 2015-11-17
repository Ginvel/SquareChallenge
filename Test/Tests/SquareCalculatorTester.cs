using System;
using SquareChallenge.Logic;

namespace Test.Tests
{
    public class SquareCalculatorTester
    {
        private readonly Func<object, object, bool> _equalsFunc = (first, second) => first.Equals(second);
        private const string ARGUMENTS_ERROR_MESSAGE = "Входные параметры не должны быть меньше 0.";

        public bool CorrectDoubleTest()
        {
            double doublePositive = 42.5;
            var result = SquareCalculator.CalculatSquare(doublePositive, doublePositive);
            var expectedresult = doublePositive * doublePositive;
            return _equalsFunc(result, expectedresult);
        }
        public bool IncorrectDoubleTest()
        {
            double doublePositive = 42.5;
            double doubleNegative = -42.5;
            try
            {
                var result = SquareCalculator.CalculatSquare(doublePositive, doubleNegative);
            }
            catch (Exception ex)
            {
                return ex.Message.Equals(ARGUMENTS_ERROR_MESSAGE);
            }
            return false;
        }
        public bool CorrectIntTest()
        {
            int intPositive = 42;
            var result = SquareCalculator.CalculatSquare(intPositive, intPositive);
            var expectedresult = intPositive * intPositive;
            return _equalsFunc(result, expectedresult);
        }
        public bool IncorrectIntTest()
        {
            int intPositive = 42;
            int intNegative = -42;
            try
            {
                var result = SquareCalculator.CalculatSquare(intPositive, intNegative);
            }
            catch (Exception ex)
            {
                return ex.Message.Equals(ARGUMENTS_ERROR_MESSAGE);
            }
            return false;
        }
        public bool CrossTypeTest()
        {
            int intPositive = 42;
            double doublePositive = 42.5;
            var result = SquareCalculator.CalculatSquare(intPositive, doublePositive);
            var expectedresult = intPositive * doublePositive;
            return _equalsFunc(result, expectedresult);
        }
        public bool CrossTypeWithIncorrectValueTest()
        {
            int intPositive = 42; 
            double doubleNegative = -42.5;
            try
            {
                var result = SquareCalculator.CalculatSquare(intPositive, doubleNegative);
            }
            catch (Exception ex)
            {
                return ex.Message.Equals(ARGUMENTS_ERROR_MESSAGE);
            }
            return false;
        }
    }
}
