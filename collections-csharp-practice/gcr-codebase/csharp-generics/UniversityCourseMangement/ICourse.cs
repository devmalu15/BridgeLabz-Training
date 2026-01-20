using System;

public interface ICourse<out T> where T : CourseType
    {
        string CourseName { get; }
        T Type { get; }
        void ShowSyllabus();
    }