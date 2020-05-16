namespace PracticeExercises.Fix.Users
{
    public class Guest : BaseUser
    {
        public string Name { get; set; }

        public override string GetUsername()
        {
            return $"{Name}";
        }
    }
}