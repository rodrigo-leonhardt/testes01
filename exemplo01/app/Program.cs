namespace Exemplo01.App;

class Program
{

    public static void Main(string[] args)
    {                
        ChecarPalindromo("TOP");
        ChecarPalindromo("RETER");        
    }

    static void ChecarPalindromo(string texto)
    {
        var palindromoValido = Utilidades.PalindromoValido(texto);
        var resultado = palindromoValido ? "é" : "não é";

        Console.WriteLine("{0} {1} um palíndromo", texto, resultado);
    }

}

