using Melody.Console.Helpers;


//PrintTrack("Imagine", "John Lennon",183);
//PrintTrack("Bohemian Rhapsody", "Queen", 355);
//PrintTrack("Hotel California", "Eagles", 390);

//int totalDuration = DurationHelper.AddDurations(183, 355, 390);

//Console.WriteLine($"Total: {DurationHelper.FormatDuration(totalDuration)}");

//static void PrintTrack(string title, string artist, int totalSeconds)
//{
//    Console.WriteLine($"{title} - {artist} ({DurationHelper.FormatDuration(totalSeconds)})");
//}

bool runningStatus = true;


do
{
    MenuOptions();

    bool success = int.TryParse(Console.ReadLine(), out int parsedUserChoice);
    Console.Clear();

    switch (parsedUserChoice)
    {
        case 1:
            Console.WriteLine("============================= Add Tracks =============================");
            AddTracks();
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadKey(intercept: true);
            Console.Clear();
            break;

        case 2:
            Console.WriteLine("============================= List Tracks =============================");
            ListTracks();
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadKey(intercept: true);
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("Program exiting.....");
            runningStatus = false;
            break;
        default:
            Console.WriteLine("Unknown Option");
            Console.ReadKey(intercept: true);
            Console.Clear();
            break;
    }

}
while (runningStatus);

static void MenuOptions()
{
    Console.WriteLine("============================= Menu options =============================");
    Console.WriteLine("1. Add Tracks");
    Console.WriteLine("2. List Tracks");
    Console.WriteLine("3. Exit");
    Console.WriteLine("=======================================================================");
    Console.Write("Enter option: ");
}

static string AddTracks()
{
    Console.Write("Enter track title: ");
    string? title = Console.ReadLine();
    Console.Write("Enter track duration in seconds: ");
    bool success = int.TryParse(Console.ReadLine(), out int parsedTrackDuration);
    Console.WriteLine("\n");
    Console.WriteLine($"Added: {title} - {parsedTrackDuration}");

    return $"{title} - {parsedTrackDuration}";
}

static void ListTracks()
{
    Console.WriteLine("List");
}