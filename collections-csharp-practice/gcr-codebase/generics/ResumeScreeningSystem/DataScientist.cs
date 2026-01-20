using System;

public class DataScientist : JobRole
    {
        public override string RoleName => "Data Scientist";
        public override List<string> RequiredSkills => new List<string> { "Python", "Machine Learning", "Statistics" };
    }