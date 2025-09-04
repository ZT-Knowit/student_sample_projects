internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Idag blåser det!");
        //Metodanrop
        ShowWindChill(-5, 20);
        
    }

    /*En metod är kapslad kod som utför en specifik uppgift. Metoder hjälper till att organisera koden, göra den återanvändbar och lättare att underhålla.
    Koden inom en metod körs endast när metoden anropas. Metoder udviker också duplicera kod genom att låta dig återanvända samma kod på flera ställen i programmet.
    Metoder kan ta emot indata (parametrar) och returnera utdata (returvärden).

    Låt oss anta att du vill beräkna köldfaktorn baserat på temperatur och vindhastighet. 
    Vi skapar en metod med nament ShowWindChill som tar två parametrar: temperature och windSpeed.
    Metoden beräknar anropar en annan metod (CalculateWindChill) som beräknar köldfaktorn med hjälp av en formel och returnerar resultatet som ett double-värde.
    Inpararametrarna temperature och windSpeed är av typen double, vilket innebär att de kan ta decimaltal som indata.
    Även metodens resultat som returneras när beräkningen är färdig är av typen double vilket man kan se på typen till vänster om metodnamnet.*/

    static void ShowWindChill(double temperature, double windSpeed) //Metoddeklaration
    {
        double experiensedTemp = CalculateChillFactor(temperature, windSpeed);
        //Returvärde

        Console.WriteLine($"Den upplevda temperaturen är {experiensedTemp} °C");
    }

    private static double CalculateChillFactor(double temperature, double windSpeed)
    {
        //(Oklart om beräkningen är korrekt...)
        return 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);
    }
}