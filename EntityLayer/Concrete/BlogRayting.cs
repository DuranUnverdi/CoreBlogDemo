using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public class BlogRayting
    {
        public int BlogRaytingId { get; set; }
        public int BlogId { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRaytingCount { get; set; }
    }
}
