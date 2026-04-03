using System;

public class Resume<T> where T : JobRole, new()
    {
        public string CandidateName { get; set; }
        public T RoleTarget { get; set; } = new T();
        public List<string> CandidateSkills { get; set; } = new List<string>();

        public Resume(string name)
        {
            CandidateName = name;
        }

        public void AddSkill(string skill) => CandidateSkills.Add(skill);

        public void ScreenResume()
        {
            Console.WriteLine($"\nScreening {CandidateName} for {RoleTarget.RoleName}...");
            int matchCount = 0;
            foreach (var req in RoleTarget.RequiredSkills)
            {
                if (CandidateSkills.Contains(req)) matchCount++;
            }

            if (matchCount >= 2)
                Console.WriteLine(" -> Status: SHORTLISTED");
            else
                Console.WriteLine(" -> Status: REJECTED");
        }
    }