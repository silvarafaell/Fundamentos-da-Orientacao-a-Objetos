using System;

namespace POO.ContentContext
{
    public abstract class Content
    {
        //Construtor na classe Pai
        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}