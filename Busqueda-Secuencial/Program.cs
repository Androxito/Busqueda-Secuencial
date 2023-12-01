namespace Busqueda_Secuencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ingrese el numero a buscar");
            int numeroBuscar = int.Parse(Console.ReadLine());
            int[] listanumeros = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingrese el elemento"+(i+1)+"de la lista");
                int numero = int.Parse(Console.ReadLine());
                listanumeros[i] = numero;
            }
            int posicion = 0;
            bool Bandera = false;
            while(posicion<7 && Bandera == false)
            {
                if(numeroBuscar == listanumeros[posicion])
                {
                    Bandera = true;
                    break;
                }
                posicion++;
            }
            if (Bandera == true)
            {
                Console.WriteLine($"Felicidades se encontro el numero en la posicion:{posicion}");

            }
            else
            {
                Console.WriteLine($"Perdona no se encontro el numero{numeroBuscar}");
            }
        }
    }
}