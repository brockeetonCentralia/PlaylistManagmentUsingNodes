using PlaylistManagmentUsingNodes;

Playlist playlist = new Playlist();

//playlist.AddSongBeginning("No Doubt About It", "Neal McCoy", 3.45);
//playlist.AddSongEnd("Amarillo by Morning", "George Strait", 2.56);
//playlist.PrintPlaylistForward();
//playlist.PrintPlaylistBackward();
//playlist.RemoveSong("No Doubt About It", "Neal McCoy", 3.45);
//playlist.PrintPlaylistForward();
//playlist.PrintPlaylistBackward();

bool running = true;

while (running)
{
    Console.WriteLine("\n-----| Playlist Menu |-----");
    Console.WriteLine("1. Add song to beginning.");
    Console.WriteLine("2. Add song to end.");
    Console.WriteLine("3. Remove Song.");
    Console.WriteLine("4. Print Playlist forward.");
    Console.WriteLine("5. Print Playlist backward");
    Console.WriteLine("6. Exit.");
    Console.WriteLine("Please choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter song title: ");
            string title1 = Console.ReadLine();

            Console.Write("Enter song artist: ");
            string artist1 = Console.ReadLine();

            Console.Write("Enter song duration in 0.00 format: ");
            double duration1 = Convert.ToDouble(Console.ReadLine());

            playlist.AddSongBeginning(title1, artist1, duration1);

            break;

        case "2":
            Console.Write("Enter song title: ");
            string title2 = Console.ReadLine();

            Console.Write("Enter song artist: ");
            string artist2 = Console.ReadLine();

            Console.Write("Enter song duration in 0.00 format: ");
            double duration2 = Convert.ToDouble(Console.ReadLine());

            playlist.AddSongEnd(title2, artist2, duration2);

            break;

        case "3":
            Console.Write("Enter song title to remove: ");
            string title3 = Console.ReadLine();

            Console.Write("Enter song artist to remove: ");
            string artist3 = Console.ReadLine();

            Console.Write("Enter song duration to remove in 0.00 format: ");
            double duration3 = Convert.ToDouble(Console.ReadLine());

            playlist.RemoveSong(title3, artist3, duration3);

            break;

        case "4":
            playlist.PrintPlaylistForward();
            break;

        case "5":
            playlist.PrintPlaylistBackward();
            break;

        case "6":
            running = false;
            Console.WriteLine("---| Exiting |---");
            break;

        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
}