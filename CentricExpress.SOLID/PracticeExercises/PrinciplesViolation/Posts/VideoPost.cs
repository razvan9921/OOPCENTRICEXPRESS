namespace PracticeExercises.PrinciplesViolation.Posts
{
    public class VideoPost : IPost
    {
        private string _resourcePath { get; set; }

        private string _text { get; set; }

        public string GetText()
        {
            return _text;
        }

        public string GetResourcePath()
        {
            return _resourcePath;
        }
    }
}