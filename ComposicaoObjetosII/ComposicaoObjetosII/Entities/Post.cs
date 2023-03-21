using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoObjetosII.Entities
{
    class Post
    {
        public DateTime dateTime { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }

        //lista para fazer a composição entre Post e Comments
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime dateTime, string title, string content, int likes)
        {
            this.dateTime = dateTime;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comments)
        {
            Comments.Add(comments);
        }

        public void RemoveComment(Comment comments)
        {
            Comments.Remove(comments);
        }

        //StringBuilder para gerar saída no formato string mais ágeis
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(dateTime.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
