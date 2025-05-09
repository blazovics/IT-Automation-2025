using UltimateApp;

namespace UltimateTest
{
    public class UnitTest1
    {

        [Fact]
        public void AddTest()
        {
            int? retVal = Calculator.calculate(2, 3, Operation.Add);
            Assert.Equal(5, retVal);
        }


        [Fact]
        public void ModuloTest()
        {
            int? retVal = Calculator.calculate(10, 3, Operation.Modulo);
            Assert.Equal(1, retVal);
        }
    }
}