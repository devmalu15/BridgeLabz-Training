using System;

public interface IAuditTracker
{
    void TrackEvents(object serviceInstance);
}