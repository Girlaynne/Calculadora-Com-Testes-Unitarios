using System.Globalization;
using CalculadoraConsole;

namespace CalculadoraTest;
public class CalculadoraTeste
{
    public Calculadora construirClasse()
    {
        string data = "07/10/2024";
        Calculadora calc = new Calculadora("07/10/2024");

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculo = calc.somar(num1, num2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculo = calc.multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculo = calc.dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (10, 5, 5)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculo = calc.subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        // Tratar divições com zero.
        Assert.Throws<DivideByZeroException>( () => calc.dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();

        // Vai verificar se a lista está vazia.
        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}

