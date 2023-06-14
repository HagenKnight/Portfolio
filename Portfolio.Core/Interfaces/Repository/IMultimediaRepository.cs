﻿using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IMultimediaRepository<TContext> : IBaseRepository<Multimedia, TContext> where TContext : DbContext, new()
    {

    }

}
