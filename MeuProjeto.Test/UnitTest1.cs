using Xunit;
using MeuProjeto; // Adicione este using!

public class NumeroUtilsTests
{
    [Fact]
    public void EhPar_DeveRetornarVerdadeiro_ParaNumeroPar()
    {
        // Preparação
        int numero = 4;

        // Ação
        bool resultado = NumeroUtils.EhPar(numero);

        // Verificação
        Assert.True(resultado);
    }

    [Fact]
    public void EhPar_DeveRetornarFalso_ParaNumeroImpar()
    {
        // Preparação
        int numero = 5;

        // Ação
        bool resultado = NumeroUtils.EhPar(numero);

        // Verificação
        Assert.False(resultado);
    }
}
