//classe Modulo  do curso

namespace Balta.ContentContext
{
    using System.Collections.Generic;
    public class Module 
    {
        public Module ()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

    }
}   