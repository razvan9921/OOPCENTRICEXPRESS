using System.Collections.Generic;

namespace PracticeExercises.PrinciplesViolation.Rights
{
    public class AdminRights
    {
        public List<string> GetValues()
        {
            return new List<string>
            {
                "read",
                "write",
                "admin"
            };
        }
    }
}