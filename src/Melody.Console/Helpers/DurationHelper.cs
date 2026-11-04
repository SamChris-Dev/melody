namespace Melody.Console.Helpers;

public static class DurationHelper
{
    public static string FormatDuration(int totalSeconds)
    {
        // Step 2
        int minutes = totalSeconds / 60;
        int secondsRemaining = totalSeconds % 60;

        return $"{minutes}:{secondsRemaining:D2}";
    }

    public static string FormatDuration(int minutes, int seconds)
    {
        // Step 3
        int totalSeconds = (minutes * 60) + seconds;
       
        return FormatDuration(totalSeconds);

    }

    public static int AddDurations(int a, int b, int c)
    {
       // step 4
        return  a+b+c;

    }
}