namespace Movie
{
    public class Movie
    {
       public static string name;
       public int ticketId;
        public string SeatNumber;

        public Movie ReturnMovieDetails(string name, int ticketId, string seatNumber)
        {
            Movie movie = new Movie();
            name = name;
            movie.ticketId = ticketId;
            movie.SeatNumber = seatNumber;
            return movie;
        }
        static void Main(string[] args)
        {
            // Get user input
            Console.WriteLine("Enter the movie name: ");
            string movieName = Console.ReadLine();

            Console.WriteLine("Enter the ticket ID: ");
            int ticketId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seat number: ");
            string seatNumber = Console.ReadLine();

            // Create Movie object and set details
            Movie movie = new Movie();
            movie = movie.ReturnMovieDetails(movieName, ticketId, seatNumber);
            Console.WriteLine("movie name:"+movieName);
            Console.WriteLine("ticket id:" + ticketId);
            Console.WriteLine("Seat number"+seatNumber);

        }
    }
}
