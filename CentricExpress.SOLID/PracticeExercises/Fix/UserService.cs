using System.Collections.Generic;
using PracticeExercises.Fix.Users;

namespace PracticeExercises.Fix
{
    public class UserService
    {
        public string GetUserName(BaseUser user)
        {
            return user.GetUsername();
        }

        public List<string> GetRights(BaseUser user)
        {
            return user.Rights.GetValues();
        }
    }
}