using System.Collections.Generic;

namespace PracticeExercises.Fix.Rights
{
    public class AdminRights : IRights
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