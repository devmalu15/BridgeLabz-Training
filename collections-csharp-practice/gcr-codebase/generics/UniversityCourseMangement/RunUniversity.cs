using System;

public class RunUniversity
    {
        public static void Main(string[] args)
        {
            ICourse<ExamCourse> math = new Course<ExamCourse>("Mathematics 101");
            ICourse<AssignmentCourse> cs = new Course<AssignmentCourse>("Computer Science 101");

            List<ICourse<CourseType>> semesterCourses = new List<ICourse<CourseType>>();
            
            semesterCourses.Add(math);
            semesterCourses.Add(cs);

            Console.WriteLine("--- Semester Courses ---");
            foreach (var course in semesterCourses)
            {
                course.ShowSyllabus();
            }
        }
    }