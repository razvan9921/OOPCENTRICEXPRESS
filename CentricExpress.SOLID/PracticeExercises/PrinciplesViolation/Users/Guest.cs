using PracticeExercises.Fix.Rights;

namespace PracticeExercises.PrinciplesViolation.Users
{
    public class Guest
    {
        public string Name { get; set; }

        public GuestRights Rights { get; set; }
    }
}