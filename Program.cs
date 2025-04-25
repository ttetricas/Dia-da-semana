Console.Write("Dia da Semana");
Console.WriteLine("Digite um número de 1 a 7: ");
int numeroDigitado = Convert.ToInt32 (Console.ReadLine()!);

if (numeroDigitado == 1)
{
    Console.WriteLine("Domingo");
}
else if (numeroDigitado == 2)
{
    Console.WriteLine("Segunda-Feira");
}
else if (numeroDigitado == 3)
{
    Console.WriteLine("Terça-Feira");
}
else if (numeroDigitado == 4)
{
    Console.WriteLine("Quarta-Feira");
}
else if (numeroDigitado == 5)
{
    Console.WriteLine("Quinta-Feira");
}
else if (numeroDigitado == 6)
{
    Console.WriteLine("Sexta-Feira");
}
else if (numeroDigitado == 7)
{
    Console.WriteLine("Sabado");
}
else
{
    Console.WriteLine("Entrada invalida. tente novamente");
}



