namespace ConditionsAndSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Villkorssatser utvärderar ett uttryck för att senare välja 
            //vilket kodspår som ska köras.

            //if-satsen: "Den Enkla Frågan"
            //Det här är den mest grundläggande villkorssatsen. Den ställer en enda fråga:
            //"Är detta sant?". Om svaret är ja, utför den ett visst stycke kod. Om svaret är nej, hoppar den över koden.
            
            //Använder modulusoperatorn för att utvärdera om det just nu är en jämn minut.
            if (DateTime.Now.Minute % 2 == 0)
            {
                Console.WriteLine("Det är en jämn minut");
            }

            //if-else-satsen: "Vägvalet"
            //Den här villkorssatsen är som en förlängning av den enkla if-satsen.
            //Den ger dig ett val: om villkoret är sant, körs det första kodblocket; annars, körs det andra.
            //Den tvingar fram ett beslut och en handling oavsett utgång.

            if (DateTime.Now.Year % 2 == 0)
            {
                Console.WriteLine("Det är ett jämnt år");
            }
            else 
            { 
                Console.WriteLine("Det är ett udda år.");
                Console.WriteLine("Året är: " + DateTime.Now.Year);
            }

            //else if satsen: "Beslutsfattaren"
            //Detta är en kedja av if-else -satser som låter dig hantera flera olika scenarier.
            //Tänk på den som en beslutsfattare som går igenom en lista av frågor, en i taget.
            //Den fortsätter att fråga tills den hittar ett sant villkor,
            //och om den inte hittar något, faller den tillbaka på else-blocket som sin sista utväg.

            Random random = new Random();
            int randomNumber = random.Next(20);
            if (randomNumber < 10)
            {
                Console.WriteLine("Ett litet tal: " + randomNumber);
            }
            else if (randomNumber > 10)
            {
                Console.WriteLine("Talet är störren än tio nämligen: " + randomNumber);
            }
            else
            {
                Console.WriteLine("Talet är tio: " + randomNumber);
            }

            //switch-satsen: "Valet ur Listan"
            //switch-satsen är ett snyggt alternativ till en lång rad av if-else if-satser
            //när du jämför ett enda värde med en fast uppsättning möjliga värden.

            //Deklarerar och tilldelar en variabel av typen DayOfWeek som är en del av .NET
            DayOfWeek today = DateTime.Today.DayOfWeek;

            //Kollar värdet på variabeln today mot allamöjliga väden
            switch (today)
            {
                case DayOfWeek.Monday:
                    //I en case sats går det såklart att göra andra saker än att skriva ut strängar.
                    Console.WriteLine("Det är måndag!");
                    //Avslutar så att vi inte rasar ner i nästa case
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Det är tisdag!");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Det är onsdag!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Det är torsdag!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Det är fredag!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Det är lördag!");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Det är söndag!");
                    break;
                    //Break fångar upp värden som inte täcks av något case. Default bör alltid vara med, men 
                    //det kanske inte är så troligt att det behövs i just detta fall.
                default:
                    Console.WriteLine("En ny tidigare okänd veckodag har tillkommit");
                    break ;
            }

            //Samma switch case kan skrivas med den nya syntaxen (språkregler) som är lite mindre pladdrig.
            //Återanvänder variabeln today och tilldelar variabeln messageOfTheDay meddelandet för dagens veckodag.
            //(Går såklart att göra samma sak i första switch casen för att slippa så många Console.WriteLine.)
            string messageOfTheDay = today switch
            {
                DayOfWeek.Monday => "Det är verkligen måndag!",
                DayOfWeek.Tuesday => "Det är verkligen tisdag!",
                DayOfWeek.Wednesday => "Det är verkligen onsdag!",
                DayOfWeek.Thursday => "Det är verkligen torsdag!",
                DayOfWeek.Friday => "Det är verkligen fredag!",
                DayOfWeek.Saturday => "Det är verkligen lördag!",
                DayOfWeek.Sunday => "Det är verkligen söndag!",
                //Default är numera ett underscore
                _ => "En ny tidigare okänd veckodag har tillkommit"
            };

            Console.WriteLine(messageOfTheDay);
        }
    }
}
