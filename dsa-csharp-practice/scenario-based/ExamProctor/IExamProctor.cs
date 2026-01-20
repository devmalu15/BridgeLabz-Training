using System;

public interface IExamProctor
    {
        void VisitQuestion(int questionId);
        void SubmitAnswer(int questionId, string answer);
        void ShowLastVisited();
        void SubmitExam();
    }