using System.Collections.Generic;

namespace PracticeExercises.Fix.Rights
{
    public class GuestRights : IRights
    {
        public List<string> GetValues()
        {
            return new List<string>
            {
                "read",
            }; ;
        }
    }
}