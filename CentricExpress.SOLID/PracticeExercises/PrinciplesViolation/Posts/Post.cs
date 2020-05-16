namespace PracticeExercises.PrinciplesViolation.Posts
{
    public class Post : IPost
    {
        private string _text { get; set; }

        public string GetText()
        {
            return _text;
        }

        public string GetResourcePath()
        {
            throw new System.NotImplementedException();
        }
    }
}