namespace ArraysAndIterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arrayer är variabler som kan hålla flera värden. En array är som en rad med fack |_|_|_|_| där du kan stoppa ett värde i varje fack.
            Tänk att du har en massa köttätande växter med olika namn som du behöver hålla reda på.
            Då kan en array vara ett bra ställe att lagra namnen i.*/

            /*På samma sätt som för andra variabler så behöver en array en typ som talar om vad som kan läggas i arrayen.
            För namnen på växterna passar typen string bra.
            Hakparenteserna [] talar om för kompilatorn att vi har att göra med en array. Kompilatorn vill också veta 
            hur många platser som ska finnas i arrayen.
            Nedan visas två sätt att skapa arrayer på, men det finns fler.*/

            //Här skapar vi en stringarray och initierar den samtidigt med våra värden och behöver därför inte ange någon storlek på arrayen.
            string[] carnivorousPlants = {"Venus flugfälla", "Kannranka", "Sileshår", "Flugtrumpet" };

            //För att komma åt ett visst värde i arrayen används ett index. Första platsen i arrayen har i C# alltid index 0.
            //Vi skriver ut elementet på plats 2 vilket ger utskriften Sileshår.

            Console.WriteLine(carnivorousPlants[2]);

            //Det går också att deklarera arrayen med nyckelordet new och sätta storleken.
            //I detta fall är arrayen av typen int och har plats för tre lyckonummer.
            int[] luckyNumbers = new int[3];

            //Vi tilldelar värdena individuellt
            luckyNumbers[0] = 42;
            luckyNumbers[1] = 2;
            luckyNumbers[2] = 666;

            //Skriver ut värdet 42 som finns i första facket
            Console.WriteLine(luckyNumbers[0]);

            //För att arbeta med ett värde i taget i arrayer så är iterationer (loopar) perfekta.
            //En loop upprepar samma kod för alla element (om man vill) i arrayen.

            // Vi skapar en heltalsarray med 100 platser.
            int[] numbersILike = new int[100];

            /*for-loopen: "Den Styrda Räknaren"
            Det här är loopen för när du vet exakt hur många gånger du vill att koden ska köras.
            Den har en inbyggd räknare som tar hand om start, stopp och steg.
            I detta fall använder vi arrayens längd för att tala om hur många varv loopen ska köra.
            Vi hade lika gärna kunnat skriva 100. (Vi börjar räkna på 0)*/


            for (int i = 0; i < numbersILike.Length; i++)
            {
                //Vi stoppar det aktuella värdet på variabeln "i"
                //på indexplatsen "i".

                numbersILike[i] = i;
            }

            /*Nu finns värdena 0-99 i arrayen.
            Vi skriver ut dem med
            foreach-loopen: "Den Automatiska Utforskaren"
            Den här loopen används när du vill gå igenom varje enskilt element i en samling,
            utan att behöva hålla reda på index.
            Det är enklare att läsa och minskar risken för fel, eftersom den sköter allt åt dig.*/

            foreach (int number in numbersILike)
            {
                //Skriver ut ett värde varje varv
                Console.WriteLine(number);
            }


            /*Ibland vet man inte hur länge en loop ska köras
            while-loopen: "Den Villkorliga Utföraren"
            Använd den här loopen när du inte vet i förväg hur många gånger koden ska köras.
            Koden fortsätter att exekveras så länge ett visst villkor är sant.*/

            int randomNumber;
            int sum = 0;
            int numberOfIterations = 0;
            //Bara ett sätt att skapa ett slumvärde
            Random random = new Random(DateTime.Now.Second);

            //While-loopen ska köras så länge som variabeln sum är mindre än 2000
            while (sum < 2000)
            {
                //Skapar ett slumpvärde mellan 0 och 6 och tilldelar det till variabeln randomNumber
                randomNumber = random.Next(7);

                //Lägger ihop det som tidigare finns i sum och ökar det med värdet i randomNumber
                //Skulle också kunna göras såhär: sum = sum + randomNumber; men den late sparar några bokstäver...
                sum += randomNumber;

                //Ökar variabeln numberOfIterations med 1 varje varv.
                numberOfIterations++;
            }
            //Skriver ut antalet varv som loopen kördes.
            Console.WriteLine("Number of iterations: " + numberOfIterations);
        }
    }
}
