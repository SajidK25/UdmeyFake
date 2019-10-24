using System.Collections.Generic;

namespace UdemyAPI.Core
{
    public class tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
