﻿using Nogupe.Web.Entities.Courses;
using Nogupe.Web.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nogupe.Web.Services.Tokens
{
    public interface ITokenService : IRepository<Token>
    {
    }
}
