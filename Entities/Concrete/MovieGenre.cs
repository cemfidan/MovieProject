using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MovieGenre : IEntity
    {
        [Key]
        public int MovieGenreId { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
