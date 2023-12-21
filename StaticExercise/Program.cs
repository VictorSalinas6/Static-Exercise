namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(TempConverter.FahrenheitToCelsius(72)));

            Console.WriteLine(Math.Round(TempConverter.CelsiusToFahrenheit(34)));
        }
    }
}
