using System.Collections.Generic;

namespace PracticeExercises.PrinciplesViolation.Rights
{
    public class UserRights
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