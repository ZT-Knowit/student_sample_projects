namespace TheBasics
{    
    //Den gröna texten är kommentarer som ignoreras av kompilatorn.
    //Kommentarer är till för att förtydliga kod för andra och sig själv.
    internal class Program
    {
        //Main är en speciell metod som startar programmet.
        //En metod är en inkapslad uppsättning instruktioner som åstadkommer något.
        //Metoden Main vill ha en array (lista ungefär) som ofta kallas args men som skulle kunna heta vad somhelst.
        //Array args kan innehålla information för att metoden ska vara nöjd med livet.
        //I vårt exempel används inte arrayen args.
        static void Main(string[] args)
        {
            //Här metoden WriteLine ut en valfri text i konsolfönstret.
            //Semikolonet avslutar en sats. Annars förstår inte kompilatorn att vi är klara.
            //Tryck på F5 eller välj gröna "play"-knappen för
            //att köra programmet.

            Console.WriteLine("Hello, World!");

            //Vi deklarerar (skapar) en variabel (en behållare för värden) och tilldelar den ett värde.
            //Variabeln heter petName och är av typen string, som är
            //en text som kan innehålla bokstäver, siffror och andra tecken.

            string petName = "Guldnos";

            //Nu innehåller variabeln petName strängen Guldnos;
            //Vi skriver ut variabeln för att vara säkra.

            Console.WriteLine(petName);

            //Vi deklarerar och tilldelar tre variabler av typen int som är bra på att lagra heltal.
            //Två i ett svep för att visa att det går och en för att det ska vara tydligt. 

            int firstNumber = 11, secondNumber = 31;
            int sum;
            
            //Vi vill beräkna summan av firstNumber och secondNumber och lägga resultatet i variabeln sum.
            //Även detta skulle kunna göras i samband med att variabeln sum deklareras.
            sum = firstNumber + secondNumber;

            //Skriver ut summan i konsolfönstret.
            Console.WriteLine(sum);

            Console.WriteLine("------ Här konverterar vi med int.Parse och fångar vi ett exception \n om det inte går att konvertera en sträng till ett heltal----------");
            Console.WriteLine("Hur gammal är du?");
            string ageAsString = Console.ReadLine();
            int age = 0;
            //Lita aldrig på att användaren matar in det du förväntar dig.
            //Om användaren matar in något som inte är ett heltal kraschar programmet.
            //Vi kan hantera detta med en try-catch-sats.
            try
            {
                age = int.Parse(ageAsString);
                Console.WriteLine($"Du är {age} år gammal.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Det där var inget heltal...");
            }
            finally
            {
                Console.WriteLine("Tack för visat intresse!");
            }

            Console.WriteLine("-------Nu kollar vi om konverteringen gick bra när vi försöker konvertera.----------");
            Console.WriteLine("Hur gammal är du?");
            ageAsString = Console.ReadLine();
            age = 0;
            //Här kollar vi istället om inmatningen är ett heltal med metoden TryParse.
            //TryParse returnerar true eller false beroende på om inmatningen kan konverteras till ett heltal eller inte.
            bool canBeConvertedToInt = int.TryParse(ageAsString,out age);
            //Om inmatningen kan konverteras till ett heltal läggs värdet i variabeln age.
            //Om inmatningen inte kan konverteras till ett heltal behålls värdet i age som är 0.
            if (canBeConvertedToInt)
            {
                Console.WriteLine($"Du är {age} år gammal.");
            }
            else
            {
                Console.WriteLine($"{ageAsString} är inget heltal...");
            }
            
            

        }
    }
}
