using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedAsp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime ShareDate { get; set; }
    }
}
