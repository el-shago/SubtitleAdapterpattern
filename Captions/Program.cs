using Captions;

public class PrimeVideo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a PrimeVideo!, Selecciona una de las siguientes opciones\n");
        Console.WriteLine("1. Minions");
        Console.WriteLine("2. OnePiece");
        Console.WriteLine("3. Breaking Bad");
        Console.WriteLine("4. Rango");

        // Get user input
        string userInput = Console.ReadLine();

        // Create an instance of MovieHBO based on user input
        MovieHBO selectedMovie;
        switch (userInput)
        {
            case "1":
                selectedMovie = new MovieHBO("Minions", "Description of Minions", new DateOnly(2020, 1, 1), 1);
                break;
            case "2":
                selectedMovie = new MovieHBO("OnePiece", "Description of OnePiece", new DateOnly(2021, 3, 15), 2);
                break;
            case "3":
                selectedMovie = new MovieHBO("Breaking Bad", "Description of Breaking Bad", new DateOnly(2010, 1, 20), 3);
                break;
            case "4":
                selectedMovie = new MovieHBO("Rango", "Description of Rango", new DateOnly(2011, 7, 3), 4);
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                return;
        }

        Console.WriteLine("Has seleccionado: " + selectedMovie.Name);
        selectedMovie.PlayMovie();
    }


}

