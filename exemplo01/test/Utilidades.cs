using Xunit;

namespace Exemplo01.Test;


public class Utilidades
{

    [Fact]
    public void InverterTexto_Caso1_Igual()
    {
        //Arrange
        var textoEntrada = "Rodrigo";
        var textoSaida = "ogirdoR";

        //Act
        var resposta = Exemplo01.App.Utilidades.InverterTexto(textoEntrada);

        //Assert
        Assert.Equal(textoSaida, resposta);
    }

    [Fact]
    public void InverterTexto_Caso2_Igual()
    {
        //Arrange
        var textoEntrada = "Yuri";
        var textoSaida = "iruY";

        //Act
        var resposta = Exemplo01.App.Utilidades.InverterTexto(textoEntrada);

        //Assert            
        Assert.Equal(textoSaida, resposta);            
    }

    [Theory]
    [InlineData("Rodrigo","ogirdoR")]
    [InlineData("Yuri","iruY")]
    public void InverterTexto_VariosCasos_Igual(string textoEntrada, string textoSaida)
    {
        //Arrange        

        //Act
        var resposta = Exemplo01.App.Utilidades.InverterTexto(textoEntrada);

        //Assert            
        Assert.Equal(textoSaida, resposta);            
    }

    [Theory]
    [InlineData("ASA")]
    [InlineData("RETER")]
    public void PalindromoValido_VariosCasos_Validos(string texto)
    {
        //Arrange

        //Act
        var resultado = App.Utilidades.PalindromoValido(texto);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData("SOL")]
    [InlineData("LUA")]
    public void PalindromoValido_VariosCasos_Invalidos(string texto)
    {
        //Arrange

        //Act
        var resultado = App.Utilidades.PalindromoValido(texto);

        //Assert
        Assert.False(resultado);
    }

}