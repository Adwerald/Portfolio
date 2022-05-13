using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewModels
{
    public class PortfolioBaseViewModel
    {
        public List<Education> Educations { get; set; }
        public About About { get; set; }
        public List<Experiences> Experiences { get; set; }
        public List<Skills> Skills { get; set; }
    }
}
