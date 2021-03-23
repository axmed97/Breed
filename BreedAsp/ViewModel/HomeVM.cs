using BreedAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedAsp.ViewModel
{
    public class HomeVM
    {
        public Header Header { get; set; }
        public AboutSection AboutSection { get; set; }
        public List<Service> Services { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Brands> Brands { get; set; }
    }
}
