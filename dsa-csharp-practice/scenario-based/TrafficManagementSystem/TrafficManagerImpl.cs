using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.TrafficManagementSystem
{
    public class TrafficManagerImpl : ITrafficManager
    {
        public Vehicle QueueFront = null;
        public Vehicle QueueRear = null;
        public int QueueCount = 0;
        public int MaxQueueSize = 5;

        public Vehicle RoundaboutHead = null;
        public Vehicle RoundaboutTail = null;

        public void AddToQueue(int vehicleId)
        {
            if (QueueCount >= MaxQueueSize)
            {
                Console.WriteLine("    [!] Queue Overflow! Waiting line is full.");
                return;
            }

            Vehicle newCar = new Vehicle(vehicleId);

            if (QueueFront == null)
            {
                QueueFront = newCar;
                QueueRear = newCar;
            }
            else
            {
                QueueRear.Next = newCar;
                QueueRear = newCar;
            }
            QueueCount++;
            Console.WriteLine($"    Vehicle {vehicleId} joined the waiting queue.");
        }

        public void MoveToRoundabout()
        {
            if (QueueFront == null)
            {
                Console.WriteLine("    [!] Queue Underflow! No cars waiting to enter.");
                return;
            }

            Vehicle carToMove = QueueFront;
            QueueFront = QueueFront.Next;
            QueueCount--;

            carToMove.Next = null;

            if (RoundaboutHead == null)
            {
                RoundaboutHead = carToMove;
                RoundaboutTail = carToMove;
                RoundaboutTail.Next = RoundaboutHead;
            }
            else
            {
                RoundaboutTail.Next = carToMove;
                RoundaboutTail = carToMove;
                RoundaboutTail.Next = RoundaboutHead;
            }

            Console.WriteLine($"    Vehicle {carToMove.Id} entered the Roundabout.");
        }

        public void ExitRoundabout(int vehicleId)
        {
            if (RoundaboutHead == null)
            {
                Console.WriteLine("    [!] Roundabout is empty.");
                return;
            }

            Vehicle current = RoundaboutHead;
            Vehicle prev = RoundaboutTail;

            do
            {
                if (current.Id == vehicleId)
                {
                    if (current == RoundaboutHead && current == RoundaboutTail)
                    {
                        RoundaboutHead = null;
                        RoundaboutTail = null;
                    }
                    else
                    {
                        if (current == RoundaboutHead)
                        {
                            RoundaboutHead = RoundaboutHead.Next;
                            RoundaboutTail.Next = RoundaboutHead;
                        }
                        else if (current == RoundaboutTail)
                        {
                            RoundaboutTail = prev;
                            RoundaboutTail.Next = RoundaboutHead;
                        }
                        else
                        {
                            prev.Next = current.Next;
                        }
                    }
                    Console.WriteLine($"    Vehicle {vehicleId} exited the Roundabout.");
                    return;
                }

                prev = current;
                current = current.Next;

            } while (current != RoundaboutHead);

            Console.WriteLine($"    [!] Vehicle {vehicleId} not found in Roundabout.");
        }

        public void ShowState()
        {
            Console.WriteLine("\n    --- STATUS REPORT ---");

            Console.Write("    Waiting Queue: [ ");
            Vehicle qTemp = QueueFront;
            while (qTemp != null)
            {
                Console.Write(qTemp.Id + " ");
                qTemp = qTemp.Next;
            }
            Console.WriteLine("]");

            Console.Write("    Roundabout:    ( ");
            if (RoundaboutHead != null)
            {
                Vehicle rTemp = RoundaboutHead;
                do
                {
                    Console.Write(rTemp.Id + " -> ");
                    rTemp = rTemp.Next;
                } while (rTemp != RoundaboutHead);
                Console.Write("HEAD )");
            }
            else
            {
                Console.Write("Empty )");
            }
            Console.WriteLine("\n");
        }
    }
}
