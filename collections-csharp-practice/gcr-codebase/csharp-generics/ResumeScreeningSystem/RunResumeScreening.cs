using System;

public class RunResumeScreening
    {
        public static void Main(string[] args)
        {
            var devResume = new Resume<SoftwareEngineer>("Alice");
            devResume.AddSkill("C#");
            devResume.AddSkill("SQL");
            
            var dataResume = new Resume<DataScientist>("Bob");
            dataResume.AddSkill("HTML");

            List<object> allResumes = new List<object> { devResume, dataResume };

            devResume.ScreenResume();
            dataResume.ScreenResume();
        }
    }