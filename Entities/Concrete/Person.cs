
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person : IEntity
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonNane { get; set; }
    }
}
