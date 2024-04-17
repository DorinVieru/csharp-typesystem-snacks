namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ---------
             SNACK 1
            */
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

            /* ---------
             SNACK 2
            */
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

            /* ---------
             SNACK 3
            */
            int sum = 0; 

            // Chiedo all'utente di inserire un numero per 10 volte
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° numero:");
                int numero = Convert.ToInt32(Console.ReadLine());

                // Aggiungo il numero alla somma
                sum += numero;
            }

            Console.WriteLine("La somma di tutti i numeri inseriti è: " + sum);

            /* ---------
             SNACK 4
            */
            int somma = 0;
            double media = 0;

            // Ciclo i numeri da 2 a 10 compresi
            for (int numero = 2; numero <= 10; numero++)
            {
                somma += numero; 
            }

            // Calcolo la media
            media = (double)somma / 9; 

            Console.WriteLine("La somma dei numeri compresi da 2 a 10 è: " + somma);
            Console.WriteLine("La media dei numeri compresi da 2 a 10 è: " + media);

            /* ---------
             SNACK 5
            */
            Console.WriteLine("Inserisci un numero:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Verifica se il numero è pari o dispari
            if (number % 2 == 0)
            {
                Console.WriteLine($"Numero inserito è pari. Eccolo: {number}");
            }
            else
            {
                Console.WriteLine($"Numero inserito è disapari. Viene inserito il numero successivo: {number + 1}");
            }

            /* ---------
             SNACK 6
            */
            string[] invitates = { "Dorin", "Davide", "Andrea", "Calin", "Mirko" };

            Console.Write("Inserisci il tuo nome: ");
            string userName = Convert.ToString(Console.ReadLine());

            // Verifica se il nome dell'utente è presente nell'array invitates
            bool invitate = false;
            foreach (string nome in invitates)
            {
                if (nome.Equals(userName, StringComparison.OrdinalIgnoreCase))
                {
                    invitate = true;
                    break;
                }
            }

            // Messaggio all'utente se può partecipare o meno alla festa
            if (invitate)
            {
                Console.WriteLine("Sei stato invitato alla festa del Grande Gatsby. Che bravo!");
            }
            else
            {
                Console.WriteLine("Mi dispiace, ti conviene andartene prima che finisca malissimo.");
            }

            /* ---------
             SNACK 7
            */
            int[] oddNumber = new int[6];
            int index = 0;

            // Chiedo all'utente di inserire un numero per 6 volte
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Inserisci un numero: ");
                int newNumber = Convert.ToInt32(Console.ReadLine());

                // Verifica se il numero inserito è dispari
                if (newNumber % 2 != 0)
                {
                    oddNumber[index] = newNumber;
                    index++;
                }
            }

            // Stampo i numeri dispari inseriti nell'array
            Console.WriteLine("I numeri dispari inseriti sono:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(oddNumber[i]);
            }
        }
    }
}
