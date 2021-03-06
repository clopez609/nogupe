﻿using Nogupe.Web.Entities.Matters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nogupe.Web.Entities.Careers
{
    public class Career : Entity<int>
    {
        public string Name { get; set; }
        public ICollection<Matter> Matters { get; set; }
    }
}
