List<int> Numeros = new List<int> ();
for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    int numero = int.Parse(Console.ReadLine());
    Numeros.Add(numero);
}
Console.WriteLine("\nLista de números: " + string.Join(", ", Numeros));

int maximo = Numeros.Max();
int posicionMaximo = Numeros.IndexOf(maximo);


int minimo = Numeros.Min();
int posicionMinimo = Numeros.IndexOf(minimo);


List<int> numerosOrdenados = Numeros.OrderBy(n => n).ToList();
int medio = numerosOrdenados[2];
int posicionMedio = Numeros.IndexOf(medio);


Console.WriteLine($"\nNúmero mayor: {maximo}, en la posición: {posicionMaximo}");
Console.WriteLine($"Número del medio: {medio}, en la posición: {posicionMedio}");
Console.WriteLine($"Número menor: {minimo}, en la posición: {posicionMinimo}");




Console.ReadKey();
