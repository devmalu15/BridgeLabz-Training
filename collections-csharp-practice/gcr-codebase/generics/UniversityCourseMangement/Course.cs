using System;

public class Course<T> : ICourse<T> where T : CourseType, new()
    {
        public string CourseName { get; set; }
        public T Type { get; set; } = new T();

        public Course(string name)
        {
            CourseName = name;
        }

        public void ShowSyllabus()
        {
            Console.WriteLine($"Course: {CourseName} | Evaluation: {Type.EvalMethod}");
        }
    }