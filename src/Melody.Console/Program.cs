using Melody.Console.Helpers;

PrintTrack("Imagine", "John Lennon",183);
PrintTrack("Bohemian Rhapsody", "Queen", 355);
PrintTrack("Hotel California", "Eagles", 390);

Console.WriteLine($"Total: {DurationHelper.FormatDuration(DurationHelper.AddDurations(183, 355, 390))}");



// step 2
Console.WriteLine(DurationHelper.FormatDuration(183));
Console.WriteLine(DurationHelper.FormatDuration(59));
Console.WriteLine(DurationHelper.FormatDuration(600));
Console.WriteLine(DurationHelper.FormatDuration(3725));

// step 3
Console.WriteLine(DurationHelper.FormatDuration(3,3));
Console.WriteLine(DurationHelper.FormatDuration(10, 0));

// step 4 
Console.WriteLine(DurationHelper.AddDurations(3, 3, 4));

static void PrintTrack(string title, string artist, int totalSeconds)
{
    Console.WriteLine($"{title} - {artist} ({DurationHelper.FormatDuration(totalSeconds)})");
}

