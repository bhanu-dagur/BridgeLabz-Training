namespace EventTracker;

using EventTracker.Actions;
using EventTracker.Core;

class Program
{
    static void Main()
    {
        EventTrackerScanner.Scan(typeof(UserActions));
    }
}
