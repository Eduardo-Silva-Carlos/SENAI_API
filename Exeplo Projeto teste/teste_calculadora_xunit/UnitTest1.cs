namespace teste_calculadora_xunit;

public class UnitTest1
{
    [Fact]

    public void Teste_Somar()
    {
        // Arrange - Preparar
        double pnum = 10;
        double snum = 20;
        double resultado;
        Operacoes o = new Operacoes();
        // Act - Agir
        resultado = o.Somar(pnum, snum);
        // Assert - Verificar (resultado previsto X resultado obtido)
        Assert.Equal(30, resultado);
    }
    [Fact]
    public void Teste_Multiplicar()
    {
        // Arrange - Preparar
        double pnum = 10;
        double snum = 20;
        double resultado;
        Operacoes o = new Operacoes();
        // Act - Agir
        resultado = o.Multiplicar(pnum, snum);
        // Assert - Verificar (resultado previsto X resultado obtido)
        Assert.Equal(200, resultado);
    }
}