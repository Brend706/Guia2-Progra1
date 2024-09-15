using System.Collections;
class ejercicio1
{
    static void Main( String[] args)
    {
        ArrayList leer = new ArrayList();
        ArrayList ver = new ArrayList();
       

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Ingrese un numero");
            String numero = Console.ReadLine();
            int num;

            if (int.TryParse(numero, out num))
            {
                leer.Add(num);
            }
            else
            {
                Console.WriteLine("invalido");
            }
        }
            foreach (int dato in leer)
            {
                ver.Add(dato * 3);
            }
            Console.WriteLine("\nArrayList leer:");

            foreach (int dato in leer)
            {
                Console.WriteLine(dato + " ");
            }
            Console.WriteLine("\n\nArrayList ver (Triple de los numeros de la lista de leer):");

            foreach (int dato in ver)
            {
                Console.WriteLine(dato + " ");
            }
    }
}