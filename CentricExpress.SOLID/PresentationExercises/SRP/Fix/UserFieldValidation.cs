namespace PresentationExercises.SRP.Fix
{
public class UserFieldValidation
{
    public bool CheckAge(int age)
    {
        // random logic
        return age > 14;
    }

    public bool ValidateEmail(string email)
    {
        //random logic
        return !string.IsNullOrEmpty(email);
    }
}
}