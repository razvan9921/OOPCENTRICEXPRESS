using System.Collections.Generic;
using System.Linq;
using PracticeExercises.PrinciplesViolation.Users;

namespace PracticeExercises.PrinciplesViolation
{
    public class UserService
    {
        public string GetUserName(object user)
        {
            var username = string.Empty;
        
            if (user is Admin)
            {
                var admin = (Admin) user;
                username = $"{admin.FirstName} {admin.LastName} - {admin.IdentificationNumber}";
            }
            else if (user is User)
            {
                var admin = (User)user;
                username = $"{admin.FirstName} {admin.LastName}";
            }
            else if (user is Guest)
            {
                var admin = (Guest)user;
                username = $"{admin.Name}";
            }
        
            return username;
        }

        public List<string> GetUserRights(object user)
        {
            // add logic here for rights

            return new List<string>();
        }

        public bool ValidateAdminRight(List<string> userRights)
        {
            return userRights.Any(right => right.Equals("admin"));
        }

        public bool ValidateWriteRight(List<string> userRights)
        {
            return userRights.Any(right => right.Equals("write"));
        }
    }
}