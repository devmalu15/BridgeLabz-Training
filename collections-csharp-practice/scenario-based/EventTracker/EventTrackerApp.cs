using System;

public class EventTrackerApp
{
    public static void Run()
    {
        IAuditTracker tracker = new EventTrackerProcessor();
        tracker.TrackEvents(new UserService());
    }
}