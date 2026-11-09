using Melody.Console.Helpers;


bool runningStatus = true;
List<string> titles = new List<string>();
int totalSeconds = 0;

do
{
    ShowMenu();

    bool userChoiceResult = int.TryParse(Console.ReadLine(), out int parsedUserChoice);
    Console.Clear();
    if (userChoiceResult)
    {
        switch (parsedUserChoice)
        {
            case 1:
                Console.WriteLine("============================= Add Tracks =============================");

                totalSeconds += AddTrack(titles);
                Pause();
                break;

            case 2:
                Console.WriteLine("============================= List Tracks =============================");
                ListTracks(titles, totalSeconds);
                Pause();
                break;
            case 3:
                Console.WriteLine("Program exiting.....");
                runningStatus = false;
                break;
            default:
                Console.WriteLine("Unknown option.");
                Pause();
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter a number.");
        Pause();
    }

}
while (runningStatus);

static void ShowMenu()
{
    Console.WriteLine("============================= Menu options =============================");
    Console.WriteLine("1. Add Tracks");
    Console.WriteLine("2. List Tracks");
    Console.WriteLine("3. Exit");
    Console.WriteLine("=======================================================================");
    Console.Write("Enter option: ");
}

static int AddTrack(List<string> titles)
{
    Console.Write("Enter track title: ");
    string title = (Console.ReadLine()?? "").Trim();
    if (string.IsNullOrWhiteSpace(title))
    {
        Console.WriteLine();
        Console.WriteLine("Title can't be empty.");

        return 0;
    }


    Console.Write("Enter track duration in seconds: ");
    bool trackDurationResult = int.TryParse(Console.ReadLine(), out int parsedTrackDuration);

    if (!trackDurationResult || parsedTrackDuration <= 0)
    {
        Console.WriteLine();
        Console.WriteLine("Duration must be a positive number.");
        return 0;

    }
    
    
    titles.Add(title);
    Console.WriteLine($"Added: {title} - {DurationHelper.FormatDuration(parsedTrackDuration)}");
    return parsedTrackDuration;
    
}

static void ListTracks(List<string> titles, int totalSeconds)
{

    string totalTrackDuration = DurationHelper.FormatDuration(totalSeconds);
    
    if (titles.Count == 0)
    {
        Console.WriteLine("No tracks yet.");
        Console.WriteLine();
    }
    else
    {

        for (int i = 0; i < titles.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {titles[i]}");
        }
        Console.WriteLine();
        Console.WriteLine($"Tracks: {titles.Count}, total time: {totalTrackDuration}");
    }
    
}

static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("Press any key to go back to the main menu");
    Console.ReadKey(intercept: true);
    Console.Clear();
}