using System.Collections.Generic;

namespace PracticeExercises.Fix.Rights
{
    public class UserRights : IRights
    {
        public List<string> GetValues()
        {
            return new List<string>
            {
                "read",
                "write",
            }; ;
        }
    }
}