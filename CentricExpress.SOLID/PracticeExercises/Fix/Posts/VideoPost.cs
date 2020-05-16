namespace PracticeExercises.Fix.Posts
{
    public class VideoPost : IPost, IResourcePost
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