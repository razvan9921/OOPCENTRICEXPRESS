using PracticeExercises.Fix.Rights;

namespace PracticeExercises.Fix.Users
{
    public abstract class BaseUser
    {
        public IRights Rights { get; set; }

        public abstract string GetUsername();
    }
}