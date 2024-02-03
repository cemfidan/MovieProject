using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Movie : IEntity
    {
        [Key]
        public int MovieId { get; set; }
        public int Runtime { get; set; }
        public string Title { get; set; }
        public string HomePage { get; set; }
        public string Overview { get; set; }
        public string Tagline { get; set; }
        public string ReleaseDate { get; set; }
        public string MovieStatus { get; set; }
        public double VoteAverage { get; set; }
        public double Popularity { get; set; }
        public int VoteCount { get; set; }
        public long Budget { get; set; }
        public long Revenue { get; set; }
    }
}
