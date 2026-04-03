using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.RoundsRobinScheduling
{
    public class SchedulerList
    {
        public Node Head;

        public void AddProcess(int id, int burst, int priority)
        {
            Node newNode = new Node(id, burst, priority);
            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
                return;
            }
            Node temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = Head;
        }

        public void SimulateRoundRobin(int quantum)
        {
            if (Head == null) return;
            bool done;
            int time = 0;
            do
            {
                done = true;
                Node temp = Head;
                do
                {
                    if (temp.RemainingTime > 0)
                    {
                        done = false;
                        if (temp.RemainingTime > quantum)
                        {
                            time += quantum;
                            temp.RemainingTime -= quantum;
                        }
                        else
                        {
                            time += temp.RemainingTime;
                            temp.RemainingTime = 0;
                            temp.TurnAroundTime = time;
                            temp.WaitingTime = time - temp.BurstTime;
                            Console.WriteLine("Process " + temp.ProcessID + " finished at time " + time);
                        }
                    }
                    temp = temp.Next;
                } while (temp != Head);
            } while (!done);
            CalculateAverages();
        }

        public void CalculateAverages()
        {
            if (Head == null) return;
            double totalWait = 0, totalTurnAround = 0;
            int count = 0;
            Node temp = Head;
            do
            {
                totalWait += temp.WaitingTime;
                totalTurnAround += temp.TurnAroundTime;
                count++;
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine("Avg Wait Time: " + (totalWait / count));
            Console.WriteLine("Avg Turn Around Time: " + (totalTurnAround / count));
        }

        public void DisplayAll()
        {
            if (Head == null) return;
            Node temp = Head;
            do
            {
                Console.Write("P" + temp.ProcessID + "(" + temp.BurstTime + ") ");
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine();
        }
    }
}
