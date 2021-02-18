using System.Collections.Generic;

namespace POO.ContentContext
{
    public class Career : Content
    {
        public Career()
        {
            Items = new List<CareerItem>();
        }

       public IList<CareerItem> Items { get; set; } 
       public int TotalCourses  =>  Items.Count;
       // Expression Body
    }    
}