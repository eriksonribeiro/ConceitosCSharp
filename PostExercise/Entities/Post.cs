using System;
using System.Collections.Generic;
using System.Text;

namespace PostExercise.Entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            this.Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.Title);
            stringBuilder.Append($"{this.Likes} Likes = ");
            stringBuilder.AppendLine(this.Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine(this.Content);
            stringBuilder.AppendLine("Comments:");
            foreach (Comment c in this.Comments)
            {
                stringBuilder.AppendLine($"- {c.Text}");
            }
            return stringBuilder.ToString();
        }
    }
}
