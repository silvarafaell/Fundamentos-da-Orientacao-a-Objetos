using System.Collections.Generic;

namespace POO.ContentContext
{
    public class Course : Content
    {
        //Construtor
        public Course()
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
    }

    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
    }
}