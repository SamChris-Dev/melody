namespace Melody.Console.Helpers;

public static class DurationHelper
{
    public static string FormatDuration(int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int secondsRemaining = totalSeconds % 60;

        if (hours > 0) return $"{hours}:{minutes:D2}:{secondsRemaining:D2}";

        
        return $"{minutes}:{secondsRemaining:D2}";
        
       
    }

    public static string FormatDuration(int minutes, int seconds)
    {
        int totalSeconds = (minutes * 60) + seconds;
       
        return FormatDuration(totalSeconds);

    }


    public static int AddDurations(int a, int b, int c)
    {
        return  a+b+c;

    }
}