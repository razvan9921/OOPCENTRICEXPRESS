using PracticeExercises.Fix.Rights;

namespace PracticeExercises.PrinciplesViolation.Users
{
    public class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdentificationNumber { get; set; }

        public AdminRights Rights { get; set; }
    }
}