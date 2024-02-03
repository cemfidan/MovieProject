﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cast : IEntity
    {
        [Key]
        public int CastId { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string CharacterName { get; set; }
    }
}
