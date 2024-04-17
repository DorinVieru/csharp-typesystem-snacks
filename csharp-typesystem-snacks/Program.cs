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

            // SNACK 2
            Console.WriteLine("Inserisci una parola a tua scelta:");
            string word1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Inserisci una seconda parola a tua scelta:");
            string word2 = Convert.ToString(Console.ReadLine());

            // Calcolo delle lunghezze delle parole
            int wordLenght1 = word1.Length;
            int wordlenght2 = word2.Length;

            // Stampa delle parole in ordine di lunghezza
            if (wordLenght1 < wordlenght2)
            {
                Console.WriteLine($"La parola più corta è: {word1}");
                Console.WriteLine($"La parola più lunga è: {word2}");
            }
            else if (wordlenght2 < wordLenght1)
            {
                Console.WriteLine($"La parola più corta è: {word1}");
                Console.WriteLine($"La parola più lunga è: {word2}");
            }
            else
            {
                Console.WriteLine("Le parole hanno la stessa lunghezza.");
            }
        }
    }
}
