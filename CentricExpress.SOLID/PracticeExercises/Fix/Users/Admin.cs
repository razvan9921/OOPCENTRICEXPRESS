namespace PracticeExercises.Fix.Users
{
    public class Admin : BaseUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdentificationNumber { get; set; }

        public override string GetUsername()
        {
            return $"{FirstName} {LastName} - {IdentificationNumber}";
        }
    }
}