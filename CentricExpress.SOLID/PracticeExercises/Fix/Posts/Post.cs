namespace PracticeExercises.Fix.Posts
{
    public class Post : IPost
    {
        private string _text { get; set; }

        public string GetText()
        {
            return _text;
        }
    }
}