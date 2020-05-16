namespace PracticeExercises.Fix.Users
{
    public class User : BaseUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string GetUsername()
        {
            return $"{FirstName} {LastName}";
        }
    }
}