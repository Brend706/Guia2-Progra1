using System.Collections.Generic;

//Lista de palabras
List<string> Palabras = new List<string>()
{
    "A",
    "HOLA",
    "Panes",
    "Celular",
    "Programacion",
};

//Array que almacenara la cantidad de letras de cada palabra
int[] cantLetras = new int[Palabras.Count];

for (int i = 0; i < cantLetras.Length; i++)
{
    string palabra = Palabras[i];
    cantLetras[i] = palabra.Length;
}

Console.WriteLine("Elemento --> Cantidad de Letras\n");
for (int i = 0; i < Palabras.Count; i++)
{
    Console.WriteLine(" " + Palabras[i] + "  ->  " + cantLetras[i]);
}

