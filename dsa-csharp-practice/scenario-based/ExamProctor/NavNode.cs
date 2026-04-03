using System;

public class NavNode
    {
        public int QuestionId;
        public NavNode Next;

        public NavNode(int id)
        {
            QuestionId = id;
            Next = null;
        }
    }