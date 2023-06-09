﻿using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface ILanguageRepository<TContext> : IBaseRepository<Language, TContext> where TContext : DbContext, new()
    {

    }

}
