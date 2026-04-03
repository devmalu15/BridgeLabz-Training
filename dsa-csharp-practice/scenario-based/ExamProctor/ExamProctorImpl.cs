using System;

public class ExamProctorImpl : IExamProctor
    {
        public NavNode StackTop = null;
        
        public AnswerEntry[] AnswerMap;
        public int MapSize = 10;

        public ExamProctorImpl()
        {
            AnswerMap = new AnswerEntry[MapSize];
        }

        public void VisitQuestion(int questionId)
        {
            NavNode newNode = new NavNode(questionId);
            newNode.Next = StackTop;
            StackTop = newNode;
            Console.WriteLine($"    [Nav] Visited Question {questionId}");
        }

        public void ShowLastVisited()
        {
            if (StackTop == null)
                Console.WriteLine("    [Nav] No questions visited yet.");
            else
                Console.WriteLine($"    [Nav] Last Visited: Question {StackTop.QuestionId}");
        }

        public int GetHash(int key)
        {
            return key % MapSize;
        }

        public void SubmitAnswer(int questionId, string answer)
        {
            int index = GetHash(questionId);
            AnswerEntry current = AnswerMap[index];
            
            while (current != null)
            {
                if (current.QuestionId == questionId)
                {
                    current.Answer = answer; 
                    Console.WriteLine($"    [Save] Answer updated for Q{questionId}");
                    return;
                }
                current = current.Next;
            }

            AnswerEntry newEntry = new AnswerEntry(questionId, answer);
            newEntry.Next = AnswerMap[index];
            AnswerMap[index] = newEntry;
            Console.WriteLine($"    [Save] Answer saved for Q{questionId}");
            
            VisitQuestion(questionId);
        }

        public void SubmitExam()
        {
            Console.WriteLine("\n    === EXAM RESULTS ===");
            int score = 0;
            int total = 3; 

            score += CheckAnswer(1, "A");
            score += CheckAnswer(2, "B");
            score += CheckAnswer(3, "C");

            Console.WriteLine($"    Final Score: {score}/{total}");
            Console.WriteLine("    ====================\n");
        }

        public int CheckAnswer(int qId, string correctAnswer)
        {
            int index = GetHash(qId);
            AnswerEntry current = AnswerMap[index];

            string studentAns = "Not Answered";

            while (current != null)
            {
                if (current.QuestionId == qId)
                {
                    studentAns = current.Answer;
                    break;
                }
                current = current.Next;
            }

            Console.Write($"    Q{qId}: Correct='{correctAnswer}', Yours='{studentAns}'");
            if (studentAns == correctAnswer)
            {
                Console.WriteLine(" [CORRECT]");
                return 1;
            }
            Console.WriteLine(" [WRONG]");
            return 0;
        }
    }