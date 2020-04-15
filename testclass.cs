using Xunit;

namespace UnitTests
{
    public class testclass
    {
        [Theory]
        //Testando com números ímpares, resultado esperado: Aprovado
        [InlineData(3)]
        [InlineData(5)]
        //Testando com número par, resultado esperado: Falha
        [InlineData(6)]
        public void MyFirstTheory(int mynumber)
        {
            Assert.True(Program.IsOdd(mynumber));
        }

        [Fact]
        public void PassingAddTest()
        {
            //Resultado esperado: Aprovado
            Assert.Equal(4, Program.Add(2,2));
        }

        [Fact]
        public void FailingTest()
        {
            //Resultado esperado: Falha
            Assert.Equal(5, Program.Add(2,2));
        }
    }
}