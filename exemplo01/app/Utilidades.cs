namespace Exemplo01.App;

public class Utilidades
{
    public static string InverterTexto(string texto)
    {
        var resultado = string.Empty;

        for (var posicao = texto.Length-1; posicao >= 0; posicao--)
            resultado += texto[posicao];

        return resultado;
    }  

    public static bool PalindromoValido(string texto)
    {
        var textoInvertido = InverterTexto(texto);

        return texto.Equals(textoInvertido);
    }

}