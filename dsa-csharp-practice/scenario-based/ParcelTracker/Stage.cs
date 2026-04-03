using System;
public class Stage
    {
        public string Status;
        public string Location;
        public DateTime Timestamp;
        public Stage Next;

        public Stage(string status, string location)
        {
            Status = status;
            Location = location;
            Timestamp = DateTime.Now;
            Next = null;
        }
    }