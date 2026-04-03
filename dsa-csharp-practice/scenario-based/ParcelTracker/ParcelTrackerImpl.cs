using System;

public class ParcelTrackerImpl : IParcelTracker
    {
        public Stage Head = null;

        public void AddStage(string status, string location)
        {
            Stage newNode = new Stage(status, location);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Stage temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            Console.WriteLine($"    [+] Status Updated: {status}");
        }

        public void InsertCheckpoint(string status, string location, string afterStatus)
        {
            if (Head == null)
            {
                Console.WriteLine("    [!] Tracking not started yet.");
                return;
            }

            Stage temp = Head;
            while (temp != null)
            {
                if (temp.Status == afterStatus)
                {
                    Stage newNode = new Stage(status, location);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    Console.WriteLine($"    [+] Checkpoint '{status}' added after '{afterStatus}'.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine($"    [!] Status '{afterStatus}' not found.");
        }

        public void TrackParcel()
        {
            Console.WriteLine("\n    === TRACKING HISTORY ===");
            Stage temp = Head;
            if (temp == null)
            {
                Console.WriteLine("    [!] No data found. Parcel might be lost (Null Pointer).");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine($"    v");
                Console.WriteLine($"    [{temp.Timestamp.ToShortTimeString()}] {temp.Status}");
                Console.WriteLine($"    Location: {temp.Location}");
                temp = temp.Next;
            }
            Console.WriteLine("    [END]\n");
        }
    }