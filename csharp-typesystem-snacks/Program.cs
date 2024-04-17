namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SNACK 1
            Console.WriteLine("Inserisci il primo numero:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            // Verifica del numero maggiore
            if (numero1 > numero2)
            {
                Console.WriteLine($"Il numero maggiore è: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"Il numero maggiore è: {numero2}");
            }
            else
            {
                Console.WriteLine("I numeri sono uguali.");
            }
        }
    }
}
