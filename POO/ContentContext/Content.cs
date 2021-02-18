using System;

namespace POO.ContentContext
{
    public abstract class Content
    {
        //Construtor na classe Pai
        public Content()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}