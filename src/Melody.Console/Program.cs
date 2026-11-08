using Melody.Console.Helpers;


bool runningStatus = true;
string lastTitle = "";
int lastSeconds = 0;
int trackCount = 0;
int totalSeconds = 0;

do
{
    MenuOptions();
    
    int parsedUserChoice = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Unknown option");
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

void AddTracks()
{
    Console.Write("Enter track title: ");
    string? title = Console.ReadLine();
    Console.Write("Enter track duration in seconds: ");
    int parsedTrackDuration = int.Parse(Console.ReadLine());
    Console.WriteLine();
    lastTitle = title?? "";
    lastSeconds = parsedTrackDuration;
    trackCount++;
    totalSeconds += lastSeconds;
    string formatedTrackDuration = DurationHelper.FormatDuration(parsedTrackDuration);
    Console.WriteLine($"Added: {title} - {formatedTrackDuration}");

}

void ListTracks()
{
    string lastTrackDuration = DurationHelper.FormatDuration(lastSeconds);
    string totalTrackDuration = DurationHelper.FormatDuration(totalSeconds);
    
    if (trackCount == 0)
    {
        Console.WriteLine("No tracks yet.");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"{lastTitle} - {lastTrackDuration}");
        Console.WriteLine($"Tracks: {trackCount}, total time: {totalTrackDuration}");
    }
    
}