using System;

public class SoftwareEngineer : JobRole
    {
        public override string RoleName => "Software Engineer";
        public override List<string> RequiredSkills => new List<string> { "C#", "SQL", "Algorithms" };
    }