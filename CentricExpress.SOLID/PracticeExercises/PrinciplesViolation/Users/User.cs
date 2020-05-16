using PracticeExercises.Fix.Rights;

namespace PracticeExercises.PrinciplesViolation.Users
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public UserRights Rights { get; set; }
    }
}