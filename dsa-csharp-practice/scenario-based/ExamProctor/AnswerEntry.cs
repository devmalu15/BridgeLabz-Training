using System;

public class AnswerEntry
    {
        public int QuestionId;
        public string Answer;
        public AnswerEntry Next; 

        public AnswerEntry(int id, string ans)
        {
            QuestionId = id;
            Answer = ans;
            Next = null;
        }
    }