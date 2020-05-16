namespace PresentationExercises.SRP.PrincipleViolation
{
    public class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public bool CheckAge()
        {
            // random logic
            return Age > 14;
        }

        public bool ValidateEmail()
        {

            return !string.IsNullOrEmpty(Email);
        }
    }
}