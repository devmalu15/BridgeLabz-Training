using System;

public abstract class JobRole
    {
        public abstract string RoleName { get; }
        public abstract List<string> RequiredSkills { get; }
    }