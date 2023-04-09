// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int totalJugador = 22;
int totalDealer = 15;
string message = "";

//Blackjack, si tienes mas puntos que el lider ganas, pero si tienes menos o te pasas de 21 entonces pierdes

Console.WriteLine($"El jugador tiene {totalJugador}");
Console.WriteLine($"El dealer tiene {totalDealer}");
if ((totalJugador > totalDealer) && totalJugador <= 21)
{
    message = "Venciste al Dealer";
}

else if ((totalJugador < totalDealer) || totalJugador >= 22)
{
    message = "La casa gana, mejor suerte para la proxima";
}

else if (totalJugador == totalDealer)
{
    message = "Empataron, por poco y no la cuentas";
}
Console.WriteLine(message);