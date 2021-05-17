namespace PostExercise.Entities
{
    public class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            this.Text = text;
        }
    }
}
