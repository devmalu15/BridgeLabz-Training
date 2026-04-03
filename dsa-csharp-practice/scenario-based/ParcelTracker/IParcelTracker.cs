using System;

public interface IParcelTracker
    {
        void AddStage(string status, string location);
        void InsertCheckpoint(string status, string location, string afterStatus);
        void TrackParcel();
    }